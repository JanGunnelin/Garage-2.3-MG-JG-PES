﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class VehicleType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        // Navigational property
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}