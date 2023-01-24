using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogDescription { get; set; }
    }
}
