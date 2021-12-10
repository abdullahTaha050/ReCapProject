using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
