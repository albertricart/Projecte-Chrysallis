using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Chrysallis
{
    public class Evento
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha{ get; set; }
        public List<string> asistentes{ get; set; }

    }
}
