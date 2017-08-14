using System;

namespace Wild_Farm
{
    public class StartUp
    {
        public static void Main()
        {
            ReadAndPrintAnimalData();
        }

        private static void ReadAndPrintAnimalData()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var animalData = input.Split();
                    var animal = AnimalFactory.GetAnimal(animalData);
                    var foodData = Console.ReadLine().Split();
                    var food = FoodFactory.GetFood(foodData);

                    animal.MakeSound();
                    animal.Eat(food);
                    Console.WriteLine(animal.ToString());
                }
            }
        }
    }
}
