using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Supplier
    {
        public Supplier()
        {
            Parts = new HashSet<Part>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public bool? Active { get; set; }
        public int? Category { get; set; }
        public int? AccountType { get; set; }
        public string AccountNumber { get; set; }
        public double? TaxRate { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
