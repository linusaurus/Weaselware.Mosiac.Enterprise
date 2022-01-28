using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class PartFastSearchDto
    {
        public int PartID { get; set; }
        public string Itemdescription { get; set; }
        public string PartNumber { get; set; }

        public string DateAdded { get; set; }

        public string AddedBy { get; set; }

    }
}
