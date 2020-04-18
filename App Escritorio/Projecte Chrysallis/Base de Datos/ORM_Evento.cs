using System;
using System.Collections.Generic;
using System.Linq;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public static class ORM_Evento
    {
        //Select
        public static List<Eventos> SelectEventos()
        {
            List<Eventos> _eventos =
                (from e in ORM.bd.Eventos
                 select e).ToList();

            return _eventos;
        }

        //Select
        public static List<Eventos> SelectEventosByNombre(String nombre)
        {
            List<Eventos> _eventos =
                (from e in ORM.bd.Eventos
                 where e.titulo.Contains(nombre) 
                 select e).ToList();

            return _eventos;
        }

        //Select
        public static List<Eventos> SelectEventosByUbicacion(String ubicacion)
        {
            List<Eventos> _eventos =
                (from e in ORM.bd.Eventos
                 where e.ubicacion.Contains(ubicacion)
                 select e).ToList();

            return _eventos;
        }

        //Select
        public static List<Eventos> SelectEventosByComunidad(int id)
        {
            List<Eventos> _eventos =
                (from e in ORM.bd.Eventos
                 where e.idComunidad==id
                 select e).ToList();

            return _eventos;
        }


        //Insert
        public static String InsertEvento(Eventos evento)
        {
            String result = "";

            ORM.bd.Eventos.Add(evento);
            result = ORM.SaveChanges();

            return result;
        }

        //Update
        public static String UpdateEvento(Eventos _evento)
        {
            String result = "";

            Eventos evento = (Eventos) ORM.bd.Eventos.Find(_evento.id);

            evento.titulo = _evento.titulo;
            evento.ubicacion = _evento.ubicacion;
            evento.fecha_limite = _evento.fecha_limite;
            evento.fecha = _evento.fecha;
            evento.descripcion = _evento.descripcion;
            evento.Documentos = _evento.Documentos;
            evento.Notificaciones = _evento.Notificaciones;
            evento.idComunidad = _evento.idComunidad;
            evento.descripcion = _evento.descripcion;

            if (!Formularios.FormLogin.adminLogeado.superadmin)
            {
                evento.idAdmin = _evento.idAdmin;
            }



            result = ORM.SaveChanges();
            return result;
        }

        //Delete
        public static String DeleteEvento(Eventos evento)
        {
            String result = "";

            ORM.bd.Eventos.Remove(evento);
            result = ORM.SaveChanges();
            return result;
        }

    }
}