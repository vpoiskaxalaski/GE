using Microsoft.Extensions.DependencyInjection;

namespace GE.WEB.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddDbService(this IServiceCollection services)
        {
            services.AddTransient<UnitOfWorkService>();
        }
    }
}
