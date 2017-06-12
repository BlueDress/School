using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_number_check
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете число ");
                    var n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                    Console.Write("Въведете число ");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }

        }
    }
}
