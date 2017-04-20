using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой чилса ");
            var n = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи число ");
                var num = int.Parse(Console.ReadLine());

                sum1 = sum1 + num;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи число ");
                var num = int.Parse(Console.ReadLine());

                sum2 = sum2 + num;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
