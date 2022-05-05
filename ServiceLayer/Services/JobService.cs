using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Mappers;
using ServiceLayer.Models;


namespace ServiceLayer {

    public class JobsService : IDisposable {

        private  MosaicContext context;

        public JobsService(MosaicContext Context) {
            
            context = Context;
        }

        public bool Exist(int jobID) {

            bool result = false;
            if (context.Job.Any(c=> c.jobID == jobID))
            { result = true;}

            return result;
        }


        public PurchaseOrder GetJob(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.PurchaseOrderID == jobNumber).FirstOrDefault();
        }

   
        public List<PurchaseOrder> GetJobOrders(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.JobID == jobNumber).ToList();
        }

        /// <summary>
        /// TODO  refactor to use lightweight DTO return object
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public List<Job> GetJobs(string jobName) {

            return context.Job
                .Include(p => p.PurchaseOrder).ThenInclude(p => p.PurchaseLineItem)
                .Where(c => c.jobname.StartsWith(jobName)).OrderByDescending(t => t.start_ts).Take(25).ToList();
        }
       

        public void Save() {

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Job Find(int jobNumber) 
        {

            return context.Job.Include(p => p.PurchaseOrder).Where(c => c.jobID == jobNumber).FirstOrDefault();
        }

        public List<JobListDto> Recent()
        {
            var jobs = context.Job.AsNoTracking().OrderByDescending(p => p.jobID).Take(30)

                                  .Select(j => new JobListDto()
                                  {
                                      JobID = j.jobID,
                                      JobName = j.jobname
                                  }).ToList();


            return jobs;
        }

        public List<JobListDto> All()
        {
            var jobs = context.Job.AsNoTracking().OrderByDescending(p => p.jobID)
                                  
                                   .Select(j => new JobListDto()
                                   {
                                       JobID = j.jobID,
                                       JobName = j.jobname
                                   }).ToList();


            return jobs;

        }
    }
}
