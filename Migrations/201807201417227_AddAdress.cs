namespace SimpleDBProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id_City = c.Int(nullable: false, identity: true),
                        Id_Region = c.Int(nullable: false),
                        Id_Country = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id_City);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id_Country = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id_Country);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id_Region = c.Int(nullable: false, identity: true),
                        Id_Country = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id_Region);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
