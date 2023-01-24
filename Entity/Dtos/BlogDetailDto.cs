using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class BlogDetailDto
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string CategoryName { get; set; }
        public string BlogDescription { get; set; }
    }
}
