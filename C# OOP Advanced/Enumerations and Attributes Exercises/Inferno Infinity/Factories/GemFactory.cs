using Inferno_Infinity.Entities.Gems;

namespace Inferno_Infinity.Factories
{
    public static class GemFactory
    {
        public static Gem GetGem(string gemType, GemClarity gemClarity)
        {
            if (gemType.Equals("Ruby"))
            {
                return new Ruby(gemClarity);
            }
            else if (gemType.Equals("Emerald"))
            {
                return new Emerald(gemClarity);
            }
            else
            {
                return new Amethyst(gemClarity);
            }
        }
    }
}
