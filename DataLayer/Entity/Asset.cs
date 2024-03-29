﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Asset
    {
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public int? ManuID { get; set; }
        public int? AssetClass { get; set; }
        public decimal? Price { get; set; }
        public string Location { get; set; }
        public int? SupplierID { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ManuPartNum { get; set; }
        public string Tag { get; set; }
    }
}
