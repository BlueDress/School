
using System;

namespace Wild_Farm
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food typeOfFood)
        {
            if (typeOfFood.GetType().Name.Equals("Meat"))
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
            Console.WriteLine("Zs!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
