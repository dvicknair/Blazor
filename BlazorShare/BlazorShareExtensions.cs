using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorShare
{
    public static class BlazorShareExtensions
    {
        public static IServiceCollection AddBlazorShareExtensions(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
