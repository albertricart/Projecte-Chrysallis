﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChrysallisEntities : DbContext
    {
        public ChrysallisEntities()
            : base("name=ChrysallisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administradores> Administradores { get; set; }
        public virtual DbSet<Asistir> Asistir { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Notificaciones> Notificaciones { get; set; }
        public virtual DbSet<Socios> Socios { get; set; }
        public virtual DbSet<Comunidades> Comunidades { get; set; }
    }
}
