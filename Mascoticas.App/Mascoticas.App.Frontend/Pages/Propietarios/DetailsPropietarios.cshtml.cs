using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;


namespace Mascoticas.App.Frontend.Pages
{
    public class DetailsPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        //public IEnumerable<Propietario> Propietarios {set;get;} 
        public Propietario Propietarios {set;get;}

        public DetailsPropietariosModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario = repositorioPropietario;
        }
        public IActionResult OnGet(int idPropietario)
        {
            Propietarios = repositorioPropietario.GetPropietario(idPropietario);
            if(Propietarios==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
