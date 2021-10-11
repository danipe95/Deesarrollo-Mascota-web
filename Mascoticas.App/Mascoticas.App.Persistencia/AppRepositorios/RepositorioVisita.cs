using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioVisita : IRepositorioVisita
    {
        private readonly AppContext _appContext;
        
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }

        Visita IRepositorioVisita.AddVisita(Visita nuevaVisita)
        {
            var visitaAdicionada = _appContext.Visitas.Add(nuevaVisita);
            _appContext.SaveChanges();
            return visitaAdicionada.Entity;
        }

        Visita IRepositorioVisita.UpdateVisita(Visita visitaActualizada)
        {
            var visitaEncontrada = _appContext.Visitas.FirstOrDefault(v => v.Id == visitaActualizada.Id);
            if (visitaEncontrada != null)
                {
                    visitaEncontrada.Fecha = visitaActualizada.Fecha;         

                    _appContext.SaveChanges();
                }
                return visitaEncontrada;
        }

        void IRepositorioVisita.DeleteVisita(int idVisita)
        {
            var visitaEncontrada = _appContext.Visitas.FirstOrDefault(vs => vs.Id == idVisita);
            if (visitaEncontrada == null)
                return;
            _appContext.Visitas.Remove(visitaEncontrada);
            _appContext.SaveChanges();
        }

        Visita IRepositorioVisita.GetVisita(int idVisita)
        {
            return _appContext.Visitas.FirstOrDefault(vet => vet.Id == idVisita);
        } 

        IEnumerable<Visita> IRepositorioVisita.GetAllVis()
        {
            return _appContext.Visitas;
        }
    }
}