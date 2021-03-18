using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class OrderReciept
    {
        public OrderReciept()
        {
            OrderReceiptItems = new HashSet<OrderReceiptItem>();
        }

        public int OrderReceiptID { get; set; }
        public int? EmployeeID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public bool? IsOrderComplete { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<OrderReceiptItem> OrderReceiptItems { get; set; }
    }
}
