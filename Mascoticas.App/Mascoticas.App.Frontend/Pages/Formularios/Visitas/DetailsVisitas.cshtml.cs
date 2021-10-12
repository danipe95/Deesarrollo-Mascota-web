using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia.AppRepositorios;



namespace Mascoticas.App.Frontend.Pages
{
    public class DetailsVisitasModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        public IEnumerable<Visita> visitas {get;set;} 

        public DetailsVisitasModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }
        public IActionResult OnGet(int VisitaId)
        {
            visitas = repositorioVisita.GetVisitaPorId(VisitaId);
            if(visitas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }

    }
}
