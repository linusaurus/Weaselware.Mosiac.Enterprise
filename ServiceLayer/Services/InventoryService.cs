using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ServiceLayer
{
    public class InventoryService : IDisposable
    {
        private readonly MosaicContext _ctx;
        public InventoryService(MosaicContext context)
        {
            _ctx = context;
        }
        public  PickListDto? GetPickList(int pickListID)
        {
            var result = _ctx.PickList.Include(l => l.PickListItem).Include(e => e.Employee).AsNoTracking().Where(p => p.PickListID == pickListID).Select(dto => new PickListDto
            {
                PickListID = dto.PickListID,
                DateStamp = dto.DateStamp.GetValueOrDefault(),
                JobID = dto.JobID.GetValueOrDefault(),
                JobName = dto.Job.jobname,
                Preparer = dto.Employee.firstname,
                ItemCount = dto.ItemCount.GetValueOrDefault(),
                EmployeeID = dto.EmployeeID.GetValueOrDefault()

            }).FirstOrDefault();

            return result;
        }

        public Inventory FindLineItem(int lineId)
        {
           return _ctx.Inventory.Where(c => c.LineID == lineId).FirstOrDefault();
            
        }

        public List<PartTransactionListDto> GetPartTransactions(int partID)
        {
            if (partID != 0)
            {
                var result = _ctx.Inventory.Include(t => t.TransActionTypeNavigation).Include(e => e.Emp).Include(u => u.UnitOfMeasure).Include(p => p.Part).AsNoTracking().Where(p => p.PartID == partID).Select(dto => new PartTransactionListDto
                {
                    StockTransactionId = dto.StockTransactionID,
                    PartID = dto.PartID.GetValueOrDefault(),
                    Location = dto.Part.LocationNavigation.LocationName,
                    DateStamp = dto.DateStamp.GetValueOrDefault(),
                    Amount = dto.InventoryAmount.GetValueOrDefault(),
                    TransActionName = dto.TransActionTypeNavigation.TransactionTypeName.Trim(),
                    EmployeeName = dto.Emp.firstname + " " + dto.Emp.lastname,
                    Unit = dto.UnitOfMeasure.UnitName

                }).ToList();

                return result;
            }
            else
                return null;
            

        }
       
        public void Dispose()
        {
           ;
        }

        public decimal GetStockLevel(int i)
        {
           return  _ctx.Inventory.AsNoTracking().Where(t => t.PartID== i).Sum(s => s.InventoryAmount.GetValueOrDefault());
        }

        public void SetStockLevel(int  partID, decimal  newValue)
        {
            var thePart = _ctx.Part.Find(partID);
            var currentValue = GetStockLevel(partID);
            var changeValue = newValue - currentValue;

            if (currentValue != decimal.MinValue)
            {
                Inventory adjustment = new Inventory();
                adjustment.PartID = partID;
                adjustment.InventoryAmount = changeValue;
                adjustment.DateStamp = DateTime.Now;
                adjustment.Description = thePart.ItemDescription;
                adjustment.LocationID = thePart.LocationID;
                adjustment.EmpID = 8;
                adjustment.JobID= 1;
                adjustment.UnitOfMeasureID = thePart.UnitOfMeasureID;
                adjustment.TransActionType = 4;

                _ctx.Inventory.Add(adjustment);
            }
            _ctx.SaveChanges();
        }

        public void RollUp(int partID)
        {
            var thePart = _ctx.Part.Find(partID);
            var currentValue = GetStockLevel(partID);
           
            if (currentValue != decimal.MinValue)
            {
                Inventory adjustment = new Inventory();
                adjustment.PartID = partID;
                adjustment.InventoryAmount = 0.0m;
                adjustment.DateStamp = DateTime.Now;
                adjustment.Description = "--[ROLLUP]--" + thePart.ItemDescription  ;
                adjustment.LocationID = thePart.LocationID;
                adjustment.EmpID = 8;
                adjustment.JobID = 1;
                adjustment.UnitOfMeasureID = thePart.UnitOfMeasureID;
                adjustment.TransActionType = 4;
                adjustment.Note = "<-- ROLLUP --->";

                _ctx.Inventory.Add(adjustment);
            }


            _ctx.SaveChanges();
        }

        public void RemoveTransactions(List<int> partIDs)
        {
            List<Inventory> removed = new List<Inventory>();

            foreach (var item in partIDs)
            {
                Inventory i = _ctx.Inventory.Find(item);
                removed.Add(i);
            }
            _ctx.RemoveRange(removed);
            _ctx.SaveChanges();

           
        }

        public IEnumerable<Location> GetLocations() 
        {
            return _ctx.Location.AsNoTracking().OrderBy(c => c.LocationName).ToList();
        }

        public IEnumerable<Location> GetAreaLocations(string area)
        {
            if (area!= string.Empty)
            {
                return _ctx.Location.AsNoTracking().Where(a => a.Area.Contains(area)).ToList();
            }
            else
            return Enumerable.Empty<Location>();
            
        }


        //Get Part in relation to the stock location
        public IEnumerable<PartsLocationDto> GetLocationParts(int locationID)
        {
           
                return  _ctx.Part.AsNoTracking().Include(m => m.Manu).Include(u => u.UnitOfMeasure).Where(p => p.LocationID==locationID).Select(dto => new PartsLocationDto
                {
                    Location = dto.Location,
                    ItemDescription = dto.ItemDescription,
                    PartID = dto.PartID,
                    Manufacturer = dto.Manu.Manufacturer,
                    Manupart = dto.PartNum,
                    UnitOfMeasure = dto.UnitOfMeasure.UnitName,
                    StockOnHand = _ctx.Inventory.AsNoTracking().Where(p => p.PartID == dto.PartID).Select(i => i.InventoryAmount).Sum().GetValueOrDefault()
                
                }).ToList();                   
          
        }

      

        public void UpdateLocationParts(IEnumerable<Inventory> locationParts, int user)
        {
           
            foreach (Inventory item in locationParts) 
            {
                //Fetch the related part for its value
                Part part = _ctx.Part.Find(item.PartID);
                Decimal existingStockLevel = GetStockLevel(item.PartID.GetValueOrDefault());
                if (item.InventoryAmount != existingStockLevel)
                {
                    Decimal reviseStockValue = item.InventoryAmount.GetValueOrDefault() - GetStockLevel(item.PartID.GetValueOrDefault());
                    
                    Inventory newInventoryItem = new Inventory();
                    newInventoryItem.PartID = part.PartID;
                    newInventoryItem.InventoryAmount = reviseStockValue;
                    newInventoryItem.Description= item.Description;
                    newInventoryItem.LocationID = item.LocationID;
                    newInventoryItem.UnitOfMeasureID = part.UnitOfMeasureID;                 
                    newInventoryItem.TransactionReferenceType= 4;//amend
                    newInventoryItem.EmpID = user;
                    newInventoryItem.DateStamp = item.DateStamp;
                    newInventoryItem.Note = item.Note;
                    _ctx.Inventory.Add(newInventoryItem);
                    
                }    
            }
            try
            {
                _ctx.SaveChanges();
            }
            catch (Exception)
            {Console.WriteLine("Error inserting Inventory item");}

               
            
            
        }
    }
}
