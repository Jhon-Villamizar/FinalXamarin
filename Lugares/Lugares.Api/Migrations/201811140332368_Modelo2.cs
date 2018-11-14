namespace Lugares.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lugares", "Ubicacion", c => c.String(nullable: false));
            DropColumn("dbo.Lugares", "Lugar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lugares", "Lugar", c => c.String(nullable: false));
            DropColumn("dbo.Lugares", "Ubicacion");
        }
    }
}
