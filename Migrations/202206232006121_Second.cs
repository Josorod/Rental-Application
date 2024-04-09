namespace RentalBuildingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Room", "IsAvailable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Room", "IsAvailable");
        }
    }
}
