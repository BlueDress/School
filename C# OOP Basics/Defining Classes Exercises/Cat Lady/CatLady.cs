using System;
using System.Collections.Generic;

namespace Cat_Lady
{
    public class CatLady
    {
        public static void Main()
        {
            var cats = ReadCatData();
            PrintResult(cats);
        }

        private static void PrintResult(List<Cat> cats)
        {
            var name = Console.ReadLine();
            var cat = cats.Find(c => c.Name.Equals(name));
            Console.WriteLine(cat.ToString());
        }

        private static List<Cat> ReadCatData()
        {
            var cats = new List<Cat>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var catInfo = input.Split();
                    var breed = catInfo[0];
                    var name = catInfo[1];

                    switch (breed)
                    {
                        case "Siamese":
                            var earSize = int.Parse(catInfo[2]);
                            Cat siamese = new Siamese(name, earSize);
                            cats.Add(siamese);
                            break;
                        case "Cymric":
                            var furLength = double.Parse(catInfo[2]);
                            Cat cymric = new Cymric(name, furLength);
                            cats.Add(cymric);
                            break;
                        case "StreetExtraordinaire":
                            var decibelsOfMeows = int.Parse(catInfo[2]);
                            Cat streetExtraordinaire = new StreetExtraordinaire(name, decibelsOfMeows);
                            cats.Add(streetExtraordinaire);
                            break;
                    }
                }
            }

            return cats;
        }
    }
}
