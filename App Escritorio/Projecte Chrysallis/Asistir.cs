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
    
    public partial class Asistir
    {
        public int idSocio { get; set; }
        public short idEvento { get; set; }
        public Nullable<byte> valoracion { get; set; }
        public string comentario { get; set; }
        public short numAsistentes { get; set; }
    
        public virtual Eventos Eventos { get; set; }
        public virtual Socios Socios { get; set; }
    }
}
