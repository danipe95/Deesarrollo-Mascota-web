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
    public class FInscripcionMascotaModel : PageModel
    {

        private readonly IRepositorioMascota repositorioMascota;
        public IEnumerable<Mascota> Mascotas {get;set;} 

        public FInscripcionMascotaModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
              
        public void OnGet()
        {           
            Mascotas = repositorioMascota.GetAllM();
        }

        /*public IActionResult OnGet(int mascotaId)
        {
            mascota = repositorioMascota.GetMascotaId(mascotaId);
            if(mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }*/
        
    }
}
