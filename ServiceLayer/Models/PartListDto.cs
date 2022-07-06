using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class PartListDto
    {
        public int PartID { get; set; }
        public string Itemdescription { get; set; }
        public string Manufacturer { get; set; }
        public string Location { get; set; }

    }
}
