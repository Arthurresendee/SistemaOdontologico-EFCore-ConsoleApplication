﻿using DentiSys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DentiSys.Data
{
    public class DentiSysDataContext : DbContext
    {
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<PacienteProcedimento> PacienteProcedimentos { get; set; }
        public DbSet<PacientePlano> PacientePlanos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DentiSys_EF_ConsoleAplication;User ID=sa;Password=root; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Endereco>()
            Relacionamento
        }
    }
}
