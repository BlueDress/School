using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете години ");
            var age = double.Parse(Console.ReadLine());

            Console.Write("Въведете пол ");
            var sex = Console.ReadLine();

            if (age >= 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (sex == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (sex == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (sex == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
