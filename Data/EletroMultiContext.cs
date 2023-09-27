﻿using EletroMultiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EletroMultiAPI.Data
{
    public class EletroMultiContext:DbContext
    {
        public EletroMultiContext(DbContextOptions<EletroMultiContext> opts):base(opts)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
    }
}