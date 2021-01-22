using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class PartCategory
    {
        public PartCategory()
        {
            PartTypes = new HashSet<PartType>();
        }

        public int PartCategoryID { get; set; }
        public string PartCategoryName { get; set; }

        public virtual ICollection<PartType> PartTypes { get; set; }
    }
}
