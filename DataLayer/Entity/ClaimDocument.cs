using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class ClaimDocument
    {
        public int ClaimDocumentID { get; set; }
        public string DocumentDesciption { get; set; }
        public string DocumentExtension { get; set; }
        public int? ClaimItemID { get; set; }

        public virtual ClaimItem ClaimItem { get; set; }
    }
}
