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
    public class DetailsPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> Propietarios {get;set;} 

        public DetailsPropietariosModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario = repositorioPropietario;
        }
        public IActionResult OnGet(int PropietarioId)
        {
            Propietario = repositorioPropietario.GetPropietarioPorId(PropietarioId);
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
