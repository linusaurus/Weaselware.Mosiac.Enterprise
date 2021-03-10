using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            Parts = new HashSet<Part>();
        }

        public int UnitOfMeasureID { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
