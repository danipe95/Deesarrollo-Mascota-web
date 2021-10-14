using System.Collections.Generic;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisita(); 
        Visita AddVisita(Visita visita);
        Visita UpdateVisita(Visita visita);
        void DeleteVisita(int idVisita);
        Visita GetVisita(int idVisita);
        // Visita GetVisitaPorId(int visitaId);
    }
}