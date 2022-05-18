using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public  class StockTagDto
    {
        public int PurchaseOrderID { get; set; }
        public int OrderReceiptLineID { get; set; }
        public int LineID { get; set; }
        public int StockTransactionID { get;set; }       
        public decimal InventoryAmount { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Description { get;set;}
        public string jobname { get; set; }
        public int JobID { get; set; }
        public decimal QuantityReceived { get; set; }

        public string firstname { get; set; }
    }
}
