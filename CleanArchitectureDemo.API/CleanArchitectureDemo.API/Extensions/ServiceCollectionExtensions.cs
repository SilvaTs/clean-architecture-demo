using CleanArchitectureDemo.Application.Services;
using CleanArchitectureDemo.Domain.Interfaces.Repositories;
using CleanArchitectureDemo.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
