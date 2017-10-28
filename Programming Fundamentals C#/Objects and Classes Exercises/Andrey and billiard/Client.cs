

using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_billiard
{
    public class Client
    {
        public Client(string name)
        {
            this.Name = name;
            this.Orders = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> Orders { get; set; }

        public decimal GetBill(Dictionary<string, decimal> prices)
        {
            var bill = 0m;

            foreach (var item in this.Orders)
            {
                var price = prices.First(x => item.Key.Equals(x.Key));
                bill += item.Value * price.Value;
            }

            return bill;
        }
    }
}
