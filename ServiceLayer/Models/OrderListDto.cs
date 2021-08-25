using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class OrderListDto
    {
        public int PurchaseOrderID { get; set; }
        public DateTime OrderDate { get; set; }     
        public string Supplier { get; set; }
        public string Purchaser { get; set; }
        public string JobName { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool Recieved { get; set; }
    }


    public class PartOrdersDto
    {
        public int PurchaseOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string SupplierName { get; set; }
        public string JobName { get; set; }
     
      
    }
}
