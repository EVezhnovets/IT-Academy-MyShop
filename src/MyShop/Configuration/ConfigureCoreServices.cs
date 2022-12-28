using MyShop.ApplicationCore.Interfaces;
using MyShop.Infrastructure;

namespace MyShop.Configuration
{
    //adding services for adding to DI container in Program.cs
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}
