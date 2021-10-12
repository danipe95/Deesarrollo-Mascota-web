using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {

       /* private readonly AppContext _appContext;
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }*/
        
        List<Veterinario> veterinario;

        public RepositorioVeterinario()
        {

            veterinario = new List<Veterinario>()
            {
                new Veterinario{Id=1,Nombres="Juan", Apellidos="Perez", Celular="3101230000", Email="JPerez@MascotCracks.com", TarjetaProfesional=1001},
                new Veterinario{Id=2,Nombres="Pepito", Apellidos="Gomez", Celular="3101230001", Email="pepiGomez@MascotCracks.com", TarjetaProfesional=1002},
                new Veterinario{Id=3,Nombres="Ana", Apellidos="Lopez", Celular="3101230002", Email="AnitaLopez@MascotCracks.com", TarjetaProfesional=1003 }
                };
        }
        
        /* METODOS TOMADOS DE MASCOTA POR SI FALLAN LOS DE ABAJO que tienen _appContext,
        
        public Veterinario AddVeterinario(Veterinario nuevoVeterinario)
        {
            nuevoVeterinario.Id = veterinario.Max(r => r.nuevoVeterinario)+1;
            veterinario.Add(nuevoVeterinario);
            return nuevoVeterinario;
        }

        public Veterinario UpdateVeterinario(Veterinario veterinarioActualizado)
        {
            var veterinarioEncontrado= veterinario.SingleOrDefault(v => v.idPersona == veterinarioActualizado.idPersona);
            if (veterinarioEncontrado!=null)
            {  
                veterinarioEncontrado.idPersona = veterinario.idPersona;
                veterinarioEncontrado.Nombres = veterinario.Nombres;
                veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                veterinarioEncontrado.Celular = veterinario.Celular;
                veterinarioEncontrado.Email = veterinario.Email;
            }
            return veterinarioEncontrado;
        }


        */

        public Veterinario AddVeterinario(Veterinario nuevoVeterinario)
        {
            nuevoVeterinario.Id = veterinario.Max(r => r.Id)+1;
            veterinario.Add(nuevoVeterinario);
            return nuevoVeterinario;
        }

        public Veterinario UpdateVeterinario(Veterinario veterinarioActualizado)
        {
            var veterinarioEncontrado= veterinario.SingleOrDefault(v => v.Id == veterinarioActualizado.Id);
            if (veterinarioEncontrado!=null)
            {  
                veterinarioEncontrado.TarjetaProfesional = veterinarioActualizado.TarjetaProfesional;
            }
            return veterinarioEncontrado;
        }

        /*
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario nuevoVeterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(nuevoVeterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }*/

        /*Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinarioActualizado)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioActualizado.Id);
            if (veterinarioEncontrado != null)
                {
                    veterinarioEncontrado.idPersona = veterinario.idPersona;
                    veterinarioEncontrado.Nombres = veterinario.Nombres;
                    veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                    veterinarioEncontrado.Celular = veterinario.Celular;
                    veterinarioEncontrado.Email = veterinario.Email;
                    veterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;

                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int IdVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(vt => vt.Id == IdVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int IdVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(vet => vet.Id == IdVeterinario);
        } 

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAll()
        {
            return _appContext.Veterinarios;
        }*/
        public IEnumerable<Veterinario> GetAll()
        {
            return veterinario;
        }
        public Veterinario GetVeterinarioPorId(int veterinarioId)      
        {
            return veterinario.SingleOrDefault(m => m.Id==veterinarioId);
        }
    }
}