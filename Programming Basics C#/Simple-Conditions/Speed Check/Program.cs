using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете скорост на движение ");
            var speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("Скоростта е бавна");
            }
            else if((speed > 10) && (speed <= 50))
                {
                Console.WriteLine("Скоростта е средна");
                }
            else if ((speed > 50) && (speed <= 150))
                {
                Console.WriteLine("Скоростта е бърза");
                }
            else if ((speed > 150) && (speed <= 1000))
            {
                Console.WriteLine("Скоростта е ултра бърза");
            }
            else
            {
                Console.WriteLine("Скоростта е екстремно бърза");
            }
        }
    }
}
