using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{

    public static class ORM_Socio
    {
        //Selects
        public static List<Socios> SelectSocios()
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 select s).ToList();

            return socios;
        }

        public static Socios SelectSocioByID(int id)
        {
            List<Socios> socios = 
                (from s in ORM.bd.Socios
                 where s.id == id
                 select s).ToList();

            Socios socio = socios[0];
            return socio;
        }
        //------------------------------------------------
        //Insert
        public static String InsertSocio(string dni, string nombre, string apellidos, string email,
                                                string contrasenya, string telefono, string poblacion,
                                                      byte idComunidad, bool activo)
        {
            String result = "";

            Socios socio = new Socios();
            socio.dni = dni;
            socio.nombre = nombre;
            socio.apellidos = apellidos;
            socio.email = email;
            socio.contrasenya = encriptarContrasesenya(contrasenya);
            socio.telefono = telefono;
            socio.poblacion = poblacion;
            socio.idComunidad = idComunidad;
            socio.activo = activo;

            result = ORM.SaveChanges();

            return result;
        }
        //------------------------------------------------
        //Update
        public static String UpdateSocio(int id, string dni, string nombre, string apellidos,
                                                string email, string contrasenya, string telefono,
                                                    string poblacion, byte idComunidad, bool activo)
        {
            String result = "";

            Socios socio = ORM.bd.Socios.Find(id);

            socio.dni = dni;
            socio.nombre = nombre;
            socio.apellidos = apellidos;
            socio.email = email;
            socio.contrasenya = contrasenya;
            socio.telefono = telefono;
            socio.poblacion = poblacion;
            socio.idComunidad = idComunidad;
            socio.activo = activo;

            result = ORM.SaveChanges();

            return result;
        }
        //------------------------------------------------
        //Delete
        public static String DeleteSocio(Socios socio)
        {
            String result = "";

            ORM.bd.Socios.Remove(socio);

            result = ORM.SaveChanges();

            return result;
        }

        private static string encriptarContrasesenya(string contrasenya)
        {
            String contrasenyaFinal = "";

            OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
            contrasenyaFinal = hash.Sha512(contrasenya);

            return contrasenyaFinal;
        }
    }
}
