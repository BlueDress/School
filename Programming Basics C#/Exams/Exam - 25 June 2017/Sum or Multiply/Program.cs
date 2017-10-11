using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_or_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlNumber = int.Parse(Console.ReadLine());

            var haveResult = false;

            for (int a = 1; a <= 28; a++)
            {
                for (int b = a + 1; b <= 29; b++)
                {
                    for (int c = b + 1; c <= 30; c++)
                    {
                        if ((a + b + c) == controlNumber)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {controlNumber}");
                            haveResult = true;
                        }
                    }
                }
            }

            for (int a = 30; a >= 3; a--)
            {
                for (int b = a - 1; b >= 2; b--)
                {
                    for (int c = b - 1; c >= 1; c--)
                    {
                        if ((a * b * c) == controlNumber)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {controlNumber}");
                            haveResult = true;
                        }
                    }
                }
            }

            if (haveResult == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
