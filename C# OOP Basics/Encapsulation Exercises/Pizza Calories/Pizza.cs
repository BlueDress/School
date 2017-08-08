

using System;

namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private Topping[] toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            if (numberOfToppings < 0 || 10 < numberOfToppings)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings = new Topping[numberOfToppings];
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Equals(string.Empty) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public double TotalCalories()
        {
            var toppingsCalories = 0d;

            for (int i = 0; i < this.toppings.Length; i++)
            {
                toppingsCalories += this.toppings[i].TotalCalories();
            }
            return this.dough.TotalCalories() + toppingsCalories;
        }

        public void AddTopping(Topping topping, int index)
        {
            this.toppings[index] = topping;
        }
        public int NumberOfToppings()
        {
            return this.toppings.Length;
        }
    }
}
