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

    public partial class Eventos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eventos()
        {
            this.Asistir = new HashSet<Asistir>();
            this.Documentos = new HashSet<Documentos>();
            this.Notificaciones = new HashSet<Notificaciones>();
            this.Comentarios = new HashSet<Comentarios>();
        }

        public short id { get; set; }
        public string titulo { get; set; }
        public System.DateTime fecha { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_limite { get; set; }
        public byte idComunidad { get; set; }
        public byte idAdmin { get; set; }
        public double valoracionMedia { get; set; }

        public virtual Administradores Administradores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistir> Asistir { get; set; }
        public virtual Comunidades Comunidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios> Comentarios { get; set; }
    }

}