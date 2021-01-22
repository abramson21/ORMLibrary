namespace Library.WebServices.Controllers
{
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddScoped<MapConfigurator>();
            services.AddScoped<IMapper>(sp => sp.GetService<MapConfigurator>().CreateMapper());
            return services;
        }
    }
}