using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class ClaimItem
    {
        public ClaimItem()
        {
            ClaimDocuments = new HashSet<ClaimDocument>();
        }

        public int ClaimItemID { get; set; }
        public int? ClaimID { get; set; }
        public int? LineID { get; set; }
        public int? partID { get; set; }
        public string Bcode { get; set; }
        public string Description { get; set; }
        public int? TransActionType { get; set; }
        public int? ProductID { get; set; }
        public string DefectDescription { get; set; }

        public virtual ICollection<ClaimDocument> ClaimDocuments { get; set; }
    }
}
