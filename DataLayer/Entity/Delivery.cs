﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataLayer.Entity
{
    public partial class Delivery
    {
        public int DeliveryID { get; set; }
        public int? DestinationID { get; set; }
        public int? JobID { get; set; }
        public int? EmployeeID { get; set; }
        public int? PickListID { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}