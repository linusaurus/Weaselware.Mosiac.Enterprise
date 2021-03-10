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
            // Grab to Purchase Order
            PurchaseOrder po = _ctx.PurchaseOrders.AsNoTracking().Include(p => p.PurchaseLineItems).ThenInclude(u => u.UnitOfMeasure)
                                   .Include(e => e.Supplier).Where(o => o.PurchaseOrderID == purchaserOrderID).FirstOrDefault();

           
       
            // Populate a new Receipt
            OrderReceiptDto newReciept = new OrderReceiptDto
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

            return newReciept;
        }

        public List<PendingOrdersDto> PendingOrders()
        {
             
            var purchaseOrders = _ctx.PurchaseOrders.AsNoTracking().Include(s => s.Supplier).Include(j => j.Job).Include(e => e.Employee)
                .Where(p => p.Recieved == false).OrderBy(d => d.OrderDate)
                .Select(dto => new PendingOrdersDto 
                { 
                    PurchaseOrderID = dto.PurchaseOrderID,
                    OrderDate = dto.OrderDate.GetValueOrDefault(),
                    EmployeeName = dto.Employee.firstname,
                    JobName = dto.Job.jobname,
                    Supplier = dto.Supplier.SupplierName

                
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


        //This will return 0 or many order Receipts for anny given Purchaseorder --
        public List<OrderReceiptDto> GetOrderReceipts(int purchaseOrderID)
        {
            var ors = _ctx.OrderReciepts.Include(e => e.Employee).Where(p => p.OrderNum == purchaseOrderID).ToList();
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

        public void  UpdateOrCreate(OrderReceiptDto dto)
        {
            var ctx = _ctx;
            var orderReciept = ctx.OrderReciepts.Include(p => p.OrderReceiptItems).FirstOrDefault(o => o.OrderNum == dto.PurchaseOrderID);
            if (orderReciept == null)
            {
                orderReciept = new OrderReciept();
                ctx.OrderReciepts.Add(orderReciept);
                //ctx.SaveChanges();
            }

            //Map properties
            orderReciept.ReceiptDate = dto.ReceiptDate;
            orderReciept.OrderNum = dto.PurchaseOrderID;
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

            });

            _ctx.SaveChanges();
            
        }
    }
}
