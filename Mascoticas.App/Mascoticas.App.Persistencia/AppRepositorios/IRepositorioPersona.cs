using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona(); 
        Persona AddPersona(Persona nuevaPersona);
        Persona UpdatePersona(Persona actualizarPersona);
        //void DeletePersona(int IdPersona);
        Persona GetPersona(int IdPersona);         
    }
}