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
    
    public partial class Socios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Socios()
        {
            this.Asistir = new HashSet<Asistir>();
            this.Comentarios = new HashSet<Comentarios>();
            this.Comunidades1 = new HashSet<Comunidades>();
        }
    
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string contrasenya { get; set; }
        public int telefono { get; set; }
        public string poblacion { get; set; }
        public byte idComunidad { get; set; }
        public bool activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistir> Asistir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual Comunidades Comunidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comunidades> Comunidades1 { get; set; }
    }
}
