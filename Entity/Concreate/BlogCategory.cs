using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class BlogCategory : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
