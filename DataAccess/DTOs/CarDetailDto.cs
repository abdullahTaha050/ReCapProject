using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTOs
{
    public class CarDetailDto:IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
