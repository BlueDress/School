namespace Inferno_Infinity.Entities.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(GemClarity gemClarity) : base(gemClarity)
        {
            this.Strength = 2;
            this.Agility = 8;
            this.Vitality = 4;
            this.CalculateStats();
        }
    }
}
