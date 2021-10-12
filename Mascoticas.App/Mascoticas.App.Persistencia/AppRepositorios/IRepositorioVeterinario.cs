using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAll(); 
        Veterinario AddVeterinario(Veterinario nuevoVeterinario);
        Veterinario UpdateVeterinario(Veterinario veterinarioActualizado);
        //void DeleteVeterinario(int IdVeterinario);
        // Veterinario GetVeterinario(int IdVeterinario);
        Veterinario GetVeterinarioPorId(int veterinarioId);
    }
}

