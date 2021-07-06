using System;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.Models;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ForburyApiServiceV1 = Forbury.Integrations.API.v1.Services.ForburyApiService;
using IForburyApiServiceV1 = Forbury.Integrations.API.v1.Interfaces.IForburyApiService;

namespace Forbury.Integrations.API
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddForburyApiV1(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddForburyAuthenticationAndConfiguration(configuration);
            
            services.AddHttpClient<IForburyApiServiceV1, ForburyApiServiceV1>(config =>
            {
                config.BaseAddress = new Uri($"{configuration["Forbury:Api:Url"]}api/v1/");
            }).AddHttpMessageHandler<AuthorizationDelegatingHandler>();

            return services;
        }

        private static IServiceCollection AddForburyAuthenticationAndConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ForburyConfiguration>(options => configuration.GetSection("Forbury").Bind(options));

            services.AddTransient<AuthorizationDelegatingHandler>();

            services.AddHttpClient<IForburyAuthenticationService, ForburyAuthenticationService>(config =>
            {
                config.BaseAddress = new Uri(configuration["Forbury:Authentication:Url"]);
            });

            return services;
        }
    }
}
