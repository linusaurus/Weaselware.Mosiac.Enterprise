using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Inventory
    {
        public int StockTransactionID { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? LineID { get; set; }
        public int? PartID { get; set; }
        public int? StockBillID { get; set; }
        public int? JobID { get; set; }
        public string Location { get; set; }
        public int? ProductID { get; set; }
        public DateTime? DateStamp { get; set; }
        public decimal? QntyOrdered { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? UiD { get; set; }
        public int? TransActionType { get; set; }
        public int? Emp_id { get; set; }
        public decimal? QntyReceived { get; set; }
        public decimal? QntyBackOrdered { get; set; }
        public bool? Rejected { get; set; }

        public virtual StockBill StockBill { get; set; }
    }
}
