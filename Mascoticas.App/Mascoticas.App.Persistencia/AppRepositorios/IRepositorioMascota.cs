using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota(); 
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        



        // IEnumerable<Mascota> GetAll(); 
        // Mascota AddM(Mascota nuevaMascota);
        // Mascota Update(Mascota mascotaActualizada);
        // void DeleteMascota(int IdMascota);
        // Mascota GetMascota(int mascotica);
        // Mascota GetMascotaPorId(int mascotaId);
    }
}