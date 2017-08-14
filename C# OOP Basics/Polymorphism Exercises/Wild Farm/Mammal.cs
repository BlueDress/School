

namespace Wild_Farm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion { get { return this.livingRegion; } }

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.livingRegion = livingRegion;
        }
    }
}
