using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name ");
            var fname = Console.ReadLine();

            Console.Write("Last name ");
            var lname = Console.ReadLine();

            Console.Write("age ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {fname} {lname}. You are {age} years old.");

        }
    }
}
