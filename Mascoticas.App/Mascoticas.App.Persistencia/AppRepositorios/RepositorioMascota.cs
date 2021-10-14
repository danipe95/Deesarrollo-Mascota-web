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
       
        // List<Mascota> mascota;

        private readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
// /////////////////////////LISTAS/////////////////////////
        // public RepositorioMascota()
        // {

        //     mascota = new List<Mascota>()
        //     {
        //         new Mascota{Id=1, Nombre="firulais", Tipo="perro", Raza="Huzki", Propietario="Sara", Peso="30 kg",Temperatura="37°c", FrecuenciaCardiaca="baja", FrecuenciaRespiratoria="alta", EstadoAnimo="modo avion",Recomendaciones="mas croketas"},
        //         new Mascota{Id=2, Nombre="luka", Tipo="gato", Raza="mao", Propietario="Antonio",Peso="19 kg",Temperatura="39°c", FrecuenciaCardiaca="elevada", FrecuenciaRespiratoria="baja", EstadoAnimo="modo avion",Recomendaciones="penicilina"},
        //         new Mascota{Id=3, Nombre="piolin", Tipo="loro", Raza="australiano", Propietario="Carmen",Peso="60 gr",Temperatura="36°c", FrecuenciaCardiaca="normal", FrecuenciaRespiratoria="normal", EstadoAnimo="bueno", Recomendaciones="ninguna"}
        //         };
        // } 

// Adicionar MAscota
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionada= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }
        // public Mascota Add(Mascota nuevaMascota)
        // {
        //     nuevaMascota.Id = mascota.Max(r => r.Id)+1;
        //     mascota.Add(nuevaMascota);
        //     return nuevaMascota;
        // }
        // ////////////
        // Delete Mascota

        void IRepositorioMascota.DeleteMascota(int idMascota){
            var mascotaEncontrada= _appContext.Mascotas.FirstOrDefault(m => m.Id==idMascota);
            if(mascotaEncontrada==null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();    
        }
        
        // void IRepositorioMascota.DeleteMascota(int IdMascota)
        // {
        //     var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(c => c.Id == IdMascota);
        //     if (mascotaEncontrada == null)
        //         return;
        //     _appContext.Mascotas.Remove(mascotaEncontrada);
        //     _appContext.SaveChanges();
        // }

        // 
        // ///////

        

        // 
        // //////////
        // 
        // IEnumerable


        IEnumerable<Mascota> IRepositorioMascota.GetAllMascota()
        {
            return _appContext.Mascotas;
        }
        // public IEnumerable<Mascota> GetAll()
        // {
        //     return mascota;
        // }

        // IEnumerable<Mascota> IRepositorioMascota.GetAllM()
        // {
        //     return _appContext.Mascotas;
        // }


        // public Mascota GetMascota(int mascotica)
        // {
        //     return mascota.SingleOrDefault(m => m.Id==mascotica);
        // }


        Mascota IRepositorioMascota.GetMascota(int idMascota)      
        {
            return _appContext.Mascotas.FirstOrDefault(m => m.Id==idMascota);
        }
// Update
            Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
            {
                var mascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m => m.Id== mascota.Id);
                if (mascotaEncontrada!=null)
                {
                    mascotaEncontrada.Nombre = mascota.Nombre;
                    mascotaEncontrada.Tipo = mascota.Tipo;
                    mascotaEncontrada.Raza = mascota.Raza;
                    mascotaEncontrada.Propietario = mascota.Propietario;
                    mascotaEncontrada.Peso = mascota.Peso;
                    mascotaEncontrada.Temperatura = mascota.Temperatura;
                    mascotaEncontrada.FrecuenciaCardiaca = mascota.FrecuenciaCardiaca;
                    mascotaEncontrada.FrecuenciaRespiratoria = mascota.FrecuenciaRespiratoria;
                    mascotaEncontrada.Recomendaciones = mascota.Recomendaciones;
                    _appContext.SaveChanges();
                    
                }
                return mascotaEncontrada;
            }

// codigo viejo
        // public Mascota Update(Mascota mascotaActualizada)
        // {
        //     var mascotas= mascota.SingleOrDefault(r => r.Id==mascotaActualizada.Id);
        //     if (mascotas!=null)
        //     {   /*
        //     ___________________________________________________________
        //         Datos de mascota:
        //         IdMascota,Nombre,Tipo,Raza,Propietario,Peso,Temperatura,
        //         FrecuenciaCardiaca,FrecuenciaRespiratoria,
        //         EstadoAnimo,Recomendaciones
        //     ____________________________________________________________*/
        //         mascotas.Nombre = mascotaActualizada.Nombre;
        //         mascotas.Tipo = mascotaActualizada.Tipo;
        //         mascotas.Raza = mascotaActualizada.Raza;
        //         mascotas.Propietario = mascotaActualizada.Propietario;
        //         mascotas.Peso = mascotaActualizada.Peso;
        //         mascotas.Temperatura = mascotaActualizada.Temperatura;
        //         mascotas.FrecuenciaCardiaca = mascotaActualizada.FrecuenciaCardiaca;
        //         mascotas.FrecuenciaRespiratoria = mascotaActualizada.FrecuenciaRespiratoria;
        //         mascotas.Recomendaciones = mascotaActualizada.Recomendaciones;
        //     }
        //     return mascotas;
        }

    }
