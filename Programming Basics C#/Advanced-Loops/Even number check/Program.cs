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
            Console.Write("Въведете число ");
            try
            {
                var n = int.Parse(Console.ReadLine());
                while (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                    Console.Write("Въведете число ");
                    n = int.Parse(Console.ReadLine());

                }
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                }
            }
            catch 
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
    }
}
