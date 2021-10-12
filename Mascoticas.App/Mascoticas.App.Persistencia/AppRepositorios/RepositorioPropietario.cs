using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {

        List<Propietario> propietario;

        /*private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }*/
        
        public RepositorioPropietario()
        {

            propietario = new List<Propietario>()
            {
                new Propietario{/*Id=1,Nombres="Maria", Apellidos="Arias", Celular=3101240001, Email="MarArias@gmail.com",*/ Direccion = "calle 1 12-11"},
                new Propietario{/*Id=2,Nombres="Daniel", Apellidos="Martinez", Celular=3101240002, Email="Dmartinez1@hotmail.com",*/ Direccion ="calle 10 20-50"},
                new Propietario{/*Id=3,Nombres="Alejandra", Apellidos="Garzon", Celular=3101240003, Email="alejaG1@outlook.com",*/ Direccion ="calle siempreviva 123"}
                };
        }

        public Propietario AddPropietario(Propietario npropietario)
        {
            npropietario.Id = propietario.Max(r => r.Id)+1;
            propietario.Add(npropietario);
            return npropietario;
        }

        public Propietario UpdatePropietario(Propietario propietarioA)
        {
            var PropietarioEncontrado= propietario.SingleOrDefault(v => v.Id == propietarioA.Id);
            if (PropietarioEncontrado!=null)
            {  
                PropietarioEncontrado.Direccion = propietarioA.Direccion;
            }
            return PropietarioEncontrado;
        }

        public IEnumerable<Propietario> GetAllPropietarios()
        {
            return propietario;
        }

        public Propietario GetPropietario(int idPropietario)
        {
            return propietario.SingleOrDefault(m => m.Id==idPropietario);
        }

        /* METODOS TOMADOS DE MASCOTA POR SI FALLAN LOS DE ABAJO que tienen _appContext,
        
        public Propietario Add(Propietario propietario)
        {
            propietario.Id = propietario.Max(r => r.propietario)+1;
            propietarrio.Add(propietario);
            return propietario; 
            // se puede confundir la variable propietario que esta el List con la variable propietario que esta declarada en este metodo
        }

        public Veterinario Update(Propietario propietario)
        {
            var PropietarioEncontrado= propietario.SingleOrDefault(p => p.Id == propietario.Id);
            if (veterinarioEncontrado!=null)
            {  
                PropietarioEncontrado.idPersona = propietario.idPersona;
                PropietarioEncontrado.Nombres = propietario.Nombres;
                PropietarioEncontrado.Apellidos = propietario.Apellidos;
                PropietarioEncontrado.Celular = propietario.Celular;
                PropietarioEncontrado.Email = propietario.Email;
            }
            return PropietarioEncontrado;
            // se puede confundir la variable propietario que esta el List con la variable propietario que esta declarada en este metodo
        }

        public Propietario GetPropietario(int idPersona)
        {
            return mascota.SingleOrDefault(m => m.Id==idPersona);
        }

        public IEnumerable<Propietario> GetAllPropietarios()
        {
            return propietario;
        }

        */

        /*Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var PropietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return PropietarioAdicionado.Entity;
        }
        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if(PropietarioEncontrado != null)
                {
                    PropietarioEncontrado.idPersona = propietario.idPersona;
                    PropietarioEncontrado.Nombres = propietario.Nombres;
                    PropietarioEncontrado.Apellidos = propietario.Apellidos;
                    PropietarioEncontrado.Celular = propietario.Celular;
                    PropietarioEncontrado.Email = propietario.Email;
                    _appContext.SaveChanges();
                }
                return PropietarioEncontrado;
        }
        void IRepositorioPropietario.DeletePropietario(int idPersona)
        {
            var PropietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == idPersona);
            if(PropietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(PropietarioEncontrado);
            _appContext.SaveChanges();
        }
        
        Propietario IRepositorioPropietario.GetPropietario(int idPersona)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == idPersona);
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }*/
    }
}
