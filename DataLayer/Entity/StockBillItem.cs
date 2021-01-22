using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class StockBillItem
    {
        public int StockItemID { get; set; }
        public int? StockBillD { get; set; }
        public int? PartID { get; set; }
        public int? LineItemSourceID { get; set; }
        public decimal? Qnty { get; set; }
        public string Description { get; set; }

        public virtual StockBill StockBillDNavigation { get; set; }
    }
}
