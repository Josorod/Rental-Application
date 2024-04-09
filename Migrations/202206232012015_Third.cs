namespace RentalBuildingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Room", "TypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Room", "TypeName");
        }
    }
}
