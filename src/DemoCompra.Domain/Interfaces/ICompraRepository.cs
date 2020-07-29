using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCompra.Domain.Interfaces
{
    public interface ICompraRepository : IRepository<Compra>
    {
        Task<IEnumerable<Compra>> ObterTodos();
        Task<Compra> ObterPorId(Guid id);


        void Adicionar(Compra compra);

        void Atualizar(Compra compra);
    }
}
