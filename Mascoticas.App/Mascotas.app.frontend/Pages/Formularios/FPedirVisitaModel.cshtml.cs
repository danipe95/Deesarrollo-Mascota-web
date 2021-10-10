using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.app.frontend.pages
{
    public class FPedirVisitaModelModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        public IEnumerable<Visita> Visitas {get;set;} 

        public FPedirVisitaModelModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = new repositorioVisita(new Mascoticas.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Vistas = repositorioVisita.GetAllVis();
        }
    }
}
