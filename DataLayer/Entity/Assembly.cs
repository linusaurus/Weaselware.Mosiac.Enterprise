using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Assembly
    {
        public Assembly()
        {
            SubAssemblies = new HashSet<SubAssembly>();
        }

        public int ProductID { get; set; }
        public string AssemblyName { get; set; }
        public string ArchRef { get; set; }
        public int? JobID { get; set; }
        public int? ProductionGroupID { get; set; }
        public DateTime? ProductionDate { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public string Note { get; set; }
        public bool? Make { get; set; }
        public decimal? Perimeter { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Area { get; set; }
        public decimal? CalculatedCost { get; set; }
        public decimal? LaborHours { get; set; }
        public string ProductionID { get; set; }
        public bool? IsContracted { get; set; }

        public virtual ProductionGroup ProductionGroup { get; set; }
        public virtual ICollection<SubAssembly> SubAssemblies { get; set; }
    }
}
