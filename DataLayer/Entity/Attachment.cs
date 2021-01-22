using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Attachment
    {
        public int AttachmentID { get; set; }
        public string AttachmentDescription { get; set; }
        public int? OrderNum { get; set; }
        public string Ext { get; set; }
        public string src { get; set; }
        public byte[] Filesource { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FileSize { get; set; }

        public virtual PurchaseOrder OrderNumNavigation { get; set; }
    }
}
