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
    public class DetailsVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios {get;set;} 

        public DetailsVeterinariosModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }
        public IActionResult OnGet(int veterinarioId)
        {
            veterinarios = repositorioVeterinario.GetVeterinarioPorId(veterinarioId);
            if(veterinarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
