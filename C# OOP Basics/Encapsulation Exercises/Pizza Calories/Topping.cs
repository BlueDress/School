

using System;

namespace Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            set
            {
                if (!value.Equals("meat") && !value.Equals("veggies") && !value.Equals("cheese") && !value.Equals("sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                };

                this.type = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < 1 || 50 < value)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                };

                this.weight = value;
            }
        }

        public double TotalCalories()
        {
            var modifier = 0d;

            if (this.type.Equals("meat"))
            {
                modifier = 1.2;
            }
            else if (this.type.Equals("veggies"))
            {
                modifier = 0.8;
            }
            else if (this.type.Equals("cheese"))
            {
                modifier = 1.1;
            }
            else
            {
                modifier = 0.9;
            }

            return this.weight * 2 * modifier;
        }
    }
}
