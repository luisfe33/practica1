namespace Practica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        IDPersona = c.Int(nullable: false, identity: true),
                        Nomre = c.String(),
                        Apellido = c.String(),
                        Edad = c.Int(nullable: false),
                        ColorFavorito = c.String(),
                    })
                .PrimaryKey(t => t.IDPersona);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
