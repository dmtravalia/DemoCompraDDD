using AutoMapper;
using DemoCompra.Application.ViewModels;
using DemoCompra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
