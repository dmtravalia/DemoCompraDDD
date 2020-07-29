using AutoMapper;
using DemoCompra.Application.ViewModels;
using DemoCompra.Domain.Models;

namespace DemoCompra.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Compra, CompraViewModel>();
        }
    }
}
