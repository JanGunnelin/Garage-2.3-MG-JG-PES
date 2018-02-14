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
                new Models.Vehicle {VehicleType = Models.VehicleType.Car, RegistrationNumber = "ABC123", Color = " Röddd", Brand = "Volvo", Model = "Volvo P30", NumberOfWheels = 4, CheckIn = DateTime.Now } ,
                new Models.Vehicle { VehicleType = Models.VehicleType.Car, RegistrationNumber = "ABC124", Color = "Mellan Röd", Brand = "Saabb", Model = "Saab Aereo", NumberOfWheels = 4, CheckIn = DateTime.Now } ,
                new Models.Vehicle {VehicleType = Models.VehicleType.Car, RegistrationNumber = "ABC125", Color = "Svag Röd", Brand = "Ladaa", Model = "Lada Sport", NumberOfWheels = 4   , CheckIn= DateTime.Now }
                );  
        }
    }
}
