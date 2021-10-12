using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllM(); 
        Mascota Add(Mascota nuevaMascota);
        Mascota Update(Mascota mascotaActualizada);
        // void DeleteMascota(int IdMascota);
        Mascota GetMascota(int mascotica);
    }
}