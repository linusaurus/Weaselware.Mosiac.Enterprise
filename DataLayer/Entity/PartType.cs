using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class PartType
    {
        public int PartTypeID { get; set; }
        public string PartTypeName { get; set; }
        public int? PartCategoryID { get; set; }

        public virtual PartCategory PartCategory { get; set; }
    }
}
