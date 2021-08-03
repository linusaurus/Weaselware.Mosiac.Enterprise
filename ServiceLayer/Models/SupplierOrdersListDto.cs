using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class SupplierOrdersListDto
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }

        public string Purchaser { get; set; }

        public string JobName { get; set; }

        public decimal OrderTotal { get; set; }

        public bool Received { get; set; }

    }
}
