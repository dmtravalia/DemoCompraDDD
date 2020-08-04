using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Models;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DemoCompra.Infra.Data.Context
{
    public class CompraContext : DbContext, IUnitOfWork
    {
        public CompraContext(DbContextOptions<CompraContext> options) : base(options)
        {
        }

        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompraContext).Assembly);
        }

        public bool Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges() > 0;
        }
    }
}
