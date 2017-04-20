using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа ");
            var n = int.Parse(Console.ReadLine());

            var check = int.MinValue;
            var sum = 0;
            var sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете число ");
                var num = int.Parse(Console.ReadLine());

                if (num > check)
                {
                    check = num;
                    sum1 += check;
                }
                else
                {
                    sum += num;
                }
            }
            sum += sum1 - check;
            if (check == sum)
            {
                Console.WriteLine($"Yes Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(check - sum)}");
            }
        }
    }
}
