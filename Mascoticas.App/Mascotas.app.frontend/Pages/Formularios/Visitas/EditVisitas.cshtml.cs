using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia.AppRepositorios;


namespace Mascotas.app.frontend.Pages
{
    public class EditVisitasModel : PageModel
    {
         private readonly IRepositorioVisita repositorioVisita;
        [BindProperty]
        public Visita Visitas {get;set;}

        public EditVisitasModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }
        public IActionResult OnGet(int VisitaId)
        {
            Visitas = repositorioVisita.GetVisitaPorId(VisitaId);
            if(Visitas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
