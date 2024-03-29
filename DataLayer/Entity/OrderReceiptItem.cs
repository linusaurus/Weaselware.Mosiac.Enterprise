﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class OrderReceiptItem
    {
        public int OrderReceiptLineID { get; set; }
        public int? LineID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public int? JobID { get; set; }
        public int? UnitOfMeasureID { get; set; }
        public int? PartID { get; set; }
        public decimal? QuantityOrdered { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? Balance { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Extended { get; set; }
        public bool? IsComplete { get; set; }
        public int? OrderReceiptID { get; set; }
        public string Note { get; set; }
        public decimal? InventoryAmount { get; set; }

        public bool? Pushed { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        public virtual OrderReciept OrderReceipt { get; set; }
    }
}
