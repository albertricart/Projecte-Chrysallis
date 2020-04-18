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

        public static List<Administradores> SelectAdminsByNombre(String nombre)
        {
            List<Administradores> admins =
                (from a in ORM.bd.Administradores
                 where a.nombre.Contains(nombre)
                 select a).ToList();

            return admins;
        }

        public static List<Administradores> SelectAdminsByApellidos(String apellidos)
        {
            List<Administradores> admins =
                (from a in ORM.bd.Administradores
                 where a.apellidos.Contains(apellidos)
                 select a).ToList();

            return admins;
        }

        public static List<Administradores> SelectAdminsByEmail(String email)
        {
            List<Administradores> admins =
                (from a in ORM.bd.Administradores
                 where a.email.Contains(email)
                 select a).ToList();

            return admins;
        }

        public static List<Administradores> SelectAdminsByComunidad(String nomComunidad)
        {
            Comunidades comunidad = (from c in ORM.bd.Comunidades
                                     where c.nombre.Contains(nomComunidad)
                                     select c).First();

            List<Administradores> administradores = (from a in ORM.bd.Administradores
                                                     where a.Comunidades.Contains(comunidad)
                                                     select a).ToList();
            

            return administradores;
        }

        public static Administradores SelectAdminLogin(String email, String pw)
        {
            Administradores admin = null;
            String password = encriptarContrasenya(pw);
            try
            {
                admin = (from a in ORM.bd.Administradores
                 where a.email.Equals(email) && a.contrasenya.Equals(password)
                 select a).First();
            }
            catch(InvalidOperationException){}

            return admin;
        }

        //insert
        public static String InsertAdmin(Administradores _admin)
        {
            String result = "";

            Administradores admin = new Administradores();
            admin.nombre = _admin.nombre;
            admin.apellidos = _admin.apellidos;
            admin.email = _admin.email;
            admin.contrasenya = encriptarContrasenya(_admin.contrasenya);
            admin.superadmin = _admin.superadmin;
            admin.Comunidades = _admin.Comunidades;

            //Añadimos el admin a la base de datos
            ORM.bd.Administradores.Add(admin);

            //Recogemos el resultado del insert en forma de string
            result = ORM.SaveChanges();

            return result;
        }

        //update
        public static String UpdateAdmin(Administradores _admin)
        {
            String result = "";
            Administradores admin = ORM.bd.Administradores.Find(_admin.id);
            
            admin.nombre = _admin.nombre;
            admin.apellidos = _admin.apellidos;
            admin.email = _admin.email;
            admin.contrasenya = encriptarContrasenya(_admin.contrasenya);
            admin.superadmin = _admin.superadmin;
            admin.Comunidades = _admin.Comunidades;
            

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
