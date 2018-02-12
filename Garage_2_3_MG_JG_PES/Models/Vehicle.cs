using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}