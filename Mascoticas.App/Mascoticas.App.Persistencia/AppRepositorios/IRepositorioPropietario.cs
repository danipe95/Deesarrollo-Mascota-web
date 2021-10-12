using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios(); 
        Propietario AddPropietario(Propietario npropietario);
        Propietario UpdatePropietario(Propietario propietarioA);
        //void DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario);
        Propietario GetPropietarioPorId(int propietarioId);
    }           
}