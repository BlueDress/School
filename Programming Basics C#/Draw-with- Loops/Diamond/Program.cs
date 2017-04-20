using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 2)/ 2 - i), new string('-', 2 * i));
                }
                for (int i = n / 2 - 2; i >= 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 2) / 2 - i), new string('-', 2 * i));
                }               
            }
            else
            {
                if (n != 1)
                {

                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', 2 * i - 1));

                }
                for (int i = (n - 3) / 2; i > 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', 2 * i - 1));

                }
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                }
                else Console.WriteLine("*");
            }
        }
    }
}
