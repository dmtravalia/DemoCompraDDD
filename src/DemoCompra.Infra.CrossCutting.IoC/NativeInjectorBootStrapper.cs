using DemoCompra.Application.Interfaces;
using DemoCompra.Application.Services;
using DemoCompra.Domain.Interfaces;
using DemoCompra.Infra.Data.Context;
using DemoCompra.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCompra.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //// Mediator
            //services.AddScoped<IMediatorHandler, MediatorHandler>();

            //// Domain
            services.AddScoped<ICompraAppService, CompraAppService>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<CompraContext>();

            ////CommandHandler
            //services.AddScoped<IRequestHandler<RegistrarContratoCommand, bool>, ContratoCommandHandler>();
        }
    }
}
