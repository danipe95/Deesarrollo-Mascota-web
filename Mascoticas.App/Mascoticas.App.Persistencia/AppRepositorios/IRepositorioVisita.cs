using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAll(); 
        Visita AddVisita(Visita nuevaVisita);
        Visita UpdateVisita(Visita visitaActualizada);
        //void DeleteVisita(int idVisita);
        // Visita GetVisita(int idVisita);
        Visita GetVisitaPorId(int visitaId);
    }
}