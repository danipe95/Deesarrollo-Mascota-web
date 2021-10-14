using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona(); 
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);         
    }
}