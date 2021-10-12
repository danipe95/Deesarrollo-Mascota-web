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
    public class DetailsMascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        
        public IEnumerable<Mascota> mascotas {get;set;} 

        public DetailsMascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public IActionResult OnGet(int mascotaId)
        {
            mascotas = repositorioMascota.GetMascotaPorId(mascotaId);
            if(mascotas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
