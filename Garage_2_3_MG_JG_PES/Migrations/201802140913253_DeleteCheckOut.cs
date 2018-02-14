namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCheckOut : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vehicles", "CheckOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "CheckOut", c => c.DateTime(nullable: false));
        }
    }
}
