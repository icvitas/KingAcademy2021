using KingICT.KingAcademy2021.UnitTests.Configuration;
using KingICT.KingAcademy2021.UnitTests.Repository.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KingICT.KingAcademy2021.UnitTests.IoC
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureApplicationServices(services, configuration);
            ConfigureRepositories(services, configuration);
        }

        private static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var databaseConfiguration = configuration.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();

            services.AddDbContext<KingAcademy2021DbContext>(options =>
            {
                options.UseSqlServer(databaseConfiguration.ConnectionString);
            });
        }

        private static void ConfigureApplicationServices(IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
