namespace Practica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nombreCorrecto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Nombre", c => c.String());
            DropColumn("dbo.Personas", "Nomre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personas", "Nomre", c => c.String());
            DropColumn("dbo.Personas", "Nombre");
        }
    }
}
