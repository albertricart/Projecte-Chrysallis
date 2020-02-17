using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{

    public static class ORM_Socio
    {

        //Select
        public static List<Socios> SelectSocios()
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 select s).ToList();

            return socios;
        }

        //Insert
        public static String InsertSocio(string dni, string nombre, string apellidos, string email,
                                                string contrasenya, string telefono, string poblacion,
                                                      byte idComunidad, bool activo)
        {
            /*        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string contrasenya { get; set; }
        public string telefono { get; set; }
        public string poblacion { get; set; }
        public byte idComunidad { get; set; }
        public bool activo { get; set; }*/
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
