using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_оf_The_Last_Digit
{
    class Program
    {
        public static void NameOfLastDigit(int number)
        {
            string result = "";
            switch (number % 10)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            NameOfLastDigit(number);
        }
    }
}
