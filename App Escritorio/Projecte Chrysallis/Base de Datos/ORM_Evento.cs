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
            List<Eventos> eventos =
                (from e in ORM.bd.Eventos
                 select e).ToList();

            return eventos;
        }

        public static Eventos SelectEventoByID(int id)
        {
            List<Eventos> eventos =
                (from e in ORM.bd.Eventos
                 where e.id == id
                 select e).ToList();

            Eventos evento = eventos[0];
            return evento;
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

            Eventos evento = ORM.bd.Eventos.Find(_evento.id);
            evento = _evento;

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