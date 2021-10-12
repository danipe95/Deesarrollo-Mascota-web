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
    public class EditMascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascotas {get;set;}

        public EditMascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public IActionResult OnGet(int mascotaId)
        {
            Mascotas = repositorioMascota.GetMascotaPorId(mascotaId);
            if(Mascotas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
