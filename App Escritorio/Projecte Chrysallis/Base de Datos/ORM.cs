using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public static class ORM
    {
        //LINQ

        public static ChrysallisEntities bd = new ChrysallisEntities();

        public static String SaveChanges()
        {
            String mensaje = "";

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                ORM.RejectChanges();

                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(sqlEx);
            }

            return mensaje;
        }

        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: break;
                }
            }
        }

        private static string MensajeError(SqlException sqlEx)
        {
            string mensaje = "";

            switch (sqlEx.Number)
            {
                case -1:
                    mensaje = "Error de conexión con el servidor";
                    break;
                case 547:
                    mensaje = "Tiene datos relacionados";
                    break;
                case 2601:
                case 2627:
                    mensaje = "Tiene datos duplicados";
                    break;
                case 4060:
                    mensaje = "No se encuentra la base de datos";
                    break;
                case 18456:
                    mensaje = "Usuario o contraseña incorrectos";
                    break;
                default:
                    mensaje = "(" + sqlEx.Number + ") " + sqlEx.Message;
                    break;
            }

            return mensaje;
        }
    }
}
