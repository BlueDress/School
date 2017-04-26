using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers
{
    class Program
    {
        public static bool SymetricCheck(string number)
        {
            var count = 0;
            bool check = true;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] == number[count])
                {
                    count++;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        public static bool DivisibleBySeven(string number)
        {
            var sum = 0;
            bool check = true;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + (number[i] - '0');
            }
            if (sum % 7 != 0)
            {
                check = false;
            }
            return check;
        }
        public static bool OneEvenDigit(string number)
        {
            bool check = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (SymetricCheck(i.ToString()) && DivisibleBySeven(i.ToString()) && OneEvenDigit(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
             
        }
    }
}
