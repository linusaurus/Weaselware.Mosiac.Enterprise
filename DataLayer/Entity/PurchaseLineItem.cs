﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class PurchaseLineItem
    {
        public int LineID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public int? JobID { get; set; }
        public int? SupplierID { get; set; }
        public int? PartID { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Extended { get; set; }
        public bool? Recieved { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? UnitOfMeasureID { get; set; }
        public int? ProductID { get; set; }
        public int? BomID { get; set; }
        public decimal? AmountReceived { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Thick { get; set; }
        public decimal? Weight { get; set; }
        public string SupplierPartName { get; set; }
        public string BCode { get; set; }
        public string Note { get; set; }
        public bool? Rejected { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
