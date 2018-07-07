using System;

namespace Ch20P06
{
    public class Startup
    {
        public static void Main()
        {
            Animal[] animals = new Animal[5];

            animals[0] = new Dog(1, "Dog", "Male");
            animals[1] = new Frog(2, "Frog", "Female");
            animals[2] = new Cat(3, "Cat", "Male");
            animals[3] = new Tomcat(4, "Tomcat", "Female");
            animals[4] = new Kitten(5, "Kitten", "Male");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine();
            }
        }
    }
}
