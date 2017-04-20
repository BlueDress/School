using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int p = 97; p < 97 + n; p++)
                    {
                        Console.WriteLine("{0}{1}{2}", Convert.ToChar(i), Convert.ToChar(j), Convert.ToChar(p));
                    }
                }
            }
        }
    }
}
