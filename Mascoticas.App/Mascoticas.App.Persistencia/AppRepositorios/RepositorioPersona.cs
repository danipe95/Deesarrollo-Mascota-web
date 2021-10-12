using System;
using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        /*datos persona:
        
        public RepositorioPersona(int id, String idPersona, String nombres, String apellidos, int celular, String email) 
        {
            this.Id = id;
                this.idPersona = idPersona;
                this.Nombres = nombres;
                this.Apellidos = apellidos;
                this.Celular = celular;
                this.Email = email;
               
        }
        int Id 
        String idPersona 
        String Nombres 
        String Apellidos
        int Celular 
        String Email         
        */

        //private readonly AppContext _appContext;

        /*public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }*/
        List<Persona> persona;
       
        public RepositorioPersona()
        {

            persona = new List<Persona>()
            {
                new Persona{Id=4, /*idPersona="primerapersona",*/ Nombres="Pedro", Apellidos="Mina", Celular="3101250", Email="PeMina@gmail.com"},
                new Persona{Id=5, /*idPersona="segundapersona",*/ Nombres="Jose", Apellidos="Martinez", Celular="3101250", Email="jmartinez1@hotmail.com"},
                new Persona{Id=6, /*idPersona="tercerapersona",*/ Nombres="Sofia", Apellidos="Garzon", Celular="3101250", Email="sofiG1@outlook.com"}
            };
        }
                                                                                                             
        /* METODOS TOMADOS DE MASCOTA POR SI FALLAN LOS DE ABAJO que tienen _appContext,
        
        public Propietario Add(Propietario propietario)
        {
            propietario.Id = propietario.Max(r => r.propietario)+1;
            propietarrio.Add(propietario);
            return propietario; 
            // se puede confundir la variable propietario que esta el List con la variable propietario que esta declarada en este metodo
        }

        public Persona Update(Persona nuevaPersona)
        {
            var PersonaEncontrada= persona.SingleOrDefault(p => p.Id == propietario.Id);
            if (PersonaEncontrada!=null)
            {  
                PersonaEncontrada.idPersona = persona.idPersona;
                PersonaEncontrada.Nombres = persona.Nombres;
                PersonaEncontrada.Apellidos = persona.Apellidos;
                PersonaEncontrada.Celular = persona.Celular;
                PersonaEncontrada.Email = persona.Email;
            }
            return PersonaEncontrada;
            
        }

        public Persona GetPersona(int IdPersona)
        {
            return persona.SingleOrDefault(m => m.Id==IdPersona);
        }

        public IEnumerable<Persona> GetAllPersona()
        {
            return persona;
        }

        */
        /*
        */

        public Persona AddPersona(Persona nuevaPersona)
        {
            nuevaPersona.Id = persona.Max(r => r.Id)+1;
            persona.Add(nuevaPersona);
            return nuevaPersona; 
        }

        public Persona UpdatePersona(Persona nuevaPersona)
        {
            var PersonaEncontrada= persona.SingleOrDefault(p => p.Id == nuevaPersona.Id);
            if (PersonaEncontrada!=null)
            {  
                PersonaEncontrada.idPersona = nuevaPersona.idPersona;
                PersonaEncontrada.Nombres = nuevaPersona.Nombres;
                PersonaEncontrada.Apellidos = nuevaPersona.Apellidos;
                PersonaEncontrada.Celular = nuevaPersona.Celular;
                PersonaEncontrada.Email = nuevaPersona.Email;
            }
            return PersonaEncontrada;            
        }

        public Persona GetPersona(int IdPersona)
        {
            return persona.SingleOrDefault(m => m.Id==IdPersona);
        }

        public IEnumerable<Persona> GetAllPersona()
        {
            return persona;
        }

        /*
        
        Persona IRepositorioPersona.AddPersona(Persona nuevaPersona)
        {
            var PersonaAdicionada = _appContext.Personas.Add(nuevaPersona);
            _appContext.SaveChanges();
            return PersonaAdicionada.Entity;
        }
        Persona IRepositorioPersona.UpdatePersona(Persona actualizarPersona)
        {
            var PersonaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if(PersonaEncontrada != null)
                {
                    PersonaEncontrada.idPersona = persona.idPersona;
                    PersonaEncontrada.Nombres = persona.Nombres;
                    PersonaEncontrada.Apellidos = persona.Apellidos;
                    PersonaEncontrada.Celular = persona.Celular;
                    PersonaEncontrada.Email = persona.Email;
                    _appContext.SaveChanges();
                }
                return PersonaEncontrada;
        }*/

        /*void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var PersonaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if(PersonaEncontrada == null)
                return;
            _appContext.Personas.Remove(PersonaEncontrada);
            _appContext.SaveChanges();
        }*/

        

        /*Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }*/

        

        /*IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Persona;
        }*/
        
    }
}