using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Google
{
    public class StartUpGoogle
    {
        public static void Main()
        {
            var people = new List<Person>();
            ReadData(people);
            PrintInformation(people);
        }

        private static void PrintInformation(List<Person> people)
        {
            var personName = Console.ReadLine();
            var person = people.Find(per => per.Name.Equals(personName));
            Console.WriteLine(person.Name);
            Console.WriteLine("Company:");
            if (person.Company != null)
            {
                Console.WriteLine(person.Company.ToString());
            }
            Console.WriteLine("Car:");
            if (person.Car != null)
            {
                Console.WriteLine(person.Car.ToString());
            }
            Console.WriteLine("Pokemon:");
            if (person.Pokemons.Count > 0)
            {
                foreach (var pokemon in person.Pokemons)
                {
                    Console.WriteLine(pokemon.ToString());
                }
            }
            Console.WriteLine("Parents:");
            if (person.Parents.Count > 0)
            {
                foreach (var parent in person.Parents)
                {
                    Console.WriteLine(parent.ToString());
                }
            }
            Console.WriteLine("Children:");
            if (person.Children.Count > 0)
            {
                foreach (var child in person.Children)
                {
                    Console.WriteLine(child.ToString());
                }
            }
        }

        private static void ReadData(List<Person> people)
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
                    var tokens = input.Split();
                    var name = tokens[0];
                    var command = tokens[1];

                    switch (command)
                    {
                        case "company":
                            var companyName = tokens[2];
                            var department = tokens[3];
                            var salary = double.Parse(tokens[4]);
                            var company = new Company(companyName, department, salary);

                            if (!people.Any(person => person.Name.Equals(name)))
                            {
                                var person = new Person(name);
                                people.Add(person);
                            }
                            people.Find(person => person.Name.Equals(name)).Company = company;

                            break;
                        case "pokemon":
                            var pokemonName = tokens[2];
                            var type = tokens[3];
                            var pokemon = new Pokemon(pokemonName, type);

                            if (!people.Any(person => person.Name.Equals(name)))
                            {
                                var person = new Person(name);
                                people.Add(person);
                            }
                            people.Find(person => person.Name.Equals(name)).Pokemons.Add(pokemon);

                            break;
                        case "parents":
                            var parentName = tokens[2];
                            var birthDate = DateTime.ParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            var parent = new Parent(parentName, birthDate);

                            if (!people.Any(person => person.Name.Equals(name)))
                            {
                                var person = new Person(name);
                                people.Add(person);
                            }
                            people.Find(person => person.Name.Equals(name)).Parents.Add(parent);

                            break;
                        case "children":
                            var childName = tokens[2];
                            var birthDay = DateTime.ParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            var child = new Child(childName, birthDay);

                            if (!people.Any(person => person.Name.Equals(name)))
                            {
                                var person = new Person(name);
                                people.Add(person);
                            }
                            people.Find(person => person.Name.Equals(name)).Children.Add(child);

                            break;
                        case "car":
                            var model = tokens[2];
                            var speed = double.Parse(tokens[3]);
                            var car = new Car(model, speed);

                            if (!people.Any(person => person.Name.Equals(name)))
                            {
                                var person = new Person(name);
                                people.Add(person);
                            }
                            people.Find(person => person.Name.Equals(name)).Car = car;

                            break;
                    }
                }
            }
        }
    }
}
