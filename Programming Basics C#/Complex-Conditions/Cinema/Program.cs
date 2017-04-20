using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете вид на прожекцията ");
            var type = Console.ReadLine().ToLower();

            Console.Write("Въведете брой редове ");
            var r = int.Parse(Console.ReadLine());

            Console.Write("Въведете брой колони ");
            var c = int.Parse(Console.ReadLine());

            switch(type)
            {
                case "premiere": Console.WriteLine("Приходите при пълна зала са {0:f2} лева", r * c * 12); break;
                case "normal": Console.WriteLine("Приходите при пълна зала са {0:f2} лева", r * c * 7.5); break;
                case "discount": Console.WriteLine("Приходите при пълна зала са {0:f2} лева", r * c * 5); break;

            }
        }
    }
}
