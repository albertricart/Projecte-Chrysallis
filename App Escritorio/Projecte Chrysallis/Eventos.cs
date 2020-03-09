//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
