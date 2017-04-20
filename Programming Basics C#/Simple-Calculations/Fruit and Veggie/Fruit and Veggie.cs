using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_and_Veggie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете цена на един килограм зеленчуци ");
            var vegprice = double.Parse(Console.ReadLine());

            Console.Write("Въведете цена на един килограм плодове ");
            var fruitprice = double.Parse(Console.ReadLine());

            Console.Write("Въведете количество на продадените зеленчуци ");
            var vegamount = int.Parse(Console.ReadLine());

            Console.Write("Въведете количество на продадените плодове ");
            var fruitamount = int.Parse(Console.ReadLine());

            var proceeds = ((vegprice * vegamount) + (fruitprice * fruitamount)) / 1.94;
            Console.WriteLine($"Оборотът от продажбата на плодове и зеленчуци е {proceeds} EUR");
        }
    }
}
