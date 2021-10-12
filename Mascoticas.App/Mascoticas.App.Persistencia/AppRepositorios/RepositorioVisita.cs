using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioVisita : IRepositorioVisita
    {
        /*datos visita: String Fecha, int Id*/
        
        /*private readonly AppContext _appContext;
        
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }*/

        List<Visita> visita;

        public RepositorioVisita()
        {

            visita = new List<Visita>()
            {
                new Visita{Id=1, Fecha="01/01/2021"},
                new Visita{Id=2, Fecha = "31/10/2021"},
                new Visita{Id=3, Fecha = "01/11/2021"}
                };
        }

        public Visita AddVisita(Visita nuevaVisita)
        {
            nuevaVisita.Id = visita.Max(r => r.Id)+1;
            visita.Add(nuevaVisita);
            return nuevaVisita;
        }

        public Visita UpdateVisita(Visita visitaActualizada)
        {
            var visitaEncontrada= visita.SingleOrDefault(r => r.Id==visitaActualizada.Id);
            if (visitaEncontrada!=null)
            {  
                visitaEncontrada.Id = visitaActualizada.Id;
                visitaEncontrada.Fecha = visitaActualizada.Fecha;
            }
            return visitaEncontrada;
        }

         public IEnumerable<Visita> GetAllVis()
        {
            return visita;
        }

        public Visita GetVisita(int idVisita)
        {
            return visita.SingleOrDefault(m => m.Id==idVisita);
        }

        public Visita GetVisitaPorId(int visitaId)      
        {
            return visita.SingleOrDefault(m => m.Id==visitaId);
        }
        /*
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
        }*/
    }
}