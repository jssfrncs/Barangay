using Barangay_API.Core.Files;

namespace Barangay_API.Startups
{
    public static class FileSystemServiceCollectionExtension
    {
        public static IServiceCollection AddFilesystem(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFileSystem>(serviceProvider =>
            {
                return (configuration["Filesystem:Type"]) switch
                {
                    "local" => new LocalFileSystem(configuration["Filesystem:RootDirectory"]),
                };
            });

            return services;
        }
    }
}
