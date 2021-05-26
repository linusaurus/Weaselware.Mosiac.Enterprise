using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class PendingOrdersDto
    {
        public int PurchaseOrderID { get; set; }
        public string JobName { get; set; }
        public string Supplier { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public bool RecievedComplete { get; set; }
        public int OrderState { get; set; }

    }
}
