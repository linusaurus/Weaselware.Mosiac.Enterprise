using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class OrderReceiptHistoryDto
    {
        public int OrderReceiptID {get;set;}

        public DateTime ReceivedOn { get; set; }

        public int PurchaseOrderID { get; set; }

        public string Employee { get; set; }

        public string SupplierName { get; set; }

        public string JobName { get; set; }

        public decimal OrderTotal { get; set; }

        public string OrderState { get; set; }
        

    }
}
