namespace Inferno_Infinity.Entities.Gems
{
    public abstract class Gem
    {
        private int strength;
        private int agility;
        private int vitality;
        private GemClarity gemClarity;

        public Gem(GemClarity gemClarity)
        {
            this.gemClarity = gemClarity;
        }

        public int Strength { get { return this.strength; } set { this.strength = value; } }
        public int Agility { get { return this.agility; } set { this.agility = value; } }
        public int Vitality { get { return this.vitality; } set { this.vitality = value; } }

        public void CalculateStats()
        {
            this.strength += (int)this.gemClarity;
            this.agility += (int)this.gemClarity;
            this.vitality += (int)this.gemClarity;
        }
    }
}
