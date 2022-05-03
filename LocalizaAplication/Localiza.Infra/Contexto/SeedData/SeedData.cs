using Localiza.Domain.Enuns;
using Localiza.Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Infra.Contexto.SeedData
{
    public class SeedData
    {
        private readonly LocalizaDbContext _localizaDbContext;

        public SeedData(LocalizaDbContext localizaDbContext)
        {
            _localizaDbContext = localizaDbContext;
        }

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LocalizaDbContext>();
                context.Database.EnsureCreated();

                //Fabricantes
                if (!context.Fabricante.Any())
                {
                    context.Fabricante.AddRange(new List<Fabricante>() {
                        new Fabricante(){ Nome = "Ferrari", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "Audi", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "Mercedes", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "Ford", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "Chevrolet", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "Fiat", DataCriacao = DateTime.Now },
                        new Fabricante(){ Nome = "BMW", DataCriacao = DateTime.Now },
                    });
                    context.SaveChanges();
                }

                //Modelo
                if (!context.Modelo.Any())
                {
                    context.Modelo.AddRange(new List<Modelo>() {
                        new Modelo(){ Nome = "458 Italia", FabricanteId = 1 , Tipo = TipoVeiculo.Esportivo , DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "A3", FabricanteId = 3, Tipo = TipoVeiculo.Hatch, DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "SLS AMG", FabricanteId = 4 , Tipo = TipoVeiculo.Esportivo, DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "EcoSport ", FabricanteId = 5, Tipo = TipoVeiculo.SUV, DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "Camaro SS", FabricanteId = 6 , Tipo = TipoVeiculo.Esportivo, DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "Argo", FabricanteId = 7 , Tipo = TipoVeiculo.Hatch, DataCriacao = DateTime.Now },
                        new Modelo(){ Nome = "M3 Competition", FabricanteId = 8, Tipo = TipoVeiculo.Sedan, DataCriacao = DateTime.Now },
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}

