using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCompra.Domain.Interfaces
{
    public interface ICompraRepository : IRepository<Compra>
    {
        IEnumerable<Compra> ObterTodos();
        Compra ObterPorId(Guid id);


        void Adicionar(Compra compra);

        void Atualizar(Compra compra);
    }
}
