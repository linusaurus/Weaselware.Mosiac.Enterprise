using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entity;
using ServiceLayer.Models;
using Boxed.Mapping;

namespace ServiceLayer.Mappers
{
    public class PurchaseOrderToOrderReceiptMapper : IMapper<PurchaseOrder, OrderReceiptDto>
    {
        private readonly IMapper<PurchaseLineItem, OrderRecieptLineItemDto> resourceMapper = new OrderReceiptLineMapper();

        public void Map(PurchaseOrder source, OrderReceiptDto destination)
        {
            if (source == null) { return; }

            
            destination.IsOrderComplete = source.Recieved.GetValueOrDefault();
            destination.EmployeeName = source.Employee.firstname + " " + source.Employee.lastname;
            destination.EmployeeId = source.EmployeeID.GetValueOrDefault();
            destination.PurchaseOrderID = source.PurchaseOrderID;
            destination.ReceiptDate = DateTime.Today;
            destination.OrderReceiptLineItems = resourceMapper.MapList(source.PurchaseLineItems);
        }

        public class OrderReceiptLineMapper : IMapper<PurchaseLineItem, OrderRecieptLineItemDto>
        {
            
            public void Map(PurchaseLineItem source, OrderRecieptLineItemDto destination)
            {
                destination.OrderReceiptID = source.OrderReceiptID.GetValueOrDefault();
                destination.JobID = source.JobID.GetValueOrDefault();
                destination.LineID = source.LineID;
                destination.PartID = source.PartID.GetValueOrDefault();
                destination.UnitPrice = source.UnitCost.GetValueOrDefault() ;
                destination.PurchaseOrderID = source.PurchaseOrderID.GetValueOrDefault();
                destination.Description = source.Description;
                destination.UnitOfMeasureName = source.UnitOfMeasure.UnitName;
                destination.UiD = source.UnitOfMeasureID.GetValueOrDefault();
                destination.QntyOrdered = source.Qnty.GetValueOrDefault();
                destination.QntyReceived = source.AmountReceived.GetValueOrDefault();
                destination.Extended = source.Extended.GetValueOrDefault();
                destination.Note = source.Note;


               
            }
        }


    }
}
