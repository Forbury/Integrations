using System;
using System.Collections.Generic;
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
            var forburyConfiguration = new ForburyConfiguration();
            configuration.GetSection("Forbury").Bind(forburyConfiguration);

            services.AddForburyApi(forburyConfiguration);

            return services;
        }

        public static IServiceCollection AddForburyApi(this IServiceCollection services, ForburyConfiguration forburyConfiguration)
        {
            services.AddForburyAuthenticationAndConfiguration(forburyConfiguration);

            // Leaving blank or "0" will setup all API versions for DI
            var apiVersion = forburyConfiguration.Api.Version;

            if (apiVersion == 1 || apiVersion == 0) v1.ServiceBuilder.AddForburyServices(services, $"{forburyConfiguration.Api.Url}api/v1");

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

        private static IServiceCollection AddForburyAuthenticationAndConfiguration(this IServiceCollection services, 
            ForburyConfiguration forburyConfiguration)
        {
            services.ConfigureOptions(forburyConfiguration);

            services.AddTransient<AuthorizationDelegatingHandler>();

            services.AddHttpClient<IForburyAuthenticationService, ForburyAuthenticationService>(config =>
            {
                config.BaseAddress = new Uri(forburyConfiguration.Authentication.Url);
            });

            return services;
        }
    }
}
