﻿using ContasApp.Data.Configurations;
using ContasApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasApp.Data.Context
{
    //Regra 1: Herdar a classe DbContext
    public class DataContext : DbContext
    {
        //Regra 2: Sobrescrever o método OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //definindo o tipo de banco de dados do projeto

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDContasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        
        //Regra 3: Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de configuração criada no projeto
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
      
        //Regra 4: Mapear cada entidade do projeto através do DbSet
        public DbSet<Categoria>? Categoria { get; set; }
        public DbSet<Conta>? Conta { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
    }
}

