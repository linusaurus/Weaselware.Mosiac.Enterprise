using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Entity;
using DataLayer.Data;

namespace ServiceLayer
{
    public class SubAssemblyService
    {
        private readonly MosaicContext ctx;

        public List<SubAssembly> SubAssemblies;
        private Product parent;

        public SubAssemblyService(MosaicContext context)
        {
            ctx = context;
        }

        public Product Parent { get => parent; set => parent = value; }

        public SubAssemblyService()
        {
        }

        public List<SubAssembly> GetUnitSubAssemlblies(int productID)
        {
            return ctx.SubAssembly.Where(l => l.ProductID == productID).ToList();
        }
     
       
    }
}
