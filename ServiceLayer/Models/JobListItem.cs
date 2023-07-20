using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public  class JobListItem
    {
        public int LineID { get; set; }
        public int PurchaseOrderID { get; set; }
        public decimal Qnty { get; set; }
        public string Description { get; set; }
        public decimal Extended { get; set; }
        public string SupplierName { get; set; }
    }
}
