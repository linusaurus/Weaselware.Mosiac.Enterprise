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
        
        private readonly BadgerContext _ctx;
        private readonly OrderReceiptMapper _mapper = new OrderReceiptMapper();

        public OrderReceiptRepository(BadgerContext context)
        { _ctx = context;}

        public List<PendingOrdersDto> PendingOrders()
        {
             
            var purchaseOrders = _ctx.PurchaseOrders.AsNoTracking().Include(s => s.Supplier).Include(j => j.Job).Include(e => e.Employee)
                .Where(p => p.Recieved == false)
                .Select(dto => new PendingOrdersDto 
                { 
                    PurchaseOrderID = dto.OrderNum,
                    OrderDate = dto.OrderDate.GetValueOrDefault(),
                    EmployeeName = dto.Employee.firstname,
                    JobName = dto.Job.jobname,
                    Supplier = dto.Supplier.SupplierName

                
                }).ToList();

            return purchaseOrders;
            
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
                detail.UiD = detailDTO.UiD;
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
