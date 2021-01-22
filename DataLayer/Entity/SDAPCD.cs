using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class SDAPCD
    {
        public int ID { get; set; }
        public int? SDAPCD_id { get; set; }
        public decimal? BoilingPoint { get; set; }
        public decimal? VOC_Content { get; set; }
        public decimal? MixRatio { get; set; }
        public decimal? VOC_Limit { get; set; }
        public int? PartID { get; set; }
    }
}
