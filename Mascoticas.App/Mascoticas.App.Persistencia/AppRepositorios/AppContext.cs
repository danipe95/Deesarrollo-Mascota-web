using Microsoft.EntityFrameworkCore;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Visita> Visitas {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascoticasData ");
        }
    }
    }
    
}
