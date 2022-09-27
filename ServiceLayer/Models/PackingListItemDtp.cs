using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class PackingListItemDto
    {
        public string PackingListItemID { get; set; }

        public string PackingListID { get; set; }

        public int ItemCount { get; set; }

        public int ItemQnty { get; set; }
    }
}
