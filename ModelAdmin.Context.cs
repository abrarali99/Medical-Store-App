﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdminEntities : DbContext
    {
        public AdminEntities()
            : base("name=AdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<information> information { get; set; }
        public virtual DbSet<profession> professions { get; set; }
        public virtual DbSet<register_user> register_user { get; set; }
        public virtual DbSet<Supplier_Master> Supplier_Master { get; set; }
    }
}