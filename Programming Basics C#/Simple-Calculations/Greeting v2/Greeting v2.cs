using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_v2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Въведете първото си име ");
            var fname = Console.ReadLine();
          //  Console.Write("Въведете фамилното си име ");
            var lname = Console.ReadLine();
          //  Console.Write("Въведете годините си ");
            var year = Console.ReadLine();
          //  Console.Write("Въведете родният си град ");
            var town = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"You are {fname} {lname}, a {year}-years old person from {town}.");

        }
    }
}
