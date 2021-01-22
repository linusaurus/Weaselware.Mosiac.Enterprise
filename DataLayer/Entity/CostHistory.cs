using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class CostHistory
    {
        public int CostChangeID { get; set; }
        public string User { get; set; }
        public int? PartID { get; set; }
        public decimal? UpdatedUnitCost { get; set; }
        public decimal? UpdatedUoPCost { get; set; }
        public string UoP { get; set; }
        public DateTime? DateStamp { get; set; }
    }
}
