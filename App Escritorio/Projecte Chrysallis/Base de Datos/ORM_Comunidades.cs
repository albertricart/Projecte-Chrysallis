using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    class ORM_Comunidades
    {
        //select
        public static List<Comunidades> SelectComunidades()
        {
            List<Comunidades> comunidades =
                (from c in ORM.bd.Comunidades
                 select c).ToList();

            return comunidades;
        }

        public static List<Comunidades> SelectComunidadesByAdmin()
        {
            List<Comunidades> comunidades =
                (from c in ORM.bd.Comunidades
                 select c).ToList();

            return comunidades;
        }
    }
}
