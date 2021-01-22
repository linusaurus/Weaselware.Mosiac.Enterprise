using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class WorkCenter
    {
        public int? WorkCenterID { get; set; }
        public string WorkCenterName { get; set; }
        public decimal? CostRate { get; set; }
        public decimal? Availabilty { get; set; }
    }
}
