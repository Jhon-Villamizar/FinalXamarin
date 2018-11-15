namespace GuiaLocalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblLugares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Ciudad = c.String(nullable: false),
                        Ubicacion = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        Especialidad = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(),
                        Correo = c.String(),
                        Web = c.String(),
                        Descripcion = c.String(nullable: false),
                        Imagen = c.String(nullable: false),
                        Lat = c.Single(nullable: false),
                        Lon = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblLugares");
        }
    }
}
