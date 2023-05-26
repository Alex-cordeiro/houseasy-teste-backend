using HouseEasy.Domain.Interfaces.Repository.Usuarios;
using HouseEasy.Domain.Interfaces.Service.Usuarios;
using HouseEasy.Repository.Usuarios;
using HouseEasy.Service.Usuarios;
using Microsoft.Extensions.DependencyInjection;

namespace HouseEasy.IOC
{
    public static class DependencyInstaller
    {
        public static IServiceCollection SetupRepository(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            //services.AddScoped<IEnderecoRepository, EstoqueRepository>();

            return services;
        }

        public static IServiceCollection SetupService(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            return services;
        }

    }
}