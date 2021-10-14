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
    public class EditVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinarios {get;set;}

        public EditVeterinariosModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }
        public IActionResult OnGet(int idVeterinario)
        {
            Veterinarios = repositorioVeterinario.GetVeterinario(idVeterinario);
            if(Veterinarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }

    }
}
