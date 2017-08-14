

namespace Wild_Farm
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public string AnimalName { get { return this.animalName; } }
        public string AnimalType { get { return this.animalType; } }
        public double AnimalWeight { get { return this.animalWeight; } }
        public int FoodEaten { get { return this.foodEaten; } set { this.foodEaten = value; } }

        public Animal(string animalName, string animalType, double animalWeight)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food typeOfFood);
    }
}
