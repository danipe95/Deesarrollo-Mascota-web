using System;
using System.Collections.Generic;
using System.Linq;
using Mascoticas.App.Dominio;

namespace Mascoticas.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
         /* Datos de mascota
        IdMascota,Nombre,Tipo,Raza,Propietario,Peso,Temperatura,
        FrecuenciaCardiaca,FrecuenciaRespiratoria,
        EstadoAnimo,Recomendaciones*/
        List<Mascota> mascota;

        // private readonly AppContext _appContext;

        // public RepositorioMascota(AppContext appContext)
        // {
        //     _appContext = appContext;
        // }

        public RepositorioMascota()
        {

            mascota = new List<Mascota>()
            {
                new Mascota{Id=1, Nombre="firulais", Tipo="perro", Raza="Huzki", /*Propietario=Daniel,*/Peso="30 kg",Temperatura="37°c", FrecuenciaCardiaca="baja", FrecuenciaRespiratoria="alta", EstadoAnimo="modo avion",Recomendaciones="mas croketas"},
                new Mascota{Id=2, Nombre="luka", Tipo="gato", Raza="mao", /*Propietario="Amelia",*/Peso="19 kg",Temperatura="39°c", FrecuenciaCardiaca="elevada", FrecuenciaRespiratoria="baja", EstadoAnimo="modo avion",Recomendaciones="penicilina"},
                new Mascota{Id=3, Nombre="piolin", Tipo="loro", Raza="australiano", /*Propietario="Katherine",*/Peso="60 gr",Temperatura="36°c", FrecuenciaCardiaca="normal", FrecuenciaRespiratoria="normal", EstadoAnimo="bueno", Recomendaciones="ninguna"}
                };
        }

        public Mascota Add(Mascota nuevaMascota)
        {
            nuevaMascota.Id = mascota.Max(r => r.Id)+1;
            mascota.Add(nuevaMascota);
            return nuevaMascota;
        }

        public Mascota Update(Mascota mascotaActualizada)
        {
            var mascotas= mascota.SingleOrDefault(r => r.Id==mascotaActualizada.Id);
            if (mascotas!=null)
            {   /*
            ___________________________________________________________
                Datos de mascota:
                IdMascota,Nombre,Tipo,Raza,Propietario,Peso,Temperatura,
                FrecuenciaCardiaca,FrecuenciaRespiratoria,
                EstadoAnimo,Recomendaciones
            ____________________________________________________________*/
                mascotas.Nombre = mascotaActualizada.Nombre;
                mascotas.Tipo = mascotaActualizada.Tipo;
                mascotas.Raza = mascotaActualizada.Raza;
                //mascota.Propietario = mascotaActualizada.Propietario;
                mascotas.Peso = mascotaActualizada.Peso;
                mascotas.Temperatura = mascotaActualizada.Temperatura;
                mascotas.FrecuenciaCardiaca = mascotaActualizada.FrecuenciaCardiaca;
                mascotas.FrecuenciaRespiratoria = mascotaActualizada.FrecuenciaRespiratoria;
                mascotas.Recomendaciones = mascotaActualizada.Recomendaciones;
            }
            return mascotas;
        }

        // void IRepositorioMascota.DeleteMascota(int IdMascota)
        // {
        //     var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(c => c.Id == IdMascota);
        //     if (mascotaEncontrada == null)
        //         return;
        //     _appContext.Mascotas.Remove(mascotaEncontrada);
        //     _appContext.SaveChanges();
        // }

        public IEnumerable<Mascota> GetAllM()
        {
            return mascota;
        }

        // IEnumerable<Mascota> IRepositorioMascota.GetAllM()
        // {
        //     return _appContext.Mascotas;
        // }


        public Mascota GetMascotaId(int mascotaId)
        {
            return mascota.SingleOrDefault(m => m.Id==mascotaId);
        }

    }
}