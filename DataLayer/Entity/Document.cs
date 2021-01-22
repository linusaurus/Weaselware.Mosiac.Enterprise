using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Document
    {
        public Document()
        {
            DocumentParts = new HashSet<DocumentPart>();
        }

        public int DocID { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<DocumentPart> DocumentParts { get; set; }
    }
}
