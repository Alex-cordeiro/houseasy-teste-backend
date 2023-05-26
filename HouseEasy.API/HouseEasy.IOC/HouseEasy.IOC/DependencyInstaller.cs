using HouseEasy.Domain.Interfaces.Repository.Enderecos;
using HouseEasy.Domain.Interfaces.Repository.Ocupacoes;
using HouseEasy.Domain.Interfaces.Repository.Telefones;
using HouseEasy.Domain.Interfaces.Repository.Usuarios;
using HouseEasy.Domain.Interfaces.Service.Enderecos;
using HouseEasy.Domain.Interfaces.Service.Ocupacoes;
using HouseEasy.Domain.Interfaces.Service.Telefones;
using HouseEasy.Domain.Interfaces.Service.Usuarios;
using HouseEasy.Repository.Enderecos;
using HouseEasy.Repository.Ocupacoes;
using HouseEasy.Repository.Telefones;
using HouseEasy.Repository.Usuarios;
using HouseEasy.Service.Enderecos;
using HouseEasy.Service.Ocupacoes;
using HouseEasy.Service.Telefones;
using HouseEasy.Service.Usuarios;
using Microsoft.Extensions.DependencyInjection;

namespace HouseEasy.IOC
{
    public static class DependencyInstaller
    {
        public static IServiceCollection SetupRepository(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IOcupacaoRepository, OcupacaoRepository>();

            return services;
        }

        public static IServiceCollection SetupService(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<ITelefoneService, TelefoneService>();
            services.AddScoped<IOcupacaoService, OcupacaoService>();

            return services;
        }
    }
}