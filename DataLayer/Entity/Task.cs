using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Task
    {
        public int TaskCode { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int? TaskType { get; set; }
        public decimal? Rate { get; set; }
        public int? TFactor { get; set; }
        public decimal? Total { get; set; }
        public string CostCalculation { get; set; }
        public decimal? MarkUp { get; set; }
        public int? PartAttachmentID { get; set; }
        public int? CutlistPart { get; set; }
        public int? WorkCenter { get; set; }
        public decimal? EstimatedTime { get; set; }
        public decimal? ActualTime { get; set; }
        public bool? Complete { get; set; }
    }
}
