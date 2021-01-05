using BlazorData;
using BlazorServices;
using BlazorShare;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp
{
    public static class SolutionExtensions
    {
        public static IServiceCollection AddSolutionExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBlazorDataExtensions(configuration);
            services.AddBlazorServicesExtensions();
            services.AddBlazorShareExtensions();
            return services;
        }
    }
}
