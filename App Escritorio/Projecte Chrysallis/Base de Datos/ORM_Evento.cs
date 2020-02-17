using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public static class ORM_Evento
    {
        //Select
        public static List<Eventos> SelectEventos()
        {
            List<Eventos> eventos =
                (from e in ORM.bd.Eventos
                 select e).ToList();

            return eventos;
        }

        //Insert
        public static String InsertEvento(string titulo, DateTime fecha, string ubicacion, string descripcion,
                                                    DateTime fecha_limite, byte idComunidad, byte idAdmin)
        {
            String result = "";

            Eventos evento = new Eventos();
            evento.titulo = titulo;
            evento.fecha = fecha;
            evento.ubicacion = ubicacion;
            evento.descripcion = descripcion;
            evento.fecha_limite = fecha_limite;
            evento.idComunidad = idComunidad;
            evento.idAdmin = idAdmin;

            result = ORM.SaveChanges();

            return result;
        }

        //Update
        public static String UpdateEvento(int id, string titulo, DateTime fecha, string ubicacion,
                                                string descripcion, DateTime fecha_limite,
                                                       byte idComunidad, byte idAdmin)
        {
            String result = "";

            Eventos evento = ORM.bd.Eventos.Find(id);
            evento.titulo = titulo;
            evento.fecha = fecha;
            evento.ubicacion = ubicacion;
            evento.descripcion = descripcion;
            evento.fecha_limite = fecha_limite;
            evento.idComunidad = idComunidad;
            evento.idAdmin = idAdmin;

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
