﻿using BookShop.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace BookShop.Api.Infrastructure.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            Assembly.GetAssembly(typeof(IService)).GetTypes().Where(t => t.IsClass && t.GetInterfaces().Any(i => i.Name.Equals($"I{t.Name}"))).Select(t => new
            {
                Interface = t.GetInterface($"I{t.Name}"),
                Implementation = t
            }).ToList().ForEach(s => services.AddTransient(s.Interface, s.Implementation));

            return services;
        }
    }
}
