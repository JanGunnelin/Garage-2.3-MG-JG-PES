namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Idfix : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeID" });
            CreateIndex("dbo.Vehicles", "VehicleTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeId" });
            CreateIndex("dbo.Vehicles", "VehicleTypeID");
        }
    }
}
