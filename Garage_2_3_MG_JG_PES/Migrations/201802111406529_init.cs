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
                        Id = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        RegistrationNumber = c.String(),
                        Color = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        NumberOfWheels = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
