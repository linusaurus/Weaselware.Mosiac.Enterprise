using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class UnitOfPurchase
    {
        public int UoPID { get; set; }
        public int PartID { get; set; }
        public int? UID { get; set; }
        public string UOPName { get; set; }
        public decimal? UOPCostUnit { get; set; }
        public decimal? UOPRatio { get; set; }

        public virtual Part Part { get; set; }
    }
}
