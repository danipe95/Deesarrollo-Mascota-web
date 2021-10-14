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
    public class FLisMascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        public IEnumerable<Mascota> Mascotas {get;set;} 

        public FLisMascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }

        public void OnGet()
        {           
            Mascotas = repositorioMascota.GetAll();
        }
        
    }
            }
