using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class DocumentDto
    {
        public int DocId { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
