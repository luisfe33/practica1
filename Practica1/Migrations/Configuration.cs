namespace Practica1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Practica1.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Practica1.Models.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.PERSONA.AddOrUpdate(
                p => p.IDPersona,
                new Models.Persona { IDPersona=1, Nombre="Luis ", Apellido="Romero", Edad = 21, ColorFavorito="Negro" },
                new Models.Persona { IDPersona=2, Nombre="Angela ", Apellido="Reyes", Edad = 18, ColorFavorito="Azul" },
                new Models.Persona { IDPersona=3, Nombre="Mario ", Apellido="Casilla", Edad = 17, ColorFavorito="Amarillo" },
                new Models.Persona { IDPersona=4, Nombre="Julia ", Apellido="Perez", Edad = 48, ColorFavorito="Verde" },
                new Models.Persona { IDPersona=5, Nombre ="Margarito ", Apellido="Casa", Edad = 21, ColorFavorito="Todo" }
                );
        }
    }
}
