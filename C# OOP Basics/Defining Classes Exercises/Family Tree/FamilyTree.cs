using System;
using System.Collections.Generic;
using System.Linq;

namespace Family_Tree
{
    public class FamilyTree
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();

            var namesAndBirthDates = new List<string>();
            var familyRelations = new List<string>();
            ReadData(namesAndBirthDates, familyRelations);
            var people = new List<Person>();
            AddPeople(people, namesAndBirthDates);
            DefineRelations(people, familyRelations);
            PrintResult(people, keyWord);
        }

        private static void PrintResult(List<Person> people, string keyWord)
        {
            var person = people.Find(per => per.Name.Equals(keyWord) || per.BirthDate.Equals(keyWord));
            Console.WriteLine(person.ToString());
            Console.WriteLine("Parents:");
            if (person.Parents.Count > 0)
            {
                foreach (var per in person.Parents)
                {
                    Console.WriteLine(per.ToString());
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

        private static void DefineRelations(List<Person> people, List<string> familyRelations)
        {
            foreach (var item in familyRelations)
            {
                var tokens = item.Split('-').Select(x => x.Trim()).ToArray();
                var firstPerson = people.Find(person => person.Name.Equals(tokens[0]) || person.BirthDate.Equals(tokens[0]));
                var secondPerson = people.Find(person => person.Name.Equals(tokens[1]) || person.BirthDate.Equals(tokens[1]));
                firstPerson.Children.Add(secondPerson);
                secondPerson.Parents.Add(firstPerson);
            }
        }

        private static void AddPeople(List<Person> people, List<string> namesAndBirthDates)
        {
            foreach (var item in namesAndBirthDates)
            {
                var tokens = item.Split();
                var name = tokens[0] + " " + tokens[1];
                var birthDate = tokens[2];
                var person = new Person(name, birthDate);
                people.Add(person);
            }
        }

        private static void ReadData(List<string> namesAndBirthDates, List<string> familyRelations)
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
                    var tokens = input.Split('-');

                    if (tokens.Count() == 1)
                    {
                        namesAndBirthDates.Add(input);
                    }
                    else
                    {
                        familyRelations.Add(input);
                    }
                }
            }
        }
    }
}
