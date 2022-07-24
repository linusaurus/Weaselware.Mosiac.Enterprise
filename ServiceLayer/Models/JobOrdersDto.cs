using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class JobOrdersDto
    {
        
            public int PurchaseOrderID { get; set; }
 
            public DateTime OrderDate { get; set; }
 
            public string  Purchaser { get; set; }
 
            public string SupplierName { get; set; }

            public decimal OrderTotal { get;set; }
          
    }
}
