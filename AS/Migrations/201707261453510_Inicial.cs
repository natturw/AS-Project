namespace Alpaca_Smith.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imagen = c.String(),
                        Titulo = c.String(),
                        Precio = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Mail = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaDeNacimiento = c.DateTime(nullable: false),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.Mail);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.Productoes");
        }
    }
}
