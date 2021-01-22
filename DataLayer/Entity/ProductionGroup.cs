using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class ProductionGroup
    {
        public ProductionGroup()
        {
            Assemblies = new HashSet<Assembly>();
        }

        public int ProductionGroupID { get; set; }
        public string ProductionGroupName { get; set; }
        public int? JobID { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsContracted { get; set; }

        public virtual ICollection<Assembly> Assemblies { get; set; }
    }
}
