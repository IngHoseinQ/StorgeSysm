﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyproHQ.StorgeSysm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SyStorgeDataEntities : DbContext
    {
        public SyStorgeDataEntities()
            : base("name=SyStorgeDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Incoming> Incoming { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<Mechanisms> Mechanisms { get; set; }
        public virtual DbSet<Outgoing> Outgoing { get; set; }
        public virtual DbSet<STORAGE> STORAGE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<Compart> Compart { get; set; }
        public virtual DbSet<View> View { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
    }
}
