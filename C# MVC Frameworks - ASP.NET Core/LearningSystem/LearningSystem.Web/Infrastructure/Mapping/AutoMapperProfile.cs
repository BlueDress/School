using AutoMapper;
using LearningSystem.Data.Models;
using LearningSystem.Services.Models.Courses;
using System;
using System.Linq;

namespace LearningSystem.Web.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Course, ListAllCoursesModel>();

            this.CreateMap<Course, ViewCourseModel>().ForMember(c => c.TrainerName, cfg => cfg.MapFrom(c => c.Trainer.Name));

            //AppDomain.CurrentDomain.GetAssemblies()
            //    .Where(a => a.GetName()
            //    .Name
            //    .Contains("Learning"))
            //    .SelectMany(a => a.GetTypes())
            //    .Where(t => t.IsClass && !t.IsAbstract && t
            //        .GetInterfaces()
            //        .Where(i => i.IsGenericType)
            //        .Select(i => i.GetGenericTypeDefinition())
            //        .Contains(typeof(IMapFrom<>)))
            //    .Select(t => new
            //    {
            //        Source = t
            //            .GetInterfaces()
            //            .Where(i => i.IsGenericType)
            //            .Select(i => new
            //            {
            //                Definition = i.GetGenericTypeDefinition(),
            //                Arguments = i.GetGenericArguments()
            //            })
            //            .Where(i => i.Definition == typeof(IMapFrom<>))
            //            .SelectMany(i => i.Arguments)
            //            .First(),
            //        Destination = t
            //    })
            //    .ToList().ForEach(m => this.CreateMap(m.Destination, m.Source));

            //AppDomain.CurrentDomain.GetAssemblies()
            //    .Where(a => a.GetName()
            //    .Name
            //    .Contains("Learning"))
            //    .SelectMany(a => a.GetTypes())
            //    .Where(t => t.IsClass && !t.IsAbstract && typeof(IHaveCustomMapping).IsAssignableFrom(t))
            //    .Select(Activator.CreateInstance)
            //    .Cast<IHaveCustomMapping>()
            //    .ToList().ForEach(cm => cm.ConfigureCustomMapping(this));
        }
    }
}
