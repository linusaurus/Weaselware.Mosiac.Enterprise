﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataLayer.Entity;

public partial class PickList
{
    public int PickListID { get; set; }

    public DateTime? DateStamp { get; set; }

    public int? JobID { get; set; }

    public int? EmployeeID { get; set; }

    public int? ItemCount { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public bool? Delivered { get; set; }

    public bool? Submitted { get; set; }

    public int? DestinationID { get; set; }

    public virtual ICollection<Delivery> Delivery { get; set; } = new List<Delivery>();

    public virtual Destination Destination { get; set; }

    public virtual Employee Employee { get; set; }

    public virtual Job Job { get; set; }

    public virtual ICollection<PickListItem> PickListItem { get; set; } = new List<PickListItem>();
}