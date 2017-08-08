using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class ShoppingSpree
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();
            var tokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                try
                {
                    var personData = tokens[i].Split('=');
                    var personName = personData[0];
                    var personMoney = double.Parse(personData[1]);
                    var person = new Person(personName, personMoney);
                    people.Add(person);
                }
                catch (ArgumentException Exception)
                {
                    Console.WriteLine(Exception.Message);
                    return;
                }
            }
            tokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                try
                {
                    var productData = tokens[i].Split('=');
                    var productName = productData[0];
                    var productCost = double.Parse(productData[1]);
                    var product = new Product(productName, productCost);
                    products.Add(product);
                }
                catch (ArgumentException Exception)
                {
                    Console.WriteLine(Exception.Message);
                    return;
                }
            }
            ProcessShopingData(people, products);
            PrintPeople(people);
        }

        private static void PrintPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }

        private static void ProcessShopingData(List<Person> people, List<Product> products)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var personName = tokens[0];
                    var productName = tokens[1];
                    var product = products.Find(pr => pr.Name.Equals(productName));
                    people.Find(pr => pr.Name.Equals(personName)).BuyProduct(product);
                }
            }
        }
    }
}
