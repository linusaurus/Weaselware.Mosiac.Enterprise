using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Models;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{

    
    public class DeliveryService
    {
        private readonly MosaicContext _ctx;

        public DeliveryService(MosaicContext context)
        {
            _ctx = context;
        }

        public List<MyDeliveriesListDto> GetMyDeliveries(int EmpID)
        {
            

                var result = _ctx.PickList.AsNoTracking().Include(j => j.Job).Include(e => e.Employee).Where(p => p.EmployeeID == EmpID).Select(d => new MyDeliveriesListDto
                {
                    DateStamp = d.DateStamp.GetValueOrDefault(),
                    JobName = d.Job.jobname,
                    Preparer = d.Employee.firstname,
                    Pid = d.PickListID

                }).ToList();
       

            return result;
        }

    }
}
