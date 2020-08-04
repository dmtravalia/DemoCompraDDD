using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Core.Models;
using System;

namespace DemoCompra.Domain.Models
{
    public class Compra : Entity, IAggregateRoot
    {
        public Compra(Guid id, int quantidade, string descricao)
        {
            Id = id;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public int Quantidade { get; private set; }
        public string Descricao { get; private set; }
    }
}
