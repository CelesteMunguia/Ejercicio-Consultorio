﻿using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos
{
    public class ConsultorioContext: DbContext
    {
        public ConsultorioContext() : base("Consultorio")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<MMedico> MMedico { get; set; }
        public DbSet<MPaciente> MPaciente { get; set; }
        public DbSet<MCita> MCita { get; set; }
    }
}
