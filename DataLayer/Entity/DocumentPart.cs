using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class DocumentPart
    {
        public int PartID { get; set; }
        public int DocID { get; set; }

        public virtual Document Doc { get; set; }
        public virtual Part Part { get; set; }
    }
}
