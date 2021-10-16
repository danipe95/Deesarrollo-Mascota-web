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
    public class FLisPropietariosModel : PageModel
    {
    private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> Propietarios {get;set;} 
        public FLisPropietariosModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new Mascoticas.App.Persistencia.AppRepositorios.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {           
            Propietarios = repositorioPropietario.GetAllPropietario();
        }
        
    }
}

    

