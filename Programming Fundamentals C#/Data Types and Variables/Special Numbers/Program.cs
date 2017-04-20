using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = i;
                sum = 0;
                do
                {
                    sum = sum + (num % 10);
                    num = num / 10;
                } while (num > 0);
                if (sum == 5 || sum == 7 || sum == 11) Console.WriteLine(i + "-> True");
                else Console.WriteLine(i + "-> False");
            }
        }
    }
}
