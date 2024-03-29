﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Part
    {
        public Part()
        {
            DocumentParts = new HashSet<DocumentPart>();
            Resources = new HashSet<Resource>();
        }

        public int PartID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string PartNum { get; set; }
        public int? ManuID { get; set; }
        public bool? ObsoluteFlag { get; set; }
        public int? PartTypeID { get; set; }
        public decimal? Cost { get; set; }
        public int? UnitOfMeasureID { get; set; }
        public string Location { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Waste { get; set; }
        public decimal? MarkUp { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? UseSupplierNameFlag { get; set; }
        public string ManuPartNum { get; set; }
        public string SKU { get; set; }
        public bool? CARBtrack { get; set; }
        public int? ParentID { get; set; }
        public decimal? Amount_Required { get; set; }

        public Manu Manu { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<DocumentPart> DocumentParts { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
