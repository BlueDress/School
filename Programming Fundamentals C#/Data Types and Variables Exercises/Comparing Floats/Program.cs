using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if ((Math.Max(a, b) - Math.Min(a, b)) >= eps) Console.WriteLine("False");
            else Console.WriteLine("True");
        }
    }
}
