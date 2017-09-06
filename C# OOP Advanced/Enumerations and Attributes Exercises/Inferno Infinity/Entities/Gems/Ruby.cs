namespace Inferno_Infinity.Entities.Gems
{
    public class Ruby : Gem
    {
        public Ruby(GemClarity gemClarity) : base(gemClarity)
        {
            this.Strength = 7;
            this.Agility = 2;
            this.Vitality = 5;
            this.CalculateStats();
        }
    }
}
