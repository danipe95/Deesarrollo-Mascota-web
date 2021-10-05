using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;


namespace Mascoticas.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        ///<Sumary>
        ///
        ///<Sumary>
        private readonly AppContext _AppContext;
        ///<Sumary>
        ///
        ///<Sumary>
        public RepositorioMascota(AppContext appContext)
        {
            _AppContext = appContext;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var MascotaAdicionada = _AppContext.Mascotas.Add(mascota);
            _AppContext.Save.changes();
            return MascotaAdicionada.Entity;
        }
        void IRepositorioMascota.DeleteMascota(int IdMascota)
        {
            var MascotaEncontrada = _AppContext.Mascotas.FirstOrDefault(m => p.Id == IdMascota);
            if (MascotaEncontrada == null)
                return;
            _AppContext.Mascotas.Remove(MascotaEncontrada);
            _AppContext.SaveChanges();
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _AppContext.Mascotas.FirstOrDefault(m => p.Id == IdMascota);
        }
        Mascota IRepositorioMascota.GetMascota(int IdMascota)
        {
            return _AppContext.Mascotas.FirstOrDefault(m => p.Id == IdMascota);
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var MascotaEncontrada = _AppContext.Mascotas.FirstOrDefault(m => p.Id == Mascota.Id);
            if(MascotaEncontrada!=null)
            {
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Tipo=Mascota.Tipo;
                MascotaEncontrada.Raza=Mascota.Raza;
                MascotaEncontrada.Propietario=Mascota.Propietario;
                MascotaEncontrada.Peso=Mascota.Peso;
                MascotaEncontrada.Temperatura=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
                MascotaEncontrada.Nombre=Mascota.Nombre;
            }
        }
    }
}
