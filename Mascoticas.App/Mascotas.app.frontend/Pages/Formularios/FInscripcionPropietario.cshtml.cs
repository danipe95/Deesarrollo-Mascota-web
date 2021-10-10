using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.app.frontend.pages
{
    public class FInscripcionPropietarioModel : PageModel
    {
        
        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> Propietarios {set;get;}
        
        public FInscripcionPropietarioModel()
        {
            this.repositorioPropietario=new RepositorioPropietario(new Mascoticas.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Propietarios = repositorioPropietario.GetAllPropietarios();
        }        
    }
}
