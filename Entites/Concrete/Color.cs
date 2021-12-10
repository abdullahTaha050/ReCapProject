using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
