namespace SimpleDBProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRoom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "EstablishmentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "EstablishmentId");
        }
    }
}
