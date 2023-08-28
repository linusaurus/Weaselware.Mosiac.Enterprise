﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataLayer.Entity;

public partial class Inventory
{
    public int StockTransactionID { get; set; }

    public int? OrderReceiptID { get; set; }

    public int? LineID { get; set; }

    public int? PartID { get; set; }

    public int? JobID { get; set; }

    public int? ProductID { get; set; }

    public DateTime? DateStamp { get; set; }

    public decimal? QntyOrdered { get; set; }

    public string Note { get; set; }

    public string Description { get; set; }

    public int? UnitOfMeasureID { get; set; }

    public int? TransActionType { get; set; }

    public int? EmpID { get; set; }

    public decimal? QntyReceived { get; set; }

    public decimal? InventoryAmount { get; set; }

    public int? LocationID { get; set; }

    public int? TransactionReferenceType { get; set; }

    public string TransactionReference { get; set; }

    public virtual Employee Emp { get; set; }

    public virtual Location LocationNavigation { get; set; }

    public virtual TransActionType TransActionTypeNavigation { get; set; }

    public virtual UnitOfMeasure UnitOfMeasure { get; set; }
}