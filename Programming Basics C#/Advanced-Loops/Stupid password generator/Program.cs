using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Въведете число ");
            var l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int p = 97; p < 97 + l; p++)
                    {
                        for (int k = 97; k < 97 + l; k++)
                        {
                            for (int m = 2; m <= n; m++)
                            {
                                if (m > i && m > j)
                                    Console.Write($"{i}{j}{Convert.ToChar(p)}{Convert.ToChar(k)}{m} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
