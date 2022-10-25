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

        public async  Task<List<Inventory>>  GetPartTransactions(int partID)
        {


            var result = await _ctx.Inventory.AsNoTracking().Where(p => p.PartID == partID).ToListAsync();
            return result;
        }
       

        public void Dispose()
        {
           ;
        }
    }
}
