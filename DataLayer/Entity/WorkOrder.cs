using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class WorkOrder
    {
        public int? WorkOrderID { get; set; }
        public int? ProjectID { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
