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

            //no actualiza/funciona
            evento = _evento;

            //funciona y actualiza correctamente
            evento.fecha = _evento.fecha;
            evento.descripcion = _evento.descripcion;



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