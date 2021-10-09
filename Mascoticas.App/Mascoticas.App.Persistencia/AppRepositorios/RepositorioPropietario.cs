using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var PropietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return PropietarioAdicionado.Entity;
        }
        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if(PropietarioEncontrado != null)
                {
                    PropietarioEncontrado.idPersona = propietario.idPersona;
                    PropietarioEncontrado.Nombres = propietario.Nombres;
                    PropietarioEncontrado.Apellidos = propietario.Apellidos;
                    PropietarioEncontrado.Celular = propietario.Celular;
                    PropietarioEncontrado.Email = propietario.Email;
                    _appContext.SaveChanges();
                }
                return PropietarioEncontrado;
        }
        void IRepositorioPropietario.DeletePropietario(int idPersona)
        {
            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == idPersona);
            if(PropietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(PropietarioEncontrado);
            _appContext.SaveChanges();
        }
        
        Propietario IRepositorioPropietario.GetPropietario(int idPersona)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == idPersona);
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }
    }
}
