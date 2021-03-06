using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
