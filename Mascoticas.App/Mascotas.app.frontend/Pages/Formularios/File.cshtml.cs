using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.app.frontend.Pages
{
    public class ListModel : PageModel
    {
        private string [] formularios = {"formulario1","formulario 2","formulario3", "formulario4", "formulario5"};

        public List<string> ListaFormularios {get;set;}

        public void OnGet()
        {
            ListaFormularios= new List<string>();
            ListaFormularios.AddRange(formularios);
           
        }
    }
}