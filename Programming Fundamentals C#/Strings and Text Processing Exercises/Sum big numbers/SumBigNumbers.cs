using System;
using System.Text;

namespace Sum_big_numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstString = Console.ReadLine().TrimStart('0');
            var secondString = Console.ReadLine().TrimStart('0');

            var sb = new StringBuilder();
            var toAdd = 0;

            for (int i = Math.Min(firstString.Length, secondString.Length) - 1; i > 0; i--)
            {
                var sumOf = (firstString[i] - '0') + (secondString[i] - '0');

                if (sumOf + toAdd < 10)
                {
                    sb = sb.Insert(0, sumOf + toAdd);
                    toAdd = 0;
                }
                else
                {
                    sb = sb.Insert(0, (sumOf + toAdd) % 10);
                    toAdd = (sumOf + toAdd) / 10;
                }
            }


            if (firstString.Length > secondString.Length)
            {
                sb = sb.Insert(0, ((firstString[firstString.Length - secondString.Length] - '0') + (secondString[0] - '0') + toAdd) % 10);
                toAdd = ((firstString[firstString.Length - secondString.Length] - '0') + (secondString[0] - '0') + toAdd) / 10;
                
                for (int i = firstString.Length - secondString.Length - 1; i > 0; i--)
                {
                    if ((firstString[i] - '0') + toAdd < 10)
                    {
                        sb = sb.Insert(0, (firstString[i] - '0') + toAdd);
                        toAdd = 0;
                    }
                    else
                    {
                        sb = sb.Insert(0, ((firstString[i] - '0') + toAdd) % 10);
                        toAdd = ((firstString[i] - '0') + toAdd) / 10;
                    }
                }

                sb = sb.Insert(0, (firstString[0] - '0') + toAdd);
            }
            else if (firstString.Length < secondString.Length)
            {
                sb = sb.Insert(0, ((secondString[secondString.Length - firstString.Length] - '0') + (firstString[0] - '0') + toAdd) % 10);
                toAdd = ((secondString[secondString.Length - firstString.Length] - '0') + (firstString[0] - '0') + toAdd) / 10;

                for (int i = secondString.Length - firstString.Length - 1; i > 0; i--)
                {
                    if ((secondString[i] - '0') + toAdd < 10)
                    {
                        sb = sb.Insert(0, (secondString[i] - '0') + toAdd);
                        toAdd = 0;
                    }
                    else
                    {
                        sb = sb.Insert(0, ((secondString[i] - '0') + toAdd) % 10);
                        toAdd = ((secondString[i] - '0') + toAdd) / 10;
                    }
                }

                sb = sb.Insert(0, (secondString[0] - '0') + toAdd);
            }
            else
            {
                sb = sb.Insert(0, (firstString[0] - '0') + (secondString[0] - '0') + toAdd);
            }

            var result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
