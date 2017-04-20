using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowes_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дума ");
            var word = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                    {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    }
            }
            Console.WriteLine($"{sum}");
        }
    }
}


