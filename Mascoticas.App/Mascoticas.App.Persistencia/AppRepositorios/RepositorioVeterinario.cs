using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
    private readonly AppContext _appContext;
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinario.Id);
            if (veterinarioEncontrado != null)
                {
                    veterinarioEncontrado.idPersona = veterinario.idPersona;
                    veterinarioEncontrado.Nombres = veterinario.Nombres;
                    veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                    veterinarioEncontrado.Celular = veterinario.Celular;
                    veterinarioEncontrado.Email = veterinario.Email;

                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int idPersona)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(vt => vt.Id == idPersona);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int idPersona)
        {
            return _appContext.Veterinarios.FirstOrDefault(vet => vet.Id == idPersona);
        } 

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAll()
        {
            return _appContext.Veterinarios;
        }
    }
}