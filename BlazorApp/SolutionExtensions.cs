using BlazorData;
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
            //services.AddKL_ServicesExtensions(configuration);
            services.AddBlazorShareExtensions();
            return services;
        }
    }
}
