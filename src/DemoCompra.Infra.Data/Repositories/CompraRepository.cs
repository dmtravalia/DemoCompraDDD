﻿using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Interfaces;
using DemoCompra.Domain.Models;
using DemoCompra.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCompra.Infra.Data.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private readonly CompraContext _context;

        public CompraRepository(CompraContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Compra>> ObterTodos()
        {
            return await _context.Compras.AsNoTracking().ToListAsync();
        }

        public async Task<Compra> ObterPorId(Guid id)
        {
            return await _context.Compras.FindAsync(id);
        }

        public void Adicionar(Compra compra)
        {
            _context.Compras.Add(compra);
        }

        public void Atualizar(Compra compra)
        {
            _context.Compras.Update(compra);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
