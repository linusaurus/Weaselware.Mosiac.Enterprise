using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using Dapper;
using SkiaSharp;
using System.Threading;
using System.Security.Cryptography;

namespace ServiceLayer
{
    public class StockService
    {
        private readonly MosaicContext _ctx;
        private PickListMapper pickListMapper;
        private PartsService partService;
        public StockService(MosaicContext ctx)
        {
            _ctx = ctx; 
            pickListMapper = new PickListMapper();
            partService = new PartsService(_ctx);
        }

        public PickListDto GetPicklist(int pid)
        {
            PickListDto dto = new PickListDto();
            var source = _ctx.PickList.AsNoTracking().Include(l => l.pickListItems).Include(d => d.Destination).Include(j => j.Job).Include(e => e.Employee).Where(p => p.PickListID == pid).FirstOrDefault();
            pickListMapper.Map(source, dto);
            return dto;         
        }

        public async Task<List<Destination>> GetDestinationsAsync(string term)
        {
            var result = await _ctx.Destination.AsNoTracking().Where(d => d.DestinationName.Contains(term)).ToListAsync();
            return result;
        }

        public async Task<List<Destination>> GetAllDestinationsAsync()
        {
            var result = await _ctx.Destination.AsNoTracking().OrderBy(d => d.DestinationName).ToListAsync();
            return result;
        }

        public List<PickListDto> JobPicks(int jobID)
        {
            var result = _ctx.PickList.AsNoTracking().Include(j => j.Job).Where(f => f.JobID == jobID).Select(p => new PickListDto()
            {
                PickListID = p.PickListID,
                DateStamp = p.DateStamp.GetValueOrDefault(),
                Preparer = p.Employee.firstname,
                EmployeeID = p.EmployeeID.GetValueOrDefault(),
                Delivered = p.Delivered.GetValueOrDefault(),
                DeliveryDate = p.DeliveryDate.GetValueOrDefault(),
                JobID = p.JobID.GetValueOrDefault(),
                ItemCount = p.ItemCount.GetValueOrDefault(),
                JobName = p.Job.jobname,
                Submitted = p.Submitted.GetValueOrDefault()
                

            }).ToList();

            return result;
        }
        // Return a complete but untracked list of Entity objects
        public List<PickListDto> GetJobPicks(int jobID)
        {
            var result = _ctx.PickList.AsNoTracking().Include(i => i.pickListItems).Include(d => d.Destination).Include(j => j.Job)
                .Include(e => e.Employee).Where(f => f.JobID == jobID).ToList();

            List<PickListDto> resultList = new List<PickListDto>();

            foreach (var pick in result)
            {
                PickListDto dto = new PickListDto();
                pickListMapper.Map(pick,dto);
                resultList.Add(dto);
            }
 
            return resultList;
        }

        // PointOfUse inventory reduction using partnumber or StockTag
        public async void PullPart(string partid, decimal qnty,int empID,int jobid)
        {
            Part part = partService.FindbyID(partid);


            if (part != null)
            {
                Inventory inventory = new Inventory();
                inventory.PartID = part.PartID;
                inventory.UnitOfMeasureID = part.UnitOfMeasureID.GetValueOrDefault();
                inventory.Description = part.ItemDescription;
                inventory.InventoryAmount = qnty * -1.0m;
                inventory.JobID = jobid;
                inventory.EmpID = empID;
                inventory.Location = part.Location;
                inventory.TransActionType = 3;
                _ctx.Inventory.Add(inventory);
                await _ctx.SaveChangesAsync();
            }
        }

        public async void SetPartStockLevel(int partid, decimal desiredStockLevel)
        {
            Part part = partService.FindbyID(partid.ToString());
            decimal adjustment = decimal.Zero;

            if (part != null)
            {
                decimal stockNow = _ctx.Inventory.AsNoTracking().Where(r => r.PartID == partid).Sum(i => i.InventoryAmount).GetValueOrDefault();
                if (stockNow > desiredStockLevel)
                {
                    adjustment = stockNow - desiredStockLevel;
                }
              
                Inventory inventory = new Inventory();
                inventory.PartID = part.PartID;
                inventory.UnitOfMeasureID = part.UnitOfMeasureID.GetValueOrDefault();
                inventory.Description = part.ItemDescription;
                inventory.InventoryAmount = desiredStockLevel * -1.0m;
                inventory.Location = part.Location;
                _ctx.Inventory.Add(inventory);
                await _ctx.SaveChangesAsync();
            }
        }

        public async void PartRollup(int partid, int UserID) 
        {
            Part part = partService.FindbyID(partid.ToString());
            if (part == null) { return; }
            var stockTransactions = _ctx.Inventory.Where(c => c.PartID == partid);
            if (stockTransactions.Any()) 
            {
                _ctx.RemoveRange(stockTransactions);
                
            }

            Inventory inventory = new Inventory();
            inventory.PartID = part.PartID;
            inventory.UnitOfMeasureID = part.UnitOfMeasureID.GetValueOrDefault();
            inventory.Description = part.ItemDescription;
            inventory.InventoryAmount = 0.0m;
            inventory.TransActionType = 4;
            inventory.Location = part.Location;
            inventory.EmpID = UserID;
            inventory.Note = "Rolled-Up";
            _ctx.Inventory.Add(inventory);

            await _ctx.SaveChangesAsync();
        
        }



        public async Task<PickListDto> CreateOrUpdate(PickListDto dto)
        {
              
                var pickList = await _ctx.PickList.Include(p => p.pickListItems).Include(e => e.Employee).Where(w => w.PickListID == dto.PickListID).FirstOrDefaultAsync();
                // var pickList = await _ctx.PickList.Include(p => p.pickListItems).Include(e => e.Employee).FirstOrDefaultAsync(o => o.PickListID == dto.PickListID);
                 if (pickList == null)
                {
                    pickList = new PickList();
                    pickList.DateStamp = DateTime.Now;
                    _ctx.PickList.Add(pickList);
                    _ctx.SaveChanges();
                }

                //Map properties
                pickList.DateStamp = DateTime.Parse(dto.DateStamp.ToShortDateString());
                pickList.EmployeeID = dto.EmployeeID;
               // pickList.Employee = _ctx.Employee.AsNoTracking().Where(e => e.employeeID == dto.EmployeeID).FirstOrDefault();
                pickList.ItemCount = dto.ItemCount;
                pickList.JobID = dto.JobID;
                pickList.Delivered = dto.Delivered;
                pickList.DeliveryDate = dto.DeliveryDate;
                pickList.Submitted = dto.Submitted;
                //pickList.DestinationID = dto.DestinationID;
                pickList.Destination = _ctx.Destination.Find(dto.DestinationID);
               
       
            //remove deleted details -
            pickList.pickListItems
                .Where(d => !dto.PickListItems.Any(dto => dto.PickListItemID == d.PickListItemID)).ToList()
                .ForEach(deleted => _ctx.PickListItem.Remove(deleted));

                //update or add details
                dto.PickListItems.ToList().ForEach(ItemDto =>
                {
                    var detail = pickList.pickListItems.FirstOrDefault(d => d.PickListItemID == ItemDto.PickListItemID);
                    if (detail == null || detail.PickListItemID == 0)
                    {
                        detail = new PickListItem();

                        pickList.pickListItems.Add(detail);
                        _ctx.PickListItem.Add(detail);
                    }

                    detail.PickListID = pickList.PickListID;
                    
                    detail.Qnty = ItemDto.Qnty.GetValueOrDefault();
                    detail.Description = ItemDto.Description;
                    detail.Delivered = ItemDto.Delivered;
                    detail.PartID = ItemDto.PartID.GetValueOrDefault();
                    detail.ProductID = ItemDto.ProductID.GetValueOrDefault();
                    detail.Onboard = ItemDto.Onboard.GetValueOrDefault();    

                });

               
                 await _ctx.SaveChangesAsync();
                 //----------------------------------------**
                 PickListDto newDto = new PickListDto();
                 pickListMapper.Map(pickList, newDto);
                 //----------------------------------------**
                 return newDto;

            }


        public async Task<List<LineItemSearchDto>> SearchLineItemAsync(string search,  string[] parms)
        {

            var query = _ctx.PurchaseLineItem.Include(m => m.PurchaseOrder).ThenInclude(s => s.Supplier).Select(f => f);

            query = query.AsNoTracking().Where(p => p.Description.Contains(search));

 
            if (parms[0].ToString() != "")
            {
                query = query.Where(f => f.Description.Contains(parms[0].ToString()));
            }
            if (parms[1].ToString() != "")
            {
                query = query.Where(f => f.Description.Contains(parms[1].ToString()));
            }

            var result = query.Select(d => new LineItemSearchDto
            {
                Description = d.Description,
                PartID = d.PartID.GetValueOrDefault(),
                SupplierName = d.PurchaseOrder.Supplier.SupplierName,
                JobName = d.PurchaseOrder.Job.jobname,
                LineID= d.LineID,
                Quantity = d.Qnty.GetValueOrDefault(),
                PurchaseOrderID = d.PurchaseOrderID.GetValueOrDefault(),
                OrderDate = d.PurchaseOrder.OrderDate.GetValueOrDefault()

            });

            return await result.ToListAsync();

        }

        public List<JobListItem> GetJobParts(int jobID)
        {
            var dynamicParameter = new DynamicParameters();

            dynamicParameter.Add("jobID", jobID);

            string sql = @"select pl.LineID, pl.PurchaseOrderID, pl.Qnty, pl.[Description],pl.Extended , s.SupplierName FROM PurchaseLineItem pl " +
                         "JOIN Supplier s ON pl.SupplierID = s.SupplierID " +
                         "where PurchaseOrderID IN(Select PurchaseOrderID where JobID = @jobID)";

            var conn = _ctx.Database.GetDbConnection();
            return conn.Query<JobListItem>(sql,dynamicParameter).ToList();
        }

        public List<JobListItem> GetJobParts(int jobID, string searchTerm)
        {
            var dynamicParameter = new DynamicParameters();

            searchTerm = "%" + searchTerm + "%";

            dynamicParameter.Add("jobID", jobID);
            dynamicParameter.Add("str", searchTerm);

            string sql = @"select pl.LineID, pl.PurchaseOrderID, pl.Qnty, pl.[Description],pl.Extended , s.SupplierName FROM PurchaseLineItem pl " +
                         "JOIN Supplier s ON pl.SupplierID = s.SupplierID " +
                         "where PurchaseOrderID IN(Select PurchaseOrderID where JobID = @jobID) " +
                         "and pl.Description LIKE @str";

            var conn = _ctx.Database.GetDbConnection();
            return conn.Query<JobListItem>(sql, dynamicParameter).ToList();
        }


    }
}
