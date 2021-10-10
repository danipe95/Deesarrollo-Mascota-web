using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascoticas.App.Dominio;
using Mascoticas.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.app.frontend.pages
{
    public class FVisitaVeterinarioModelModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinarios {get;set;} 

        public  FVisitaVeterinarioModelModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new Mascoticas.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Veterinarios = repositorioVeterinario.GetAll();
        }
    }
}
