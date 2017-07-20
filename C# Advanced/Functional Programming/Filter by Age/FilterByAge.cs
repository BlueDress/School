using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    public class FilterByAge
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());

            var nameAndAge = new Dictionary<string, int>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                nameAndAge[name] = age;
            }

            var condition = Console.ReadLine();
            var ageCheck = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            PrintResultsAccordingToSetConditions(nameAndAge, condition, ageCheck, format);
        }

        private static void PrintResultsAccordingToSetConditions(Dictionary<string, int> dictionary, string olderOrYounger, int ageCheck, string format)
        {
            switch (format)
            {
                case "name":

                    foreach (var person in dictionary)
                    {
                        switch (olderOrYounger)
                        {
                            case "older":

                                if (person.Value >= ageCheck)
                                {
                                    Console.WriteLine(person.Key);
                                }
                                break;
                            case "younger":

                                if (person.Value < ageCheck)
                                {
                                    Console.WriteLine(person.Key);
                                }
                                break;
                        }
                    }
                    break;
                case "age":

                    foreach (var person in dictionary)
                    {
                        switch (olderOrYounger)
                        {
                            case "older":

                                if (person.Value >= ageCheck)
                                {
                                    Console.WriteLine(person.Value);
                                }
                                break;
                            case "younger":

                                if (person.Value < ageCheck)
                                {
                                    Console.WriteLine(person.Value);
                                }
                                break;
                        }
                    }
                    break;
                case "name age":

                    foreach (var person in dictionary)
                    {
                        switch (olderOrYounger)
                        {
                            case "older":

                                if (person.Value >= ageCheck)
                                {
                                    Console.WriteLine($"{person.Key} - {person.Value}");
                                }
                                break;
                            case "younger":

                                if (person.Value < ageCheck)
                                {
                                    Console.WriteLine($"{person.Key} - {person.Value}");
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }
}


