using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Resource
    {
        public int ResourceID { get; set; }
        public int? PartID { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? Lastmod { get; set; }
        public byte[] payload { get; set; }
        public string FileSize { get; set; }
        public string filesource { get; set; }

        public virtual Part Part { get; set; }
    }
}
