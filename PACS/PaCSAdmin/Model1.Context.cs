﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaCS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pacsEntities : DbContext
    {
        public pacsEntities()
            : base("name=pacsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<pacs_function> pacs_function { get; set; }
        public DbSet<pacs_log> pacs_log { get; set; }
        public DbSet<pacs_role> pacs_role { get; set; }
        public DbSet<pacs_role_function> pacs_role_function { get; set; }
        public DbSet<pacs_user> pacs_user { get; set; }
    }
}
