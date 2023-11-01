using System;
using System.Collections.Generic;
using System.Text;
using Boxed.Mapping;
using DataLayer.Entity;
using ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    public class OrderReceiptMapper : IMapper<OrderReciept, OrderReceiptDto>
    {
        private readonly IMapper<OrderReceiptItems, OrderRecieptLineItemDto> OrderReceiptItemMapper = new OrderReceiptLineMapper();

        public void Map(OrderReciept source, OrderReceiptDto destination)
        {
            if (source == null) { return; }

            destination.IsOrderComplete = source.IsOrderComplete.GetValueOrDefault();
            destination.EmployeeId = source.EmployeeID.GetValueOrDefault();
            destination.EmployeeName = source.Employee != null ? source.Employee.firstname + " " + source.Employee.lastname : "";   
            destination.PurchaseOrderID = source.PurchaseOrderID.GetValueOrDefault();
            destination.ReceiptDate = source.ReceiptDate.GetValueOrDefault();
            destination.OrderReceiptId = source.OrderReceiptID;
            destination.OrderDate = source.PurchaseOrder.OrderDate.GetValueOrDefault();
            destination.OrderReceiptLineItems = OrderReceiptItemMapper.MapList(source.OrderReceiptItems);
        }

        private class OrderReceiptLineMapper : IMapper<OrderReceiptItems, OrderRecieptLineItemDto>
        {

            public void Map(OrderReceiptItems source, OrderRecieptLineItemDto destination)
            {
                destination.OrderReceiptID = source.OrderReceiptID.GetValueOrDefault();
                destination.OrderReceiptLineID = source.OrderReceiptLineID;
                destination.JobID = source.JobID.GetValueOrDefault();
                destination.LineID = source.LineID.GetValueOrDefault();
                destination.PartID = source.PartID.GetValueOrDefault();
                destination.UnitPrice = source.Price.GetValueOrDefault();
                destination.PurchaseOrderID = source.PurchaseOrderID.GetValueOrDefault();
                destination.Description = source.Description;
                if (source.UnitOfMeasure != null) { destination.UnitOfMeasureName = source.UnitOfMeasure!.UnitName; }
                destination.UiD = source.UnitOfMeasureID.GetValueOrDefault();
                destination.QntyOrdered = source.QuantityOrdered.GetValueOrDefault();
                destination.QntyReceived = source.QuantityReceived.GetValueOrDefault();
                destination.QntyBalance = source.Balance.GetValueOrDefault();
               // destination.QntyToInventory = source.InventoryAmount.GetValueOrDefault();
                destination.Extended = source.Extended.GetValueOrDefault();
                destination.Note = source.Note;



            }
        }
    }
}
