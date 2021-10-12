using System;
using System.Collections.Generic;

namespace Mascoticas.App.Dominio
{
    public class Propietario: Persona
    {
        public string Direccion {get;set;}
        public List<Mascota> Mascotas {get;set;}
    }
}