using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.Runtime.InteropServices.ComTypes;

namespace ServiceLayer {

    public class OrdersService : IDisposable {

        private readonly MosaicContext context;
        PartsService _partService;

        public OrdersService(MosaicContext Context) {
            
            context = Context;
            _partService = new PartsService(context);
        }

        public OrderDetailDto GetOrderDTO(int orderID)
        {
            var _order = context.PurchaseOrders.Include(r => r.PurchaseLineItems).Include(s => s.Supplier).Where(p => p.PurchaseOrderID == orderID).Select(d => new OrderDetailDto
            {
                PurchaseOrderID = d.PurchaseOrderID,
                OrderDate = d.OrderDate.Value.ToShortDateString(),
                OrderTotal = d.OrderTotal.Value,
                ExpectedDate = d.ExpectedDate.Value,
                JobCostName = d.Job.jobdesc,
                JobName = d.Job.jobname,
                JobID = d.JobID.Value,
                Purchaser = d.Employee.firstname + " " + d.Employee.lastname,
                ShippingCost = d.ShippingCost.HasValue ? d.ShippingCost.Value : Decimal.Zero,
                SubTotal = d.SubTotal.HasValue ? d.SubTotal.Value : Decimal.Zero,
                ShipID = d.ShipID.GetValueOrDefault(),
                SupplierAddress = d.Supplier.Address1,
                SupplierCity = d.Supplier.City,
                SupplierName = d.Supplier.SupplierName,
                SupplierState = d.Supplier.State,
                SupplierID = d.SupplierID.HasValue ? d.SupplierID.Value : 0,
                SupplierPhone = d.Supplier.Phone,
                SupplierZip = d.Supplier.Zip,
                SupplierFax = d.Supplier.Fax,
                Tax = d.Tax.HasValue ? d.Tax.Value : Decimal.Zero,
                TaxRate = d.TaxRate.GetValueOrDefault(),
                Taxable = d.SuppressTax.HasValue ? d.SuppressTax.Value : false,
                //LineItems = d.PurchaseLineItem

            }); 
            return _order.FirstOrDefault();
        }

        public List<LineItemDto> GetLineItems(int orderID)
        {
            var _lineItems = context.PurchaseLineItems.Where(f => f.PurchaseOrderID == orderID).Select(d => new LineItemDto
            {
                Description = d.Description,
                LineID = d.LineID,
                Quantity = d.Qnty.Value,
                Price = d.UnitCost.Value,
                Extended = d.Extended.Value,
                PartID = d.PartID.GetValueOrDefault(),
                PurchaseOrderID = d.PurchaseOrderID.GetValueOrDefault(),
            });
            return _lineItems.ToList();
        }

        public void SaveOrder(OrderDetailDto order)
        {

        }

        public bool Exist(int orderID) {

            bool result = false;
            if (context.PurchaseOrders.Any(c=> c.PurchaseOrderID == orderID))
            {result = true; }
   
            return result;
        }

        public BindingList<PurchaseLineItem> OrderLineItems(int purchaseOrderID)
        {
            BindingList<PurchaseLineItem> result =
                    new BindingList<PurchaseLineItem>(context.PurchaseLineItems.Where(w => w.PurchaseOrderID == purchaseOrderID).ToList());
            return  result;           
        }

        public double GetSupplierTaxRate(int zipcode)
        {
           
            return double.Parse("0.0775");
        }
       
        // TODO This is the problem 
  
        public PurchaseOrder GetOrderByID(int orderNum) {

            using (var ctx = new MosaicContext())
            {
                var order = ctx.PurchaseOrders
                 .Include(p => p.PurchaseLineItems)
                 .Include(j => j.Job)
                 .Include(s => s.Supplier)
                 .Include(t => t.Attachments)
                 .Include(p => p.OrderFees)
                 .Include(e => e.Employee).Where(c => c.PurchaseOrderID == orderNum).FirstOrDefault();

                return order;
            }


        }

        public List<PurchaseOrder> GetAllOrders() {

            return context.PurchaseOrders.ToList();
        }

        public List<PurchaseOrder> GetSupplierOrders(int supplierID)
        {

            return context.PurchaseOrders.Where(c => c.SupplierID == supplierID).OrderByDescending(d => d.OrderDate).ToList();
        }

        public List<SupplierOrdersListDto> GetSupplierOrdersList(int supplierID)
        {
            
            var result = context.PurchaseOrders.Where(s => s.SupplierID == supplierID).Select(d => new SupplierOrdersListDto
            {
                OrderDate = d.OrderDate.GetValueOrDefault(),
                OrderNumber = d.PurchaseOrderID,
                Purchaser = d.Employee.firstname,
                Received = d.Recieved.GetValueOrDefault()

            }).ToList();
            return result;
        }

        public List<PurchaseOrder> GetJobOrders(int jobID)
        {

            return context.PurchaseOrders.Where(c => c.JobID == jobID).ToList();
        }

        public void InsertOrUpdate(PurchaseOrder order) {

            if (order.PurchaseOrderID == default(int))
            {
                context.Entry(order).State = EntityState.Added ;
                context.PurchaseOrders.Add(order);
            }
            else
            {
                context.PurchaseOrders.Attach(order);
            }
        }

        public PurchaseOrder NewDefault(int employee, int supplierId, int jobID) {

            PurchaseOrder po = new PurchaseOrder();
            po.EmployeeID = employee;
            po.SupplierID = supplierId;
            po.DateAdded = DateTime.Today;
            po.OrderDate = DateTime.Today;
            po.ExpectedDate = DateTime.Today;
            po.IsBackOrder = false;
            po.JobID = jobID;
            po.Memo = " ";
            po.OrderState = 0;
            po.OrderTotal = 0.00m;
            po.SalesRep = "";
            po.ShipID = 1;
            po.ShippingCost = 0.00m;
            po.SuppressTax = false;
            po.SubTotal = 0.00m;
            po.Recieved = false;
            po.Tax = 0.00m;
            po.OrderFormat = "Standard";
            po.AddedBy = context.Employees.Find(employee).firstname + " " + context.Employees.Find(employee).lastname;
            po.OrderState = 1;
            return po;
        }

        public void Delete(int orderID) {

            PurchaseOrder po = context.PurchaseOrders.Where(c => c.PurchaseOrderID == orderID).FirstOrDefault();
            context.Entry(po).State = EntityState.Deleted;
            context.PurchaseOrders.Remove(po);

        }
        //Recieve Order --
        public OrderReciept RecievedOrder(PurchaseOrder order, int employeeID) {

            // Build and save OrderReceipt --
            OrderReciept oreciept = new OrderReciept();
            oreciept.PurchaseOrderID = order.PurchaseOrderID;
            oreciept.EmployeeID = employeeID;
            oreciept.ReceiptDate = DateTime.Now;
            context.OrderReciepts.Add(oreciept);
            context.SaveChanges();
            List<ClaimItem> claimItems = new List<ClaimItem>();

            foreach (PurchaseLineItem item in order.PurchaseLineItems)
            {

                Inventory inv = new Inventory();
                inv.DateStamp = DateTime.Now;
                inv.Description = item.Description.ToString().TrimEnd();
                inv.JobID = order.JobID;
                inv.LineID = item.LineID;
                inv.Location = string.Empty;
                inv.OrderReceiptID = oreciept.OrderReceiptID;
                inv.UnitOfMeasureID = item.UnitOfMeasureID ?? 1;
                inv.QntyOrdered = item.Qnty ?? 0;      
                item.Recieved = true;
                item.OrderReceiptID = oreciept.OrderReceiptID;
                inv.PartID = item.PartID ?? null;
                if (!(item.Description.Length == 0) && !(item.Qnty == default(decimal)) )
                {
                    context.Entry(inv).State = EntityState.Added;
                    context.Inventories.Add(inv);
                    context.Entry(item).State = EntityState.Modified;
    
                }
               
               
            }
            order.Recieved = true;
            order.RecievedDate = DateTime.Today;
           

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                string err = ex.InnerException.ToString();
                Console.Write(err);
                throw;
            }
            return oreciept;
        
        }

        public void Save() {

            context.SaveChanges();
        }

        public void Dispose() {

            context.Dispose();
        }

        public List<SupplierOrderDTO> GetSupplierOrdersDTO(int SupplierID)
        {
            List<SupplierOrderDTO> result = new List<SupplierOrderDTO>();
            SupplierOrderDTO dto;

            using (MosaicContext ctx = new MosaicContext())
            {
            // Get all the Suppliers Orders --
            var pOrders = ctx.PurchaseOrders.Where(p => p.SupplierID == SupplierID).ToList();

                foreach (var P in pOrders)
                {
                dto = new SupplierOrderDTO();
                dto.PurchaserName = P.Employee.lastname;
                    if(P.Job != null)
                    { dto.JobName = P.Job.jobname; }
               
                dto.OrderDate = P.OrderDate;
                dto.OrderNum = P.PurchaseOrderID;
                dto.Received = P.Recieved;
                dto.SupplierName = P.Supplier.SupplierName;
                dto.ReceiveStatus = "none";
                result.Add(dto);

                }
             }
            
            return result;           
        }

        public List<SupplierLineItemDto> GetSupplierLineItems(int supplierID)
        {
            string id = supplierID.ToString();
            
            string sql = @"select Description,PartID,LineID,Qnty,UnitCost,PurchaseOrderID FROM PurchaseLineItem " +
                          " WHERE OrderReceiptID IN(SELECT OrderReceiptID FROM OrderReciept WHERE OrderNum IN " +
                          "(SELECT OrderNum FROM PurchaseOrder WHERE SupplierID = {0}))";

            ///TODO pass a parameter to the sql
            var result = context.PurchaseLineItems.FromSqlRaw(sql, id).Select(d => new SupplierLineItemDto
            {
                Description = d.Description,
                LineID = d.LineID,
                PartID = d.PartID.GetValueOrDefault(),
                UnitCost = d.UnitCost.GetValueOrDefault(),
                OrderNum = d.PurchaseOrderID.GetValueOrDefault()
            })
                .ToList();
            return result;
        }

        public List<UnitOfMeasure> GetUnits()
        {
          return context.UnitOfMeasures.AsNoTracking().ToList() ;
        }
        /// <summary>
        /// TODO this need to be much more expanded and use a composite Order DTO
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public PurchaseOrder Add(PurchaseOrder order)
        {
            context.PurchaseOrders.Add(order);
            context.SaveChanges();
            return order;
        }

        public void CreateOrUpdateOrder(OrderDetailDto orderDTO)
        {
           var ctx = context;
           var order = ctx.PurchaseOrders.Include(p => p.PurchaseLineItems).FirstOrDefault(o => o.PurchaseOrderID == orderDTO.PurchaseOrderID);
            if (order == null)
            {
                order = new PurchaseOrder();
                ctx.PurchaseOrders.Add(order);
            }

            //Map properties
            order.OrderDate = DateTime.Parse(orderDTO.OrderDate);
            order.OrderTotal = orderDTO.OrderTotal;
            order.ExpectedDate = orderDTO.ExpectedDate;
            order.JobID = orderDTO.JobID;
            order.Memo = orderDTO.Memo;
           
            order.SalesRep = orderDTO.SalesRep;
            order.EmployeeID = orderDTO.EmployeeID;
            order.PurchaseOrderID = orderDTO.PurchaseOrderID;
            order.ShipID = orderDTO.ShipID;
            order.ShippingCost = orderDTO.ShippingCost;
            order.SubTotal = orderDTO.SubTotal;
            order.SupplierID = orderDTO.SupplierID;
            order.SuppressTax = orderDTO.Taxable;
            
            order.Tax = orderDTO.Tax;
            order.TaxRate = orderDTO.TaxRate;

            //remove deleted details -
            order.PurchaseLineItems
            .Where(d => !orderDTO.LineItems.Any(LineItemDto => LineItemDto.LineID == d.LineID)).ToList()
            .ForEach(deleted => ctx.PurchaseLineItems.Remove(deleted));

            //update or add details
            orderDTO.LineItems.ToList().ForEach(detailDTO =>
            {
                var detail = order.PurchaseLineItems.FirstOrDefault(d => d.LineID == detailDTO.LineID);
                if (detail == null || detail.LineID == 0)
                {
                    detail = new PurchaseLineItem();
                    order.PurchaseLineItems.Add(detail);
                }
                detail.JobID = detailDTO.JobID;
                detail.Qnty = detailDTO.Quantity;
                detail.Description = detailDTO.Description;
                detail.PurchaseOrderID = detailDTO.PurchaseOrderID;
                detail.PartID = detailDTO.PartID;
                detail.UnitCost = detailDTO.Price;
                detail.UnitOfMeasureID = detailDTO.UiD;
                detail.Extended = detailDTO.Extended;

            });

            //remove deleted orderfees -
            order.OrderFees
                .Where(d => !orderDTO.OrderFees.Any(OrderFeeDto => OrderFeeDto.OrderFeeID == d.OrderfeeID)).ToList()
                .ForEach(deleted => ctx.OrderFees.Remove(deleted));

            //update or add OrderFees
            orderDTO.OrderFees.ToList().ForEach(od =>
            {
                var orderfee = order.OrderFees.FirstOrDefault(r => r.OrderfeeID == od.OrderFeeID);
                if (orderfee == null || orderfee.OrderfeeID == 0)
                {
                    orderfee = new OrderFee();
                    order.OrderFees.Add(orderfee);
                }
                orderfee.PurchaseOrderID = order.PurchaseOrderID;
                orderfee.FeeName = od.FeeName;
                orderfee.Cost = od.Cost;
                orderfee.Extension = od.Extension;
                orderfee.Qnty = od.Qnty;
            });

            //remove deleted attachments -
            ///TODO  attachment loading is slow and delete only duplicates
            order.Attachments
                .Where(a => !orderDTO.Attachments.Any(attachDTO => attachDTO.AttachmentID == a.AttachmentID)).ToList()
                .ForEach(deleted => ctx.Attachments.Remove(deleted));

            //update or add Attachments
            orderDTO.Attachments.ToList().ForEach(ad =>
            {
                var attachmnt = order.Attachments.FirstOrDefault(r => r.AttachmentID == ad.AttachmentID);
                if (attachmnt ==null || attachmnt.AttachmentID == 0)
                {
                    attachmnt = new Attachment();
                    order.Attachments.Add(attachmnt);
                }

                attachmnt.OrderNum = ad.OrderNum;
                // how to determine if the filesource is empty but existing
                if (ad.FileSource != null)
                {
                    attachmnt.Filesource = ad.FileSource;
                }
                //attachmnt.Filesource  = ad.FileSource; 
                attachmnt.AttachmentDescription = ad.AttachmentDescription;
                attachmnt.Ext = ad.Ext;
                attachmnt.src = ad.Src;
                attachmnt.FileSize = ad.FileSize;
                attachmnt.Creator = ad.Creator;
                attachmnt.CreateDate = ad.CreatedDate;
            });

            context.SaveChanges();
        }

        public List<OrderListDto> FindSupplierOrders(int supplierID)
        {
            return context.PurchaseOrders
                .Include(j => j.Job)
                .Include(e => e.Employee)
                .Include(s => s.Supplier).OrderByDescending(r => r.OrderDate).Where(c => c.SupplierID == supplierID).AsNoTracking().Select(d => new OrderListDto
            {
                PurchaseOrderID = d.PurchaseOrderID,
                JobName = d.Job.jobname,
                Purchaser = d.Employee.firstname,
                OrderDate = d.OrderDate.GetValueOrDefault(),
                OrderTotal = d.OrderTotal.GetValueOrDefault(),
                Recieved = d.Recieved.GetValueOrDefault(),
                Supplier = d.Supplier.SupplierName
                

            }).ToList();

                
                
                
            
        }

        public List<OrderListDto> GetMyOrders(int employeeID,bool ShowRecieved)
        {

            if (ShowRecieved == true)
            {


                return context.PurchaseOrders
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeID == employeeID).Where(r => r.Recieved == true).OrderByDescending(r => r.OrderDate)
                   .AsNoTracking().Select(d => new OrderListDto
                   {
                       PurchaseOrderID = d.PurchaseOrderID,
                       JobName = d.Job.jobname,
                       Purchaser = d.Employee.firstname,
                       OrderDate = d.OrderDate.GetValueOrDefault(),
                       OrderTotal = d.OrderTotal.GetValueOrDefault(),
                       Recieved = d.Recieved.GetValueOrDefault(),
                       Supplier = d.Supplier.SupplierName

                   }).ToList();

            }
            else
            {
                return context.PurchaseOrders
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeID == employeeID).Where(r => r.Recieved == false).OrderByDescending(r => r.OrderDate)
                   .AsNoTracking().Select(d => new OrderListDto
                   {
                       PurchaseOrderID = d.PurchaseOrderID,
                       JobName = d.Job.jobname,
                       Purchaser = d.Employee.firstname,
                       OrderDate = d.OrderDate.GetValueOrDefault(),
                       OrderTotal = d.OrderTotal.GetValueOrDefault(),
                       Recieved = d.Recieved.GetValueOrDefault(),
                       Supplier = d.Supplier.SupplierName

                   }).ToList();
            }
        }
    }
}
