using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietario(); 
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario);
        
    }           
}