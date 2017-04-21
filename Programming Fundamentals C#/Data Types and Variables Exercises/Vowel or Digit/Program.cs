using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine().ToLower());
            
            if (symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'i' || symbol == 'u') Console.WriteLine("vowel");
            else if (symbol >= 48 && symbol <= 57) Console.WriteLine("digit");
            else Console.WriteLine("other");
        }
    }
}
