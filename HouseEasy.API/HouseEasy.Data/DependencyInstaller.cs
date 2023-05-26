using HouseEasy.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HouseEasy.Data
{
    public static class DependencyInstaller
    {
        public static IServiceCollection SetupDataContext(this IServiceCollection services,IConfiguration configuration) 
        {
            var connection = configuration.GetSection("ConexaoSqLite:SqliteConnectionString").Value;

            services.AddDbContext<HouseEasyContext>(opt =>
                opt.UseSqlite(connection)
            );

            return services;
        }
    }
}
