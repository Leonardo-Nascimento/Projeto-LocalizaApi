using Autofac;
using Localiza.Aplication;
using Localiza.Aplication.Interface;
using Localiza.Domain.Interfaces.InterfaceServices;
using Localiza.Domain.Interfaces.Repositories;
using Localiza.Domain.Services;
using Localiza.Infra.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Infra.Ioc
{
    public static class ConfigurationIOC
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {


            //Aplication
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IEnderecoAppService, EnderecoAppService>();
            services.AddScoped<IFabricanteAppService, FabricanteAppService>();
            services.AddScoped<IModeloAppService, ModeloAppService>();
            services.AddScoped<IReservaAppService, ReservaAppService>();
            services.AddScoped<IVeiculoAppService, VeiculoAppService>();

            //Domain/Service
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IFabricanteService, FabricanteService>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IReservaService, ReservaService>();
            services.AddScoped<IVeiculoService, VeiculoService>();

            //Repository
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFabricanteRepository, FabricanteRepository>();
            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();

        }
    }
}
