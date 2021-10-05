using Microsoft.EntityFrameworkCore;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = MascotasData;Integrated Security = True");
            //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initia  l Catalog = MascoticastData ");
        }
    }
    }
}
