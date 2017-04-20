using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дума ");
            var word = Console.ReadLine();

            if (word == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }
}
