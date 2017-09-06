namespace Inferno_Infinity.Entities.Gems
{
    public class Emerald : Gem
    {
        public Emerald(GemClarity gemClarity) : base(gemClarity)
        {
            this.Strength = 1;
            this.Agility = 4;
            this.Vitality = 9;
            this.CalculateStats();
        }
    }
}
