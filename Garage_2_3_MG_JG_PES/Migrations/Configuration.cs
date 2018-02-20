namespace Garage_2_3_MG_JG_PES.Migrations
{
    using Garage_2_3_MG_JG_PES.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.RegisterContext context)
        {
            context.VehicleTypes.AddOrUpdate(
                p => p.Id,
                new VehicleType { Type = "Car"},
                new VehicleType { Type = "Bus" },
                new VehicleType { Type = "Truck" },
                new VehicleType { Type = "MC" },
                new VehicleType { Type = "Trike" }
                );
        }
    }
}