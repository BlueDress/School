using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexademical = Console.ReadLine();
            Console.WriteLine(Convert.ToInt16(hexademical, 16));
        }
    }
}
