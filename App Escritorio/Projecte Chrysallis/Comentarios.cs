//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projecte_Chrysallis
{
    using System;
    using System.Collections.Generic;

    public partial class Comentarios
    {
        public short idEvento { get; set; }
        public int idSocio { get; set; }
        public int id { get; set; }
        public bool mostrarNombre { get; set; }
        public System.DateTime fecha { get; set; }
        public bool activo { get; set; }
        public string body { get; set; }

        public virtual Eventos Eventos { get; set; }
        public virtual Socios Socios { get; set; }
    }

}