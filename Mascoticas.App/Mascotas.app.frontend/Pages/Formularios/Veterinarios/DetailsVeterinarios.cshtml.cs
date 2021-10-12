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
    public class DetailsVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinarios {get;set;} 

        public DetailsVeterinariosModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }
        public IActionResult OnGet(int VeterinarioId)
        {
            Veterinario = repositorioVeterinario.GetVeterinarioPorId(VeterinarioId);
            if(Veterinario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
