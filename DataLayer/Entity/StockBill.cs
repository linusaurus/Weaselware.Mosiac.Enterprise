using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class StockBill
    {
        public StockBill()
        {
            Inventories = new HashSet<Inventory>();
            StockBillItems = new HashSet<StockBillItem>();
        }

        public int StockBillID { get; set; }
        public int? JobID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? StockBillDate { get; set; }
        public decimal? ItemTotal { get; set; }
        public bool? Submitted { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<StockBillItem> StockBillItems { get; set; }
    }
}
