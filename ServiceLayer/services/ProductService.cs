using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;
using DataLayer.Data;
using ServiceLayer.Mappers;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public class ProductService
    {
        private readonly MosaicContext ctx;
        private readonly ProductMapper productMapper = new ProductMapper();

        public ProductService(MosaicContext context)
        {   ctx = context; }
         
       public List<Product> GetJobUnits(int jobID)
        {
            return ctx.Product.Include(p => p.SubAssemblies).Where(j => j.JobID == jobID).ToList();
        }

       public List<JobOrdersList> JobOrders(int jobID)
       {
                return  ctx.PurchaseOrder.Where(j => j.JobID==jobID).Select(p => new JobOrdersList
                {
                    PurchaseOrderID = p.PurchaseOrderID,
                    OrderDate = p.OrderDate.GetValueOrDefault().ToShortDateString(),
                    SupplierName = p.Supplier.SupplierName

                }).ToList();
           
        }

        public List<ProductDto> GetProducts(int jobID)
        {
            var product = ctx.Product.Include(r => r.SubAssemblies).Where(p => p.JobID == jobID).Select(d => new ProductDto
            {
                ProductID = d.ProductID,
                ProductionDate = d.ProductionDate.GetValueOrDefault(),
                ArchDescription = d.ArchDescription,
                JobID = d.JobID.GetValueOrDefault(),
                UnitID = d.UnitID.GetValueOrDefault(),
                UnitName = d.UnitName,
                RoomName = d.RoomName,
                W = d.W.GetValueOrDefault(),
                D = d.D.GetValueOrDefault(),
                H = d.H.GetValueOrDefault(),
                Delivered = d.Delivered.GetValueOrDefault(),
                DeliveryDate = d.DeliveredDate.GetValueOrDefault(),
                Make = d.Make.GetValueOrDefault(),
                NIC = d.NIC.GetValueOrDefault(),
 
            }).ToList() ;

            return product;
        }

        public Product AddUnit(Product unit)
        {           
            ctx.Add(unit);
            ctx.SaveChanges();        
            return unit;
        }


        public void AddOrUpdate(JobListDto jobListDto)
        {
            if (jobListDto != null )
            {
                
             var productList = ctx.Product.Include(s => s.SubAssemblies).Where(o => o.JobID == jobListDto.JobID).ToList();

            //remove deleted products -
            productList
                .Where(d => !jobListDto.Products.Any(dto => dto.ProductID == d.ProductID || dto.ProductID == default)).ToList()
                .ForEach(deleted => ctx.Product.Remove(deleted));

            jobListDto.Products.ToList().ForEach(ad =>
            {
                var product = ctx.Product.Include(s => s.SubAssemblies).FirstOrDefault(r => r.ProductID == ad.ProductID);
                if (product == null || product.ProductID == default)
                {
                    product = new Product();
                    ctx.Product.Add(product);
                }

                product.JobID = ad.JobID;
                product.ArchDescription = ad.ArchDescription;
                product.UnitID = ad.UnitID;
                product.UnitName = ad.UnitName;
                product.RoomName = ad.RoomName;
                product.ProductionDate = ad.ProductionDate;
                product.W = ad.W.GetValueOrDefault();
                product.H = ad.H.GetValueOrDefault();
                product.D = ad.D.GetValueOrDefault();
                product.Delivered = ad.Delivered.GetValueOrDefault();
                product.DeliveredDate = ad.DeliveryDate;
                product.Make = ad.Make;
                product.NIC = ad.NIC;

                //remove deleted subassemblies -
                product.SubAssemblies
                    .Where(d => !ad.SubAssemblies.Any(SubAssemblyDTO => SubAssemblyDTO.SubAssemblyID == d.SubAssemblyID)).ToList()
                    .ForEach(deleted => ctx.SubAssembly.Remove(deleted));

                if (ad.SubAssemblies != null )
                {
                    //update or add SubAssembly --
                    ad.SubAssemblies.ToList().ForEach(od =>
                    {
                        var subassembly = product.SubAssemblies.FirstOrDefault(r => r.SubAssemblyID == od.SubAssemblyID);
                        if (subassembly == null || subassembly.SubAssemblyID == default)
                        {
                            subassembly = new SubAssembly();
                            product.SubAssemblies.Add(subassembly);
                        }
                        subassembly.ProductID = od.ProductID;
                        subassembly.SubAssemblyName = od.SubAssemblyName;
                        subassembly.MakeFile = od.MakeFile;
                        subassembly.W = od.W;
                        subassembly.H = od.H;
                        subassembly.D = od.D;
                        subassembly.GlassPartID = od.GlassPartID;
                        subassembly.CPD_id = od.CPD_ID;
                    });
                }
               

            });
               
                ctx.SaveChanges();
            }
            

           
            
        }
       
    }
}
