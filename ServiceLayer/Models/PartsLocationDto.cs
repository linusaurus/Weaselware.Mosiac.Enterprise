using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class PartsLocationDto
    {
        public int PartID { get; set; }
        public string ItemDescription { get; set; }
        public string Manupart { get; set; } = string.Empty;

        public string Location { get; set; }

        public string UnitOfMeasure { get; set; }
        public string Manufacturer { get; set; }
        public decimal StockOnHand { get; set; }


    }
}
