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
            var connection = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;

            services.AddDbContext<HouseEasyContext>(opt =>
                opt.UseSqlServer(connection)
            );

            return services;
        }

        public static IServiceCollection MigrateData(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider
                    .GetRequiredService<HouseEasyContext>();

                dbContext.Database.Migrate();
            }

            return services;
        }
    }
}
