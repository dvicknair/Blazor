using Microsoft.Extensions.DependencyInjection;

namespace BlazorServices
{
    public static class BlazorServicesExtensions
    {
        public static IServiceCollection AddBlazorServicesExtensions(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
