namespace Garage_2_3_MG_JG_PES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ÖkadefunktionalitetiModeldata : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Vehicles", "Type", c => c.String(maxLength: 20));
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(maxLength: 20));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(maxLength: 20));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(maxLength: 20));
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String());
            AlterColumn("dbo.Vehicles", "Type", c => c.String());
            AlterColumn("dbo.Vehicles", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
    }
}
