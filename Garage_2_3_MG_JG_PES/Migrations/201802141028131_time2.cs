namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "CheckIn", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "CheckIn", c => c.DateTime(nullable: false));
        }
    }
}
