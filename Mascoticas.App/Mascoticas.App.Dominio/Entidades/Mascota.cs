using System;
namespace Mascoticas.App.Dominio
{
    public class Mascota
    {
        public int Id{get;set;}
        public String Nombre {get;set;}
        public String Tipo {get;set;}
        public String Raza {get;set;}
        public int IdPropietario{get;set;}
        public String Peso  {get;set;}
        public String Temperatura {get;set;}
        public String FrecuenciaCardiaca {get;set;}
        public String FrecuenciaRespiratoria {get;set;}
        public String EstadoAnimo {get;set;}
        public String Recomendaciones {get;set;}
    }
}