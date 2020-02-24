using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis.Base_de_Datos
{
    public class ORM_Documentos
    {
        //Select
        public static List<Documentos> SelectDocumentosByEvento(int id)
        {
            List<Documentos> documentos =
                (from d in ORM.bd.Documentos where d.idEvento == id
                 select d).ToList();

            return documentos;
        }
    }
}
