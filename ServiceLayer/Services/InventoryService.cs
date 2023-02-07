﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
            var result = _ctx.PickList.Include(l => l.pickListItems).Include(e => e.Employee).AsNoTracking().Where(p => p.PickListID == pickListID).Select(dto => new PickListDto
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

        public List<PartTransactionListDto> GetPartTransactions(int partID, int transActionfilterID = 0)
        {
            if (transActionfilterID == 0)
            {
                var result = _ctx.Inventory.Include(t => t.TransActionTypeNavigation).Include(e => e.Employee).Include(u => u.UnitOfMeasure).AsNoTracking().Where(p => p.PartID == partID).Select(dto => new PartTransactionListDto
                {
                    StockTransactionId = dto.StockTransactionID,
                    PartID = dto.PartID.GetValueOrDefault(),
                    Location = dto.Location,
                    DateStamp = dto.DateStamp.GetValueOrDefault(),
                    Amount = dto.InventoryAmount.GetValueOrDefault(),
                    TransActionName = dto.TransActionTypeNavigation.TransactionTypeName.Trim(),
                    EmployeeName = dto.Employee.firstname + " " + dto.Employee.lastname,
                    Unit = dto.UnitOfMeasure.UnitName

                }).ToList();
                 return result;
             
            }
            else
            {
                var result = _ctx.Inventory.Include(t => t.TransActionTypeNavigation).Include(e => e.Employee).Include(u => u.UnitOfMeasure).AsNoTracking().Where(p => p.PartID == partID).Where(f => f.TransActionType==transActionfilterID).Select(dto => new PartTransactionListDto
                {
                    StockTransactionId = dto.StockTransactionID,
                    PartID = dto.PartID.GetValueOrDefault(),
                    Location = dto.Location,
                    DateStamp = dto.DateStamp.GetValueOrDefault(),
                    Amount = dto.InventoryAmount.GetValueOrDefault(),
                    TransActionName = dto.TransActionTypeNavigation.TransactionTypeName.Trim(),
                    EmployeeName = String.Format("{0} {1}", dto.Employee.firstname,dto.Employee.lastname),
                    Unit= dto.UnitOfMeasure.UnitName

                }).ToList();
                return result;


            }
  
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
                adjustment.Location = thePart.Location;
                adjustment.EmpID = 8;
                adjustment.JobID= 1;
                adjustment.TransActionType = 4;
                _ctx.Inventory.Add(adjustment);
            }
            _ctx.SaveChanges();
        }

        public void RemoveTransactions(List<int> partIDs)
        {
            List<Inventory> removed = new List<Inventory>();

            foreach (var item in partIDs)
            {
                Inventory i = new Inventory() { StockTransactionID = item };
                removed.Add(i);
            }
            _ctx.RemoveRange(removed);
            _ctx.SaveChanges();
        }

        public IEnumerable<Location> GetLocations() 
        {
            return _ctx.Location.AsNoTracking().ToList();
        }
        //Get Part in relation to the stock location
        public IEnumerable<PartsLocationDto> GetLocationParts(string locationName)
        {
            return _ctx.Part.AsNoTracking().Include(m => m.Manu).Include(u => u.UnitOfMeasure).Where(p => p.Location.StartsWith(locationName)).Select(dto => new PartsLocationDto
            {
                Location = dto.Location,
                ItemDescription = dto.ItemDescription,
                PartID = dto.PartID,
                Manufacturer = dto.Manu.Manufacturer,
                Manupart = dto.PartNum,
                UnitOfMeasure = dto.UnitOfMeasure.UnitName,
                StockOnHand = _ctx.Inventory.AsNoTracking().Where(p => p.PartID==dto.PartID).Select(i => i.InventoryAmount).Sum().GetValueOrDefault()

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
                    newInventoryItem.Location = item.Location;
                    newInventoryItem.UnitOfMeasureID = part.UnitOfMeasureID;
                    newInventoryItem.QntyReceived = item.QntyReceived;
                    newInventoryItem.QntyOrdered = item.QntyOrdered;
                    newInventoryItem.TransActionType = 4;//amend
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
