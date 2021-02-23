using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace asp_net_core.Models
{
    public class SuscriptorContext: DbContext
    {
        public DbSet<Suscriptor> Suscriptores { get; set; }

        public SuscriptorContext(DbContextOptions<SuscriptorContext> options ): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // var escuela = new Suscriptor();
            //   escuela.Id = Guid.NewGuid().ToString();
            //   escuela.Nombre = "Carlos"; escuela.Apellido = "Sainz";
            //   escuela.TipoDocumento = TiposDocumento.DNI;
            //   escuela.NumeroDocumento = 35111222;
            //   escuela.Dirección = "Avenida";
            //   escuela.Email = "carlos@mail.com";
            //   escuela.NombreUsuario = "carlos55"; escuela.Password = "ale123";

            var escuela = new List<Suscriptor>()
            {
                new Suscriptor() { Id = Guid.NewGuid().ToString(), Nombre = "Carlos", Apellido = "Sainz", TipoDocumento = TiposDocumento.DNI, NumeroDocumento = 39111222, Dirección = "España", Email = "carlos@mail.com", NombreUsuario = "carlos55", Password = "carlos123" },
                new Suscriptor() { Id = Guid.NewGuid().ToString(), Nombre = "Max", Apellido = "Verstappen", TipoDocumento = TiposDocumento.DNI, NumeroDocumento = 42888333, Dirección = "Holanda", Email = "max@mail.com", NombreUsuario = "max33", Password = "max123" },
                new Suscriptor() { Id = Guid.NewGuid().ToString(), Nombre = "Sebastian", Apellido = "Vettel", TipoDocumento = TiposDocumento.DNI, NumeroDocumento = 32999777, Dirección = "Alemania", Email = "sebs@mail.com", NombreUsuario = "seb5", Password = "seb123" } 
            };

            var oEscuela = (    from d in escuela
                                where d.NumeroDocumento == 42888333
                                select d);

            Console.WriteLine(oEscuela);

            modelBuilder.Entity<Suscriptor>().HasData( escuela );
        }
    }
}