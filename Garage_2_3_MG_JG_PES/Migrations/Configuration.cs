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
               p => p.Type,
               new VehicleType { Type = "Car" },
               new VehicleType { Type = "Bus" },
               new VehicleType { Type = "Truck" },
               new VehicleType { Type = "MC" },
               new VehicleType { Type = "Personbil" },
               new VehicleType { Type = "Lastbil" },
               new VehicleType { Type = "Buss" },
               new VehicleType { Type = "Släpvagn" },
               new VehicleType { Type = "Moped" },
               new VehicleType { Type = "Motorcykel" },
               new VehicleType { Type = "Traktor" },
               new VehicleType { Type = "Motorredskap" },
               new VehicleType { Type = "Snöskoter" },
               new VehicleType { Type = "Terränghjuling" },
               new VehicleType { Type = "Terrängskoter" },
               new VehicleType { Type = "Terrängsläp" },
               new VehicleType { Type = "Terrängvagn" },
               new VehicleType { Type = "Flygplan" },
               new VehicleType { Type = "Båt" }
               );
        }
    }
}