﻿using DemoCompra.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCompra.Application.Interfaces
{
    public interface ICompraAppService
    {
        IEnumerable<CompraViewModel> ObterTodos();
        CompraViewModel ObterPorId(Guid id);
        void AdicionarCompra(CompraViewModel compra);
        void AtualizarCompra(CompraViewModel compra);
    }
}