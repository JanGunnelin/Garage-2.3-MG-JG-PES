namespace Garage_2_3_MG_JG_PES.Migrations
{
    using Garage_2_3_MG_JG_PES.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   

    internal sealed class Configuration : DbMigrationsConfiguration<Garage_2_3_MG_JG_PES.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage_2_3_MG_JG_PES.DataAccessLayer.RegisterContext context)
        {

            context.Vehicles.AddOrUpdate(
                p => p.RegistrationNumber,
                new Models.Vehicle { VehicleType = Models.VehicleType.Car, RegistrationNumber = "ABC123", Color = "Red", Brand = "Volvo", Model = "P30", NumberOfWheels = 4, CheckIn = DateTime.Now },
                new Models.Vehicle { VehicleType = Models.VehicleType.Bus, RegistrationNumber = "ABC124", Color = "Orange", Brand = "MAN", Model = "Cityliner", NumberOfWheels = 6, CheckIn = DateTime.Now },
                new Models.Vehicle { VehicleType = Models.VehicleType.Truck, RegistrationNumber = "ABC125", Color = "Pink", Brand = "Scania", Model = "Mega", NumberOfWheels = 16   , CheckIn= DateTime.Now },
                new Models.Vehicle { VehicleType = Models.VehicleType.MC, RegistrationNumber = "ABC126", Color = "Green", Brand = "Suzuki", Model = "Sport", NumberOfWheels = 2, CheckIn = DateTime.Now }
                );  
        }
    }
}