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
    public class FLisVisitasModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        public IEnumerable<Visita> Visitas {get;set;} 

        public FLisVisitasModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }
        public void OnGet()
        {           
            Visitas = repositorioVisita.GetAllVisita();
        }
        
    }
}
