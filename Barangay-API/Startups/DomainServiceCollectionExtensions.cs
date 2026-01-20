using Barangay_API.Services.Interface;
using Barangay_API.Services.Repositories;

namespace Barangay_API.Startups
{
    public static class DomainServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IHouseholdRepository, HouseholdRepository>();
            services.AddControllersWithViews();
            services.AddHttpClient();
            return services;
        }
    }
}
