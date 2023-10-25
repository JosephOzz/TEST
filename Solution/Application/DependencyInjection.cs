using Application.Interfaces;
using Application.Services;
using Application.Services.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IEntityOfCase1Service, EntityOfCase1Service>();
            services.AddScoped<IEntityOfCase2Service, EntityOfCase2Service>();
            services.AddScoped<IApplicationServices, ApplicationServices>();
            services.AddScoped<IValidationService, ValidationService>();
            return services;
        }
    }
}