using AutoMapper;

namespace LearningSystem.Web.Infrastructure.Mapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureCustomMapping(Profile profile);
    }
}
