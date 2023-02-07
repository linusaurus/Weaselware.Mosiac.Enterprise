using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class PartTransactionListDto
    {
        public int StockTransactionId { get; set; }  
        public int PartID { get; set; }
        public string Location { get; set; }
        public DateTime DateStamp { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        public string TransActionName { get; set; }
        public int TransactionType { get; set; }
        public string EmployeeName { get; set; }

    }
}
