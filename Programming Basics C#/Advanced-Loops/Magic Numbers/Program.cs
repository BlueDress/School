using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var sum = 1;
            var count = 0;

            for (int i = 100000; i <= 999999; i++)
            {
                count = i;
                sum = 1;
                do
                {
                    sum = sum * (count % 10);
                    count = count / 10;
                } while (count > 0);

                if (sum == n) Console.Write(i + " ");
            }
            Console.WriteLine();  
        }
    }
}
