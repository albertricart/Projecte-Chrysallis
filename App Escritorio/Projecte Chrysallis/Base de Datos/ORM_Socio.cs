using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Socios> SelectSocioByComunidad(int idComunidad)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.idComunidad == idComunidad
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByID(int id)
        {
            List<Socios> socios = 
                (from s in ORM.bd.Socios
                 where s.id.ToString().Contains(id.ToString())
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByDNI(String DNI)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.dni.Contains(DNI)
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByNombre(String nombre)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.nombre.Contains(nombre)
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByApellidos(String apellidos)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.apellidos.Contains(apellidos)
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByEmail(String email)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.email.Contains(email)
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByTelefono(String telefono)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.telefono.ToString().Contains(telefono.ToString())
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByPoblacion(String poblacion)
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.poblacion.Contains(poblacion)
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByActivos()
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.activo==true
                 select s).ToList();

            return socios;
        }

        public static List<Socios> SelectSocioByNoActivos()
        {
            List<Socios> socios =
                (from s in ORM.bd.Socios
                 where s.activo == false
                 select s).ToList();

            return socios;
        }


        //------------------------------------------------
        //Insert
        public static String InsertSocio(Socios _socio)
        {
            String result = "";

            Socios socio = new Socios();
            socio.dni = _socio.dni;
            socio.nombre = _socio.nombre;
            socio.apellidos = _socio.apellidos;
            socio.email = _socio.email;
            socio.contrasenya = encriptarContrasesenya(_socio.contrasenya);
            socio.telefono = _socio.telefono;
            socio.poblacion = _socio.poblacion;
            socio.idComunidad = _socio.idComunidad;
            socio.Comunidades1 = _socio.Comunidades1;
            socio.activo = _socio.activo;

            ORM.bd.Socios.Add(socio);
            result = ORM.SaveChanges();

            return result;
        }
        //------------------------------------------------
        //Update
        public static String UpdateSocio(Socios _socio)
        {
            String result = "";

            Socios socio =  (Socios) ORM.bd.Socios.Find(_socio.id);

            socio.nombre = _socio.nombre;
            socio.apellidos = _socio.apellidos;
            socio.dni = _socio.dni;
            socio.email = _socio.email;
            socio.contrasenya = encriptarContrasesenya(_socio.contrasenya);
            socio.telefono = _socio.telefono;
            socio.poblacion = _socio.poblacion;
            socio.idComunidad = _socio.idComunidad;
            socio.Comunidades1 = _socio.Comunidades1;
            socio.activo = _socio.activo;

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
            string contrasenyaFinal = "";

            OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
            contrasenyaFinal = hash.Sha512(contrasenya);

            return contrasenyaFinal;
        }
    }
}
