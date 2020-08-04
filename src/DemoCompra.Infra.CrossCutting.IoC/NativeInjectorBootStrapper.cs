using DemoCompra.Application.Interfaces;
using DemoCompra.Application.Services;
using DemoCompra.Application.Validators;
using DemoCompra.Application.ViewModels;
using DemoCompra.Domain.Interfaces;
using DemoCompra.Infra.Data.Context;
using DemoCompra.Infra.Data.Repositories;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DemoCompra.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Validator
            services.AddTransient<IValidator<CompraViewModel>, CompraViewModelValidator>();

            // Domain
            services.AddScoped<ICompraAppService, CompraAppService>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<CompraContext>();
        }
    }
}
