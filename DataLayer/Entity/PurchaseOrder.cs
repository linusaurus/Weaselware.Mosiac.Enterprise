﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            Attachments = new HashSet<Attachment>();
            OrderFees = new HashSet<OrderFee>();
            OrderReciepts = new HashSet<OrderReciept>();
            PurchaseLineItems = new HashSet<PurchaseLineItem>();
        }

        public int OrderNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public int? SupplierID { get; set; }
        public int? EmployeeID { get; set; }
        public string SalesRep { get; set; }
        public int? JobID { get; set; }
        public bool? SuppressTax { get; set; }
        public int? ShipID { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool? Recieved { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Tax { get; set; }
        public bool? IsBackOrder { get; set; }
        public DateTime? RecievedDate { get; set; }
        public decimal? SubTotal { get; set; }
        public string Memo { get; set; }
        public int? OrderState { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string OrderFormat { get; set; }
        public double? TaxRate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Job Job { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<OrderFee> OrderFees { get; set; }
        public virtual ICollection<OrderReciept> OrderReciepts { get; set; }
        public virtual ICollection<PurchaseLineItem> PurchaseLineItems { get; set; }
    }
}
