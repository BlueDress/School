using System;
using System.Collections.Generic;

namespace Coffee_Machine
{
    public class CoffeeMachine
    {
        private int amountOfCoins;
        private IList<CoffeeType> soldCoffees;

        public CoffeeMachine()
        {
            this.soldCoffees = new List<CoffeeType>();
        }

        public void BuyCoffee(string size, string type)
        {
            CoffeePrice currentSize;
            Enum.TryParse(size, out currentSize);

            var coffePrice = (int)currentSize;

            if (coffePrice <= this.amountOfCoins)
            {
                this.amountOfCoins = 0;

                CoffeeType coffeType;
                Enum.TryParse(type, out coffeType);

                this.soldCoffees.Add(coffeType);
            }
        }

        public void InsertCoin(string coin)
        {
            Coin currentCoin;
            Enum.TryParse(coin, out currentCoin);
            this.amountOfCoins += (int)currentCoin;
        }

        public IEnumerable<CoffeeType> CoffeesSold { get { return this.soldCoffees; } }

    }
}
