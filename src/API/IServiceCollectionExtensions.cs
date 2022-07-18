using System;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Forbury.Integrations.API
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddForburyApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddForburyAuthenticationAndConfiguration(configuration);

            // Leaving blank or "0" will setup all API versions for DI
            var apiVersion = int.TryParse(configuration["Forbury:Api:Version"], out int parsedApiVersion) ?
                parsedApiVersion : 0;

            if (apiVersion == 1 || apiVersion == 0) v1.ServiceBuilder.AddForburyServices(services, $"{configuration["Forbury:Api:Url"]}api/v1");

            return services;
        }

        internal static void AddForburyHttpClient<TClient, TImplementation>(this IServiceCollection services, string uriPrefix, string uriPath)
            where TClient : class 
            where TImplementation : class, TClient
        {
            services.AddHttpClient<TClient, TImplementation>(config =>
            {
                config.BaseAddress = new Uri($"{uriPrefix}/{uriPath}/");
            }).AddHttpMessageHandler<AuthorizationDelegatingHandler>();
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
