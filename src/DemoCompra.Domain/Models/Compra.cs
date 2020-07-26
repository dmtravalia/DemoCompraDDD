using DemoCompra.Domain.Core.Interfaces;
using DemoCompra.Domain.Core.Models;
using DemoCompra.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCompra.Domain.Models
{
    public class Compra : Entity, IAggregateRoot
    {
        public Compra(int quantidade, string descricao)
        {
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public int Quantidade { get; private set; }
        public string Descricao { get; private set; }
    }
}
