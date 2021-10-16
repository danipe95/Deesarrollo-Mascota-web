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
    public class EditPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        [BindProperty]
        public Propietario Propietarios {get;set;}

        public EditPropietariosModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new Mascoticas.App.Persistencia.AppRepositorios.AppContext());
        }
                public IActionResult OnGet(int? propietarioId)
        {
            if (propietarioId.HasValue)
            {
                Propietarios = repositorioPropietario.GetPropietario(propietarioId.Value);
            }
            else
            {
                Propietarios= new Propietario();
            }
            if (Propietarios == null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                if (Propietario.Id>0)
                {
                    Propietarios= repositorioPropietario.UpdatePropietario(Propietarios);
                }
                else
                {
                    repositorioPropietario.AddPropietario(Propietarios);
                }
                return Page();
        }
    }
}

 
