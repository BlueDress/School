using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            ReadAndPrintData();
        }

        private static void ReadAndPrintData()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Beast!"))
                {
                    break;
                }
                else
                {
                    var typeOfAnimal = input;
                    var animalInfo = Console.ReadLine().Split();
                    var name = animalInfo[0];
                    var age = int.Parse(animalInfo[1]);
                    var gender = animalInfo[2];
                    try
                    {
                        switch (typeOfAnimal)
                        {
                            case "Dog":
                                Animal dog = new Dog(name, age, gender);
                                Console.WriteLine("Dog");
                                Console.WriteLine(dog.ToString());
                                dog.ProduceSound();
                                break;
                            case "Cat":
                                Animal cat = new Cat(name, age, gender);
                                Console.WriteLine("Cat");
                                Console.WriteLine(cat.ToString());
                                cat.ProduceSound();
                                break;
                            case "Frog":
                                Animal frog = new Frog(name, age, gender);
                                Console.WriteLine("Frog");
                                Console.WriteLine(frog.ToString());
                                frog.ProduceSound();
                                break;
                            case "Kittens":
                                Animal kittens = new Kittens(name, age, gender);
                                Console.WriteLine("Kittens");
                                Console.WriteLine(kittens.ToString());
                                kittens.ProduceSound();
                                break;
                            case "Tomcat":
                                Animal tomcat = new Tomcat(name, age, gender);
                                Console.WriteLine("Tomcat");
                                Console.WriteLine(tomcat.ToString());
                                tomcat.ProduceSound();
                                break;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
