namespace SimpleDBProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Establishments",
                c => new
                    {
                        Number = c.Int(nullable: false, identity: true),
                        EstablishmentName = c.String(nullable: false),
                        EstablishmentType = c.String(nullable: false),
                        EstablishmentAdress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Number);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomType = c.String(nullable: false),
                        PlaceCount = c.Int(nullable: false),
                        Area = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.Establishments");
        }
    }
}
