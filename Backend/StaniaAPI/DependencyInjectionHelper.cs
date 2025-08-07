using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StaniaAPI.DataAccess;
using StaniaAPI.Repositories.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Repositories.Implementations.RentalUnitImplementations;
using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.Implementations.RentalUnitImplementations;

namespace StaniaAPI
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<IRentalUnitService, RentalUnitService>();
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped<IRentalUnitRepository, RentalUnitRepository>();
        }
    }
}
