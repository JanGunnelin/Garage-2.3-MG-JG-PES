namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vehicletype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "CheckOut", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "CheckOut");
        }
    }
}
