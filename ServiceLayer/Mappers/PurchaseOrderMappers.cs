using System;
using System.Collections.Generic;
using DataLayer.Entity;
using ServiceLayer.Models;
using Boxed.Mapping;

namespace ServiceLayer.Mappers
{
    public class PurchaseOrderMapper : IMapper<PurchaseOrder, OrderDetailDto>
    {
        private readonly IMapper<PurchaseLineItem, LineItemDto> lineMapper = new LineItemMapper();
        private readonly IMapper<OrderFee, OrderFeeDto> orderFeeMapper = new OrderFeeMapper();
        private readonly IMapper<Attachment, AttachmentDto> attachmentMapper = new AttachmentMapper();
       
        public void Map(PurchaseOrder source, OrderDetailDto destination)
        {
            if (source == null) { return; }
            destination.ExpectedDate = source.ExpectedDate ?? DateTime.Today.AddDays(1.0);
            destination.OrderDate = source.OrderDate.Value.ToShortDateString();
            destination.JobCostName = source.Job.jobdesc ?? String.Empty;
            destination.JobID = source.JobID.GetValueOrDefault();
            destination.JobName = source.Job.jobname;
            destination.EmployeeID = source.EmployeeID.GetValueOrDefault();
            destination.OrderTotal = source.OrderTotal.GetValueOrDefault();
            destination.PurchaseOrderID = source.PurchaseOrderID;
            destination.Purchaser = source.Employee.firstname + " " + source.Employee.lastname;
            destination.ShipID = source.ShipID.GetValueOrDefault();
            destination.ShippingCost = source.ShippingCost.GetValueOrDefault();
            destination.SubTotal = source.SubTotal.GetValueOrDefault();
            destination.SupplierName = source.Supplier.SupplierName;
            destination.SupplierAddress = source.Supplier.Address1 ?? "";
            destination.SupplierCity = source.Supplier.City;
            destination.SupplierState = source.Supplier.State;
            destination.SupplierZip = source.Supplier.Zip;
            destination.SalesRep = source.SalesRep;
            destination.Tax = source.Tax.GetValueOrDefault();
            destination.TaxRate = source.TaxRate.GetValueOrDefault();
            destination.Taxable = source.SuppressTax.GetValueOrDefault();
            destination.SupplierID = source.SupplierID.GetValueOrDefault();
            destination.SupplierPhone = source.Supplier.Phone;
            destination.SupplierFax = source.Supplier.Fax;
            destination.OrderTotal = source.OrderTotal.GetValueOrDefault();
            destination.Memo = source.Memo;
            destination.TaxRate = source.TaxRate.GetValueOrDefault();
            destination.AccountNumber = source.Supplier.AccountNumber;

            destination.LineItems = lineMapper.MapList(source.PurchaseLineItems);
            destination.Attachments = attachmentMapper.MapList(source.Attachments);
            destination.OrderFees = orderFeeMapper.MapList(source.OrderFees);
 
        }
    }

    public class LineItemMapper : IMapper<PurchaseLineItem, LineItemDto>
    {
        public void Map(PurchaseLineItem source, LineItemDto destination)
        {
            destination.LineID = source.LineID;
            destination.PartID = source.PartID.GetValueOrDefault();
            destination.Price = source.UnitCost.GetValueOrDefault();
            destination.PurchaseOrderID = source.PurchaseOrderID.GetValueOrDefault();
            destination.Description = source.Description;
            destination.Quantity = source.Qnty.GetValueOrDefault();
            destination.UiD = source.UnitOfMeasureID.GetValueOrDefault();
            destination.Extended = source.Extended.GetValueOrDefault();
           
        }
    }

    public class OrderFeeMapper : IMapper<OrderFee, OrderFeeDto>
    {
        public void Map(OrderFee source, OrderFeeDto destination)
        {
            destination.OrderFeeID = source.OrderfeeID;
            destination.FeeName = source.FeeName;
            destination.Qnty = source.Qnty.GetValueOrDefault();
            destination.Cost = source.Cost.GetValueOrDefault();
            destination.Extension = source.Extension.GetValueOrDefault();
            
        }
    }

    public class AttachmentMapper : IMapper<Attachment, AttachmentDto>
    {
        public void Map(Attachment source, AttachmentDto destination)
        {
            destination.AttachmentID = source.AttachmentID;
            destination.OrderNum = source.OrderNum.GetValueOrDefault();
            destination.AttachmentDescription = source.AttachmentDescription;
            destination.Src = source.src;
            destination.Ext = source.Ext;
            //destination.FileSource = source.Filesource;
            destination.Creator = source.Creator;
            destination.CreatedDate = source.CreateDate.GetValueOrDefault();
            destination.FileSize = source.FileSize;
        }
    }
}
