using System;
using System.Text;

namespace Letters_Change_Numbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = 0d;

            foreach (var token in tokens)
            {
                var firstLetter = token[0];
                var lastLetter = token[token.Length - 1];
                var sb = new StringBuilder();

                for (int i = 1; i < token.Length - 1; i++)
                {
                    sb = sb.Append(token[i]);
                }

                var initialNumber = double.Parse(sb.ToString());

                var sum = 0d;

                if (char.IsUpper(firstLetter))
                {
                    sum = initialNumber / (26 - ('Z' - firstLetter));
                }
                else
                {
                    sum = initialNumber * (26 - ('z' - firstLetter));
                }

                if (char.IsUpper(lastLetter))
                {
                    sum = sum - (26 - ('Z' - lastLetter));
                }
                else
                {
                    sum = sum + (26 - ('z' - lastLetter));
                }

                result += sum;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
