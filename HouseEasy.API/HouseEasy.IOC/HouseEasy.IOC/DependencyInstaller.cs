using HouseEasy.Domain.Interfaces.Repository.Enderecos;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HouseEasy.IOC
{
    public static class DependencyInstaller
    {

        public static IServiceCollection SetupRepository(this IServiceCollection services )
        {
            services.AddScoped<IEnderecoRepository, EstoqueRepository>();

            return services;
        }

        public static IServiceCollection SetupService(this IServiceCollection services)
        {
            return services;
        }

    }
}