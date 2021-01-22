using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Job
    {
        public Job()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int jobID { get; set; }
        public int? company_id { get; set; }
        public int? project_id { get; set; }
        public int? structurelevel { get; set; }
        public string jobname { get; set; }
        public int? jobnumber { get; set; }
        public string jobdesc { get; set; }
        public int? leftNode { get; set; }
        public int? rightnode { get; set; }
        public int? ParentID { get; set; }
        public bool? Retired { get; set; }
        public int? Manager { get; set; }
        public bool? Visible { get; set; }
        public DateTime? start_ts { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
