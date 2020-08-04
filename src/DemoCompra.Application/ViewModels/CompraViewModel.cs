using System;

namespace DemoCompra.Application.ViewModels
{
    public class CompraViewModel
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
    }
}
