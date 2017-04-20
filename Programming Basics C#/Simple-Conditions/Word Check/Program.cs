using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първата дума ");
            var firstword = Console.ReadLine();

            Console.Write("Въведете втората дума ");
            var secword = Console.ReadLine();
                     
            if ((firstword = firstword.ToLower()) == (secword = secword.ToLower()))
            {
                Console.WriteLine("Думите са еднакви");
            }
            else
            {
                Console.WriteLine("Думите са различни");
            }
        }
    }
}
