using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garage_2_3_MG_JG_PES.Models;
using System.Data.Entity;


namespace Garage_2_3_MG_JG_PES.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("DefaultConnection")
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }

}