﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
    public partial class TipTalkEntities : DbContext
    {
        public TipTalkEntities()
            : base("name=TipTalkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CardMaster> CardMaster { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategotyToMaster> CategotyToMaster { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<MasterShift> MasterShift { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
