using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascoticas.App.Dominio;
using Microsoft.AspNetCore.Authorization;
using Mascoticas.App.Persistencia.AppRepositorios;


namespace Mascoticas.App.Frontend.Pages
{
    public class DetailsMascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        
        //public IEnumerable<Mascota> Mascotas{set;get;} 
        public Mascota Mascotas {set;get;}

        public DetailsMascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }
        public IActionResult OnGet(int idMascota)
        {
            Mascotas = (Mascota)repositorioMascota.GetMascota(idMascota);
            if(Mascotas==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
