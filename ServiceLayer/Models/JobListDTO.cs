using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models
{
    public class JobListDto
    {
        public JobListDto()
        {
            Products = new List<ProductDto>();
        }
        public int JobID { get; set; }
        public string JobName { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
