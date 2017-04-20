using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 1;

            do
            {
                if (n % num == 0)
                {
                    sum++;
                }
                num++;
            } while (num <= Math.Sqrt(n));
            if (sum == 1 && n > 1) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}
