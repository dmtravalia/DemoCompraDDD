using AutoMapper;
using DemoCompra.Application.ViewModels;
using DemoCompra.Domain.Models;

namespace DemoCompra.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CompraViewModel, Compra>()
                .ConstructUsing(c =>
                    new Compra(c.Quantidade, c.Descricao));

        }
    }
}
