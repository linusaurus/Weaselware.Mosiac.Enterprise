using DataLayer.Entity;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using ServiceLayer.Models;
using ServiceLayer.Mappers;

namespace ServiceLayer
{
    public class OrderReceiptRepository 
    {
        
        private readonly MosaicContext _ctx;
        private readonly OrderReceiptMapper _mapper = new OrderReceiptMapper();

        public OrderReceiptRepository(MosaicContext context)
        { _ctx = context;}

        /// <summary>
        /// the big Kohuna --<>
        /// </summary>
        /// <param name="purchaserOrderID"></param>
        /// <returns></returns>
        public OrderReceiptDto ReceiveOrder(int purchaserOrderID)
        {
            OrderReceiptDto newReciept;
            // Grab to Purchase Order
            PurchaseOrder po = _ctx.PurchaseOrders.AsNoTracking().Include(p => p.PurchaseLineItems).ThenInclude(u => u.UnitOfMeasure).Include(x => x.OrderReciepts)
                                   .Include(e => e.Supplier).Where(o => o.PurchaseOrderID == purchaserOrderID).FirstOrDefault();
            
            // Test for existing Order Receipt
            if (po.OrderReciepts.Any())
            {
                newReciept = GetOrderReceipt(po.OrderReciepts.FirstOrDefault().OrderReceiptID);
            }
            else
            {
                // Populate a new Receipt
                newReciept = new OrderReceiptDto
                {
                    IsOrderComplete = false,
                    ReceiptDate = DateTime.Today,
                    PurchaseOrderID = purchaserOrderID,
                    EmployeeName = "Rich",
                    EmployeeId = 8
                };
            
                foreach (var lines in po.PurchaseLineItems)
                {
                    OrderRecieptLineItemDto item = new OrderRecieptLineItemDto();
                    item.Description = lines.Description;
                    item.PurchaseOrderID = lines.PurchaseOrderID.GetValueOrDefault();
                    item.JobID = po.JobID.GetValueOrDefault();
                    item.LineID = lines.LineID;
                    item.UiD  = lines.UnitOfMeasureID.GetValueOrDefault();
                    item.QntyOrdered = lines.Qnty.GetValueOrDefault();
                    item.QntyBalance = 0.0m;
                    item.QntyReceived = 0.0m;
                    item.ItemsRecievedComplete = false;
                    item.QntyToInventory = lines.Qnty.GetValueOrDefault();
                    item.PartID = lines.PartID.GetValueOrDefault();
                    item.UnitOfMeasureName = lines.UnitOfMeasure.UnitName ?? "Ea";
                    item.UnitToQuantityRatio =  1.00m;
                    item.QntyToInventory = 0.0m;
                    // -- Add the OrderReciptItem to the OrderReciept---->
                    newReciept.OrderReceiptLineItems.Add(item);
                
                }
            }

            return newReciept;
        }


        public List<PendingOrdersDto> PendingOrders(int orderState)
        {
             
            var purchaseOrders = _ctx.PurchaseOrders.AsNoTracking().Include(s => s.Supplier).Include(j => j.Job).Include(e => e.Employee)
                .Where(p => p.OrderState == orderState).OrderBy(d => d.OrderDate)
                .Select(dto => new PendingOrdersDto 
                { 
                    PurchaseOrderID = dto.PurchaseOrderID,
                    OrderDate = dto.OrderDate.GetValueOrDefault(),
                    EmployeeName = dto.Employee.firstname,
                    JobName = dto.Job.jobname,
                    Supplier = dto.Supplier.SupplierName,
                    RecievedComplete = dto.Recieved.GetValueOrDefault()

                }).ToList();

            return purchaseOrders;
            
        }

        public List<PendingOrdersDto> UnRecievedOrders(int orderState)
        {

            var purchaseOrders = _ctx.PurchaseOrders.AsNoTracking().Include(s => s.Supplier)
                .Where(p => p.OrderState == orderState).OrderBy(d => d.OrderDate)
                .Select(dto => new PendingOrdersDto
                {
                    PurchaseOrderID = dto.PurchaseOrderID,
                    OrderDate = dto.OrderDate.GetValueOrDefault(),
                    Supplier = dto.Supplier.SupplierName,
                    OrderState = dto.OrderState.GetValueOrDefault()

                }).ToList();

            return purchaseOrders;

        }

        public List<OrderReceiptDto> GetAllOrderReceipts()
        {
            var ors = _ctx.OrderReciepts.Include(e => e.Employee).Take(100).ToList();
            List<OrderReceiptDto> dtos = new List<OrderReceiptDto>();
           
            foreach (var o in ors)
            {
                OrderReceiptDto dto = new OrderReceiptDto();
                _mapper.Map(o, dto);
                dtos.Add(dto);
            }
            return dtos;
        }

        public OrderReceiptDto GetOrderReceipt(int orderReceiptID)
        {
            OrderReceiptDto dto = new OrderReceiptDto();
            var or = _ctx.OrderReciepts
                .Include(l => l.OrderReceiptItems).ThenInclude(o => o.UnitOfMeasure)
                .Include(e => e.Employee).Where(p => p.OrderReceiptID == orderReceiptID).First();

            OrderReceiptMapper mapper = new OrderReceiptMapper();
            mapper.Map(or, dto);
                
            return dto;
        }


        //This will return 0 or many order Receipts for anny given Purchaseorder --
        //This should be replaced with a simple select into for a single ordereceipt
        public List<OrderReceiptDto> GetOrderReceipts(int purchaseOrderID)
        {
            var ors = _ctx.OrderReciepts.Include(e => e.Employee).Where(p => p.PurchaseOrderID == purchaseOrderID).ToList();
            List<OrderReceiptDto> dtos = new List<OrderReceiptDto>();
            //List<OrderReciept> orderReceipts = _ctx.OrderReciepts.Where(o => o.OrderNum == purchaseOrderID).ToList();
            foreach (var o in ors)
            {
                OrderReceiptDto dto = new OrderReceiptDto();
                _mapper.Map(o, dto);
                dtos.Add(dto);
             }
            return dtos;
        }

        public bool ProcessOrderReceipt()
        {
            
            return true;
        }

        public int  UpdateOrCreate(OrderReceiptDto dto)
        {
            var ctx = _ctx;
            var orderReciept = ctx.OrderReciepts.Include(p => p.OrderReceiptItems)
                                                .Include(d => d.PurchaseOrder)
                                                .FirstOrDefault(o => o.PurchaseOrderID == dto.PurchaseOrderID);
            if (orderReciept == null)
            {
                orderReciept = new OrderReciept();
                ctx.OrderReciepts.Add(orderReciept);
                ctx.SaveChanges();
            }

            //Map properties
            orderReciept.ReceiptDate = dto.ReceiptDate;
            orderReciept.PurchaseOrderID = dto.PurchaseOrderID;
            orderReciept.IsOrderComplete = dto.IsOrderComplete;
            orderReciept.EmployeeID = dto.EmployeeId;

            //remove deleted details -
            orderReciept.OrderReceiptItems
            .Where(d => !dto.OrderReceiptLineItems.Any(dto => dto.OrderReceiptLineID == d.OrderReceiptLineID)).ToList()
            .ForEach(deleted => ctx.OrderReceiptItems.Remove(deleted));

            //update or add details
            dto.OrderReceiptLineItems.ToList().ForEach(detailDTO =>
            {
                var detail = orderReciept.OrderReceiptItems.FirstOrDefault(d => d.OrderReceiptLineID == detailDTO.OrderReceiptLineID);
                if (detail == null || detail.LineID == default )
                {
                    detail = new OrderReceiptItem();
                    ctx.OrderReceiptItems.Add(detail);
                }

                detail.JobID = detailDTO.JobID;
                detail.OrderReceiptID = orderReciept.OrderReceiptID;
                detail.Description = detailDTO.Description;
                detail.PurchaseOrderID = detailDTO.PurchaseOrderID;
                detail.PartID = detailDTO.PartID;
                detail.Price = detailDTO.UnitPrice;
                detail.UnitOfMeasureID = detailDTO.UiD;
                detail.LineID = detailDTO.LineID;
                detail.Extended = detailDTO.Extended;
                detail.QuantityOrdered = detailDTO.QntyOrdered;
                detail.QuantityReceived = detailDTO.QntyReceived;
                detail.Balance = detailDTO.QntyBalance;
                detail.IsComplete = detailDTO.ItemsRecievedComplete;
                detail.InventoryAmount = detailDTO.QntyToInventory;
                
            });

            // set the PO order status and Received Date.

            bool IsNotComplete = dto.OrderReceiptLineItems.Any(p => p.ItemsRecievedComplete == false);
            orderReciept.IsOrderComplete = !IsNotComplete;
            PurchaseOrder po = _ctx.PurchaseOrders.Find(orderReciept.PurchaseOrderID);

            po.Recieved = !IsNotComplete;
            po.IsBackOrder = IsNotComplete;
            po.RecievedDate = orderReciept.ReceiptDate.GetValueOrDefault();
            
            //// Push the Item to inventory -------------------------------
           
            //foreach (var item in dto.OrderReceiptLineItems)
            //{
            //    Inventory inv = new Inventory();
            //    inv.DateStamp = DateTime.Now;
            //    inv.Description = item.Description;
            //    inv.EmpID = orderReciept.EmployeeID;
            //    inv.JobID = item.JobID;
            //    inv.LineID = item.LineID;
            //    inv.OrderReceiptID = orderReciept.OrderReceiptID;
            //    inv.PartID = item.PartID;
            //    inv.QntyOrdered = item.QntyOrdered;
            //    inv.QntyReceived = item.QntyReceived;
            //    inv.UnitOfMeasureID = item.UiD;
            //    inv.TransActionType = 1;
            //    inv.InventoryAmount = item.QntyToInventory;
              
            //    _ctx.Inventories.Add(inv);
            //}

            _ctx.SaveChanges();
            return orderReciept.OrderReceiptID;
            
        }


      
       
    }
}
