﻿using System;
using System.Collections.Generic;
using System.Text;
using Boxed.Mapping;
using DataLayer.Entity;
using ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    public class OrderReceiptMapper : IMapper<OrderReciept, OrderReceiptDto>
    {
        private readonly IMapper<OrderReceiptItem, OrderRecieptLineItemDto> resourceMapper = new OrderReceiptLineMapper();

        public void Map(OrderReciept source, OrderReceiptDto destination)
        {
            if (source == null) { return; }

            destination.IsOrderComplete = source.IsOrderComplete.GetValueOrDefault();
            destination.EmployeeName = source.Employee.firstname + " " + source.Employee.lastname;
            destination.EmployeeId = source.EmployeeID.GetValueOrDefault();
            destination.PurchaseOrderID = source.OrderNum.GetValueOrDefault();
            destination.ReceiptDate = source.ReceiptDate.GetValueOrDefault();
            destination.OrderReceiptLineItems = resourceMapper.MapList(source.OrderReceiptItems);
        }

        private class OrderReceiptLineMapper : IMapper<OrderReceiptItem, OrderRecieptLineItemDto>
        {

            public void Map(OrderReceiptItem source, OrderRecieptLineItemDto destination)
            {
                destination.OrderReceiptID = source.OrderReceiptID.GetValueOrDefault();
                destination.JobID = source.JobID.GetValueOrDefault();
                destination.LineID = source.LineID.GetValueOrDefault();
                destination.PartID = source.PartID.GetValueOrDefault();
                destination.UnitPrice = source.Price.GetValueOrDefault();
                destination.PurchaseOrderID = source.PurchaseOrderID.GetValueOrDefault();
                destination.Description = source.Description;
                destination.UnitOfMeasureName = source.UnitOrMeasure.UnitName;
                destination.UiD = source.UiD.GetValueOrDefault();
                destination.QntyOrdered = source.QuantityOrdered.GetValueOrDefault();
                destination.QntyReceived = source.QuantityReceived.GetValueOrDefault();
                destination.QntyBalance = source.Balance.GetValueOrDefault();
                destination.Extended = source.Extended.GetValueOrDefault();
                destination.Note = source.Note;



            }
        }
    }
}
