using AutoMapper;

namespace BookShop.Common.Mapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureCustomMapping(Profile profile);
    }
}