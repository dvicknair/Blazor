using BlazorData.Repositories;
using BlazorData.UnitsOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorData
{
    public static class BlazorDataExtensions
    {
        public static IServiceCollection AddBlazorDataExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlazorContext>(options => options.UseSqlServer(configuration.GetConnectionString("BlazorContext")), ServiceLifetime.Transient);
            //services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
