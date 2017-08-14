using System;

namespace Wild_Farm
{
    public class Cat : Feline
    {
        private string breed;

        public string Breed { get { return this.breed; }}

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food typeOfFood)
        {
            this.FoodEaten += typeOfFood.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
