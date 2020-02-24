using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public class ORM_Notificaciones
    {
        public static List<Notificaciones> SelectNotificacionesByEvento(int id)
        {
            List<Notificaciones> notificaciones = (from n in ORM.bd.Notificaciones where n.idEvento == id select n).ToList();
            return notificaciones;
        }
    }
}
