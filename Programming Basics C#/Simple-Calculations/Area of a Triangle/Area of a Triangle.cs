using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Въведете дължината на страната ");
            var a = double.Parse(Console.ReadLine());
          //  Console.Write("Въведете дължината на височината към нея ");
            var ha = double.Parse(Console.ReadLine());
            var s = (a * ha) / 2;
            Console.WriteLine(Math.Round(s,2));
        }
    }
}
