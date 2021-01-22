using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class ResourceVersion
    {
        public int ResourceVersionID { get; set; }
        public int? ResourceID { get; set; }
        public int? RVersion { get; set; }
        public string VersionComment { get; set; }
        public byte[] Resource { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }
        public string Src { get; set; }
    }
}
