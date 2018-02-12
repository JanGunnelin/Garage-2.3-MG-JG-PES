using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Models
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("name=RegisterContext")
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
