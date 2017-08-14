

using System;

namespace Wild_Farm
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food typeOfFood)
        {
            if (typeOfFood.GetType().Name.Equals("Vegetable"))
            {
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
            }
            else
            {
                this.FoodEaten += typeOfFood.Quantity;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
