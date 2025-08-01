using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StaniaAPI.DataAccess;
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
    }
}
