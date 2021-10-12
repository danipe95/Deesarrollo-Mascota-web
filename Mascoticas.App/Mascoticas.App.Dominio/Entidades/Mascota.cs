using System;
using System.Collections.Generic;

namespace Mascoticas.App.Dominio
{
    public class Mascota
    {
        public int Id{get;set;}
        public string Nombre {get;set;}
        public string Tipo {get;set;}
        public string Raza {get;set;}
        public string Propietario {get;set;}
        public string Peso {get;set;}
        public string Temperatura {get;set;}
        public string FrecuenciaCardiaca {get;set;}
        public string FrecuenciaRespiratoria {get;set;}
        public string EstadoAnimo {get;set;}
        public string Recomendaciones {get;set;}
        public List<Visita> Visitas { get; set; }
    }
}