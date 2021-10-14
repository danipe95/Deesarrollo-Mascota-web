using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario(); 
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
        // Veterinario GetVeterinarioPorId(int veterinarioId);
    }
}

