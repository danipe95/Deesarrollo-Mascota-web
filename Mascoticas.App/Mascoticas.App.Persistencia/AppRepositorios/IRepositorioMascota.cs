using Systems.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota updateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Macota GetMascota(int idMascota);
    }
}