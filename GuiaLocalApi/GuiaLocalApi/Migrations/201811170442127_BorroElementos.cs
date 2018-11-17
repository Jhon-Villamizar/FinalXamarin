namespace GuiaLocalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BorroElementos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblLugares", "Lat");
            DropColumn("dbo.tblLugares", "Lon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblLugares", "Lon", c => c.Single(nullable: false));
            AddColumn("dbo.tblLugares", "Lat", c => c.Single(nullable: false));
        }
    }
}
