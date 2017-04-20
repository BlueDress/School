using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lylie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("На колко години е Лили?: ");
            var y = int.Parse(Console.ReadLine());

            Console.Write("Колко струва пералнята?: ");
            var price = double.Parse(Console.ReadLine());

            Console.Write("Каква е цената на играчките?: ");
            var toyprice = int.Parse(Console.ReadLine());

            var p = 0;
            var n = 0;
            var b = 0;
            var t = 0;
            var sum = 0;
            for (int i = 1; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    p += 10;
                    n += p;
                    b++;
                }
                else t++;
            }
            sum = (n - b) + (t * toyprice);
            if (sum >= price) Console.WriteLine($"Yes! {sum - price:f2}");
            else Console.WriteLine($"No! {price - sum:f2}");
        }
    }
}
