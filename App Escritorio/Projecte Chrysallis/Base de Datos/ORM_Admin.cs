using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public static class ORM_Admin
    {
        //select
        public static List<Administradores> SelectAdmins()
        {
            List<Administradores> admins =
                (from a in ORM.bd.Administradores
                 select a).ToList();

            return admins;
        }

        public static Administradores SelectAdminByID(int id)
        {
            List<Administradores> admins =
                (from a in ORM.bd.Administradores
                        where a.id == id
                        select a).ToList();

            Administradores admin = admins[0];
            return admin;
        }

        //insert
        public static String InsertAdmin(string email, string contrasenya, bool superadmin)
        {
            String result = "";

            Administradores admin = new Administradores();
            admin.email = email;
            admin.contrasenya = encriptarContrasenya(contrasenya);
            admin.superadmin = superadmin;

            //Añadimos el admin a la base de datos
            ORM.bd.Administradores.Add(admin);

            //Recogemos el resultado del insert en forma de string
            result = ORM.SaveChanges();

            return result;
        }

        //update
        public static String UpdateAdmin(int id, string email, string contrasenya, bool superadmin)
        {
            String result = "";
            Administradores admin = ORM.bd.Administradores.Find(id);
            admin.email = email;
            admin.contrasenya = encriptarContrasenya(contrasenya);
            admin.superadmin = superadmin;

            result = ORM.SaveChanges();

            return result;
        }

        //delete
        public static String DeleteAdmin(Administradores admin)
        {
            String result = "";

            ORM.bd.Administradores.Remove(admin);

            result = ORM.SaveChanges();

            return result;
        }


        private static String encriptarContrasenya(string contrasenya)
        {
            String contrasenyaFinal = "";

            OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
            contrasenyaFinal = hash.Sha512(contrasenya);

            return contrasenyaFinal;
        }
    }
}
