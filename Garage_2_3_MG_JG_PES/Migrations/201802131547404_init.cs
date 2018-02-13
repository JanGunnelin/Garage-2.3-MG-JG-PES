namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleType = c.Int(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        Color = c.String(maxLength: 20),
                        Brand = c.String(maxLength: 20),
                        Model = c.String(maxLength: 20),
                        NumberOfWheels = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
