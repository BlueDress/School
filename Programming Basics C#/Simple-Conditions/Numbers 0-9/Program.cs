using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_0_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число в интервала от 0 до 9 включително ");
            var a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Нула");
            }
            else if (a == 1)
            {
                Console.WriteLine("Едно");
            }
            else if (a == 2)
            {
                Console.WriteLine("Две");
            }
            else if (a == 3)
            {
                Console.WriteLine("Три");
            }
            else if (a == 4)
            {
                Console.WriteLine("Четири");
            }
            else if (a == 5)
            {
                Console.WriteLine("Пет");
            }
            else if (a == 6)
            {
                Console.WriteLine("Шест");
            }
            else if (a == 7)
            {
                Console.WriteLine("Седем");
            }
            else if (a == 8)
            {
                Console.WriteLine("Осем");
            }
            else if (a == 9)
            {
                Console.WriteLine("Девет");
            }
            else
            {
                Console.WriteLine("Числото не е в интервала от 0 до 9");
            }
        }
    }
}
