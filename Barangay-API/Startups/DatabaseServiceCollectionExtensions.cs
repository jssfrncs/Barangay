using Barangay_API.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
namespace Barangay_API.Startups
{
    public static class DatabaseServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BarangayContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("barangay"),ServerVersion.AutoDetect(configuration.GetConnectionString("barangay")));
                options.EnableSensitiveDataLogging(true);
            });
            return services;
        }



    }
}
