﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finanzas.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FINANZASEntities : DbContext
    {
        public FINANZASEntities()
            : base("name=FINANZASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PagosMensuales> PagosMensuales { get; set; }
        public virtual DbSet<GastosVarios> GastosVarios { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Comprobantes> Comprobantes { get; set; }
        public virtual DbSet<AfipSueldo> AfipSueldo { get; set; }
    }
}
