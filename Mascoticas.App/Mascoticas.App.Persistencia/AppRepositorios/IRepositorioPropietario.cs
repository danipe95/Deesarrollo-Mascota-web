using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios(); 
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario);
    }           
}