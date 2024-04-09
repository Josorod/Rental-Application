namespace RentalBuildingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fifth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        OrendarId = c.Int(nullable: false),
                        CompanyName = c.String(),
                        price = c.String(),
                        datestart = c.DateTime(nullable: false),
                        dateEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rent");
        }
    }
}
