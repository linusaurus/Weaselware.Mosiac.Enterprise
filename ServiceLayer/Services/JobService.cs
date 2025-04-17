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

    public class JobsService : IDisposable
    {
        private readonly MosaicContext _context; // Fixed IDE1006: Added '_' prefix and IDE0044: Made field readonly

        public JobsService(MosaicContext context)
        {
            _context = context;
        }

        public bool Exist(int jobID)
        {
            bool result = false;
            if (_context.Job.Any(c => c.jobID == jobID))
            {
                result = true;
            }

            return result;
        }

        public async Task<List<JobListDto>> Search(string term)
        {
            var jobs = await _context.Job.AsNoTracking().Where(p => p.jobname.Contains(term))
                                    .Select(j => new JobListDto()
                                    {
                                        JobID = j.jobID,
                                        JobName = j.jobname
                                    }).ToListAsync();

            return jobs;
        }

        public PurchaseOrder? GetJob(int jobNumber)
        {
            return _context.PurchaseOrder.Where(c => c.PurchaseOrderID == jobNumber).FirstOrDefault();
        }

        public List<PurchaseOrder> GetJobOrders(int jobNumber)
        {
            return _context.PurchaseOrder.Where(c => c.JobID == jobNumber).ToList();
        }

        public List<Job> GetJobs(string jobName)
        {
            return _context.Job
                .Include(p => p.PurchaseOrder).ThenInclude(p => p.PurchaseLineItem)
                .Where(c => c.jobname.StartsWith(jobName)).OrderByDescending(t => t.start_ts).Take(25).ToList();
        }

        public List<Job> GetAllJobs()
        {
            return _context.Job.AsNoTracking()
                .Include(p => p.PurchaseOrder).ThenInclude(p => p.PurchaseLineItem).OrderByDescending(t => t.start_ts).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Job? Find(int jobNumber)
        {
            return _context.Job.Include(p => p.PurchaseOrder).Where(c => c.jobID == jobNumber).FirstOrDefault();
        }

        public async Task<Job?> FindAsync(int jobNumber)
        {
            return await _context.Job.Include(p => p.PurchaseOrder).Where(c => c.jobID == jobNumber).FirstOrDefaultAsync();
        }

        public List<JobListDto> Recent()
        {
            var jobs = _context.Job.AsNoTracking().OrderByDescending(p => p.jobID).Take(30)

                                  .Select(j => new JobListDto()
                                  {
                                      JobID = j.jobID,
                                      JobName = j.jobname
                                  }).ToList();

            return jobs;
        }

        public List<JobListDto> All()
        {
            var jobs = _context.Job.AsNoTracking().OrderByDescending(p => p.jobID)

                                  .Select(j => new JobListDto()
                                  {
                                      JobID = j.jobID,
                                      JobName = j.jobname
                                  }).ToList();

            return jobs;
        }
    }
}
