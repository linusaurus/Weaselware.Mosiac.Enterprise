using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class MyDeliveriesListDto
    {
        public int Pid { get; set; }
        public string JobName { get; set; } 

        public string Preparer { get; set; }

        public DateTime DateStamp { get; set; }
    }
}
