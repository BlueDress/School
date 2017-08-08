
using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Equals(string.Empty) || value == null)
                {
                    throw new ArgumentException("Name cannot be an empty string.");
                };

                this.name = value;
            }
        }

        public double Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative number.");
                };

                this.money = value;
            }
        }

        public List<Product> Products{ get { return this.products; } }

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.products.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
