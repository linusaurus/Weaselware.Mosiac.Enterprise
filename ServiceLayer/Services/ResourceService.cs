using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using ServiceLayer.Overloads;
using System.ComponentModel;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ServiceLayer
{
    public class ResourceService : IDisposable
    {
        private  readonly MosaicContext _ctx;

        public ResourceService(MosaicContext context)
        {
            _ctx = context;
            
        }
       
        public List<ResourceDto> GetPartResources(int partID)
        {
           
            var result = _ctx.Resource.AsNoTracking().Where(p => p.PartID == partID).Select(d => new ResourceDto
            {
                ResourceID = d.ResourceID,
                ResourceDescription = d.ResourceDescription,
                PartID = d.PartID.GetValueOrDefault(),
                Filesize = d.FileSize,
                Filesource = d.filesource

            }).ToList();
            return result;
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            { // free managed resources
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
