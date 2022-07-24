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
            var _order = context.PurchaseOrder.Include(r => r.PurchaseLineItem).Include(s => s.Supplier).Where(p => p.PurchaseOrderID == orderID).Select(d => new OrderDetailDto
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
                OrderState = d.OrderState.GetValueOrDefault()
                

            }); 
            return _order.FirstOrDefault();
        }

        public List<LineItemDto> GetLineItems(int orderID)
        {
            var _lineItems = context.PurchaseLineItem.Where(f => f.PurchaseOrderID == orderID).Select(d => new LineItemDto
            {
                Description = d.Description,
                LineID = d.LineID,
                JobID = d.JobID.GetValueOrDefault(),
                Quantity = d.Qnty.Value,
                Price = d.UnitCost.Value,
                Extended = d.Extended.Value,
                PartID = d.PartID.GetValueOrDefault(),
                UnitOrderMeasureName = d.UnitOfMeasure.UnitName,
                PurchaseOrderID = d.PurchaseOrderID.GetValueOrDefault(),
            });
            return _lineItems.ToList();
        }

        public void CancelOrder(int id)
        {
           PurchaseOrder po = context.PurchaseOrder.Find(id);
            po.OrderState = 4;
            context.SaveChanges();
        }

        public void SaveOrder(OrderDetailDto order)
        {

        }

        public bool Exist(int orderID) {

            bool result = false;
            if (context.PurchaseOrder.Any(c=> c.PurchaseOrderID == orderID))
            {result = true; }
   
            return result;
        }

        public BindingList<PurchaseLineItem> OrderLineItems(int purchaseOrderID)
        {
            BindingList<PurchaseLineItem> result =
                    new BindingList<PurchaseLineItem>(context.PurchaseLineItem.Where(w => w.PurchaseOrderID == purchaseOrderID).ToList());
            return  result;           
        }

        public List<AttachmentDto> GetAttachmentDtos(int purchaseOrderID)
        {
            var result = context.Attachment.AsNoTracking().Where(o => o.PurchaseOrderID == purchaseOrderID).Select( dto => new AttachmentDto
            {
                Src = dto.src,
                AttachmentDescription = dto.AttachmentDescription,
                Creator = dto.Creator,
                CreatedDate = dto.CreateDate.GetValueOrDefault(),
                FileSize = dto.FileSize,
                AttachmentID = dto.AttachmentID
                
            }).ToList();

            return result;
        }

        public double GetSupplierTaxRate(int zipcode)
        {
           
            return double.Parse("0.0775");
        }
       
        // TODO This is the problem 
  
        public PurchaseOrder GetOrderByID(int orderNum) {


            try
            {
                var order = context.PurchaseOrder.AsNoTracking()
                .Include(p => p.PurchaseLineItem)
                .Include(j => j.Job)
                .Include(s => s.Supplier)
                .Include(t => t.Attachment)
                .Include(p => p.OrderFee)
                .Include(e => e.Employee).Where(c => c.PurchaseOrderID == orderNum).FirstOrDefault();

                return order;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                throw;
            }
               
            


        }

        public List<PurchaseOrder> GetAllOrders() {

            return context.PurchaseOrder.ToList();
        }

        public List<PurchaseOrder> GetSupplierOrders(int supplierID)
        {

            return context.PurchaseOrder.Where(c => c.SupplierID == supplierID).OrderByDescending(d => d.OrderDate).ToList();
        }

        public List<SupplierOrdersListDto> GetSupplierOrdersList(int supplierID)
        {
            
            var result = context.PurchaseOrder.Where(s => s.SupplierID == supplierID).Select(d => new SupplierOrdersListDto
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

            return context.PurchaseOrder.Where(c => c.JobID == jobID).ToList();
        }

        public List<JobOrdersDto> JobOrders(int jobID)
        {
            var result = context.PurchaseOrder.Include(e => e.Employee).Include(s => s.Supplier).Where(s => s.JobID == jobID).Select(d => new JobOrdersDto
            {
                OrderDate = d.OrderDate.GetValueOrDefault(),
                PurchaseOrderID = d.PurchaseOrderID,
                Purchaser = d.Employee.firstname,
                SupplierName = d.Supplier.SupplierName,
                OrderTotal = d.OrderTotal.GetValueOrDefault(),
               

            }).ToList();
            return result;

        }

        public void InsertOrUpdate(PurchaseOrder order) {

            if (order.PurchaseOrderID == default(int))
            {
                context.Entry(order).State = EntityState.Added ;
                context.PurchaseOrder.Add(order);
            }
            else
            {
                context.PurchaseOrder.Attach(order);
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
            po.SuppressTax = true;
            po.SubTotal = 0.00m;
            po.Recieved = false;
            po.Tax = 0.00m;
            po.OrderFormat = "Standard";
            po.AddedBy = context.Employee.Find(employee).firstname + " " + context.Employee.Find(employee).lastname;
            po.OrderState = 1;
           
            return po;
        }

        public void Delete(int orderID) {

            PurchaseOrder po = context.PurchaseOrder.Where(c => c.PurchaseOrderID == orderID).FirstOrDefault();
            context.Entry(po).State = EntityState.Deleted;
            context.PurchaseOrder.Remove(po);

        }


        public bool ProcessOrderReciept(OrderReceiptDto orderReciept)
        {
            bool result = false;

            foreach (var item in orderReciept.OrderReceiptLineItems)
            {

            }


            return result;
        }
        //Recieve Order --
        public OrderReciept RecievedOrder(PurchaseOrder order, int employeeID) {

            // Build and save OrderReceipt --
            OrderReciept oreciept = new OrderReciept();
            oreciept.PurchaseOrderID = order.PurchaseOrderID;
            oreciept.EmployeeID = employeeID;
            oreciept.ReceiptDate = DateTime.Now;
            context.OrderReciept.Add(oreciept);
            context.SaveChanges();
            List<ClaimItem> claimItems = new List<ClaimItem>();

            foreach (PurchaseLineItem item in order.PurchaseLineItem)
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
                    context.Inventory.Add(inv);
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

          
            // Get all the Suppliers Orders --
            var pOrders = context.PurchaseOrder.Where(p => p.SupplierID == SupplierID).ToList();

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
             
            
            return result;           
        }

        public List<SupplierLineItemDto> GetSupplierLineItems(int supplierID)
        {
            string id = supplierID.ToString();
            
            string sql = @"select Description,PartID,LineID,Qnty,UnitCost,PurchaseOrderID FROM PurchaseLineItem " +
                          " WHERE PurchaseOrderID IN " +
                          "(SELECT PurchaseOrderID FROM PurchaseOrder WHERE SupplierID = {0})";

            ///TODO pass a parameter to the sql
            var result = context.PurchaseLineItem.FromSqlRaw(sql, id).Select(d => new SupplierLineItemDto
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
          return context.UnitOfMeasure.AsNoTracking().ToList() ;
        }
        /// <summary>
        /// TODO this need to be much more expanded and use a composite Order DTO
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public PurchaseOrder Add(PurchaseOrder order)
        {
            context.PurchaseOrder.Add(order);
            context.SaveChanges();
            return order;
        }

        public void CreateOrUpdateOrder(OrderDetailDto orderDTO)
        {
           var ctx = context;
           var order = ctx.PurchaseOrder.Include(p => p.PurchaseLineItem).Include(a => a.Attachment).Include(f => f.OrderFee).FirstOrDefault(o => o.PurchaseOrderID == orderDTO.PurchaseOrderID);
            if (order == null)
            {
                order = new PurchaseOrder();
                ctx.PurchaseOrder.Add(order);
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
            order.PurchaseLineItem
            .Where(d => !orderDTO.LineItems.Any(LineItemDto => LineItemDto.LineID == d.LineID)).ToList()
            .ForEach(deleted => ctx.PurchaseLineItem.Remove(deleted));

            //update or add details
            orderDTO.LineItems.ToList().ForEach(detailDTO =>
            {
                var detail = order.PurchaseLineItem.FirstOrDefault(d => d.LineID == detailDTO.LineID);
                if (detail == null || detail.LineID == 0)
                {
                    detail = new PurchaseLineItem();
                    order.PurchaseLineItem.Add(detail);
                }
                detail.JobID = orderDTO.JobID;
                detail.SupplierID = orderDTO.SupplierID;
                detail.Qnty = detailDTO.Quantity;
                detail.Description = detailDTO.Description;
                detail.PurchaseOrderID = detailDTO.PurchaseOrderID;
                detail.PartID = detailDTO.PartID;
                detail.UnitCost = detailDTO.Price;
                detail.UnitOfMeasureID = detailDTO.UiD;
                detail.Extended = detailDTO.Extended;

            });

            //remove deleted orderfees -
            order.OrderFee
                .Where(d => !orderDTO.OrderFees.Any(OrderFeeDto => OrderFeeDto.OrderFeeID == d.OrderfeeID)).ToList()
                .ForEach(deleted => ctx.OrderFee.Remove(deleted));

            //update or add OrderFees
            orderDTO.OrderFees.ToList().ForEach(od =>
            {
                var orderfee = order.OrderFee.FirstOrDefault(r => r.OrderfeeID == od.OrderFeeID);
                if (orderfee == null || orderfee.OrderfeeID == 0)
                {
                    orderfee = new OrderFee();
                    order.OrderFee.Add(orderfee);
                }
                orderfee.PurchaseOrderID = order.PurchaseOrderID;
                orderfee.FeeName = od.FeeName;
                orderfee.Cost = od.Cost;
                orderfee.Extension = od.Extension;
                orderfee.Qnty = od.Qnty;
            });

            //remove deleted attachments -
            ///TODO  attachment loading is slow and delete only duplicates
            order.Attachment
                .Where(a => !orderDTO.Attachments.Any(attachDTO => attachDTO.AttachmentID == a.AttachmentID)).ToList()
                .ForEach(deleted => ctx.Attachment.Remove(deleted));

            //update or add Attachments
            orderDTO.Attachments.ToList().ForEach(ad =>
            {
                var attachmnt = order.Attachment.FirstOrDefault(r => r.AttachmentID == ad.AttachmentID);
                if (attachmnt ==null || attachmnt.AttachmentID == 0)
                {
                    attachmnt = new Attachment();
                    order.Attachment.Add(attachmnt);
                }

                attachmnt.PurchaseOrderID = ad.PurchaseOrderID;
                // how to determine if the filesource is empty but existing
                if (ad.src != null)
                {
                    attachmnt.src = ad.src;
                }
                //attachmnt.Filesource  = ad.FileSource; 
                attachmnt.AttachmentDescription = ad.AttachmentDescription;
                attachmnt.src = ad.Src;
                attachmnt.FileSize = ad.FileSize;
                attachmnt.Creator = ad.Creator;
                attachmnt.CreateDate = ad.CreatedDate;
            });

            context.SaveChanges();
        }

        public List<OrderListDto> FindSupplierOrders(int supplierID)
        {
            return context.PurchaseOrder
                .Include(j => j.Job)
                .Include(e => e.Employee)
                .Include(s => s.Supplier).OrderByDescending(r => r.OrderDate)
                            .Where(c => c.SupplierID == supplierID).AsNoTracking().Select(d => new OrderListDto
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


                return context.PurchaseOrder
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeID == employeeID).Where(r => r.Recieved == true).Where(o =>  o.OrderState != 4).OrderByDescending(r => r.OrderDate)
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
                return context.PurchaseOrder
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeID == employeeID).Where(r => r.Recieved == false).Where(o => o.OrderState != 4).OrderByDescending(r => r.OrderDate)
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
