using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Office_Stuff
{
    public class OfficeStuff
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ', '|', '-' }, StringSplitOptions.RemoveEmptyEntries);
                var company = tokens[0];
                var amount = int.Parse(tokens[1]);
                var product = tokens[2];

                if (!result.ContainsKey(company))
                {
                    result[company] = new Dictionary<string, int>();
                }

                if (!result[company].ContainsKey(product))
                {
                    result[company][product] = 0;
                }

                result[company][product] += amount;
            }

            foreach (var company in result.OrderBy(x => x.Key))
            {
                var sb = new StringBuilder();

                foreach (var product in company.Value)
                {
                    sb.Append(product.Key);
                    sb.Append("-");
                    sb.Append(product.Value);
                    sb.Append(", ");
                }
                sb.Length -= 2;

                Console.WriteLine($"{company.Key}: {sb.ToString()}");
            }
        }
    }
}
