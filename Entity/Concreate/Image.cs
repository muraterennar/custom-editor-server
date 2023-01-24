using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
