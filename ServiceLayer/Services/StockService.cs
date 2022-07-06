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
            var source = _ctx.PickList.AsNoTracking().Include(l => l.pickListItems).Include(j => j.Job).Include(e => e.Employee).Where(p => p.PickListID == pid).FirstOrDefault();
            pickListMapper.Map(source, dto);
            return dto;
           
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
        // PointOfUse inventory reduction using partnumber or StockTag
        public async void PullPart(string partid, decimal qnty, int jobid)
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
                inventory.Location = part.Location;
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
                 //----------------------------------------
                 PickListDto newDto = new PickListDto();
                 pickListMapper.Map(pickList, dto);
                 //----------------------------------------
                 return dto;

            }

        


    }
}
