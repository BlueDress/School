﻿using AutoMapper;
using BookShop.Common.Mapping;
using System;
using System.Linq;

namespace BookShop.Api.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var allTypes = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.GetName()
                .Name
                .Contains("BookShop"))
                .SelectMany(a => a.GetTypes());

            allTypes.Where(t => t.IsClass && !t.IsAbstract && t
                    .GetInterfaces()
                    .Where(i => i.IsGenericType)
                    .Select(i => i.GetGenericTypeDefinition())
                    .Contains(typeof(IMapFrom<>)))
                .Select(t => new
                {
                    Source = t
                        .GetInterfaces()
                        .Where(i => i.IsGenericType)
                        .Select(i => new
                        {
                            Definition = i.GetGenericTypeDefinition(),
                            Arguments = i.GetGenericArguments()
                        })
                        .Where(i => i.Definition == typeof(IMapFrom<>))
                        .SelectMany(i => i.Arguments)
                        .First(),
                    Destination = t
                })
                .ToList().ForEach(m => this.CreateMap(m.Destination, m.Source));

            allTypes
                .Where(t => t.IsClass && !t.IsAbstract && typeof(IHaveCustomMapping).IsAssignableFrom(t))
                .Select(Activator.CreateInstance)
                .Cast<IHaveCustomMapping>()
                .ToList().ForEach(cm => cm.ConfigureCustomMapping(this));
        }
    }
}
