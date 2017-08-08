

using System;

namespace Shopping_Spree
{
    public class Product
    {
        private string name;
        private double cost;

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

        public double Cost
        {
            get
            {
                return this.cost;
            }
        }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.cost = cost;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
