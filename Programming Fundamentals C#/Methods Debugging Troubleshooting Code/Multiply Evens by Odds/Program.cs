using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        public static int SumOfEvenDigids(int number)
        {
            var sum = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0) sum += digit;
            }
            return sum;
        }
        public static int SumOfOddDigids(int number)
        {
            var sum = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 != 0) sum += digit;
            }
            return sum;
        }
        public static int MultipleOfSums(int number)
        {
            var result = SumOfEvenDigids(number) * SumOfOddDigids(number);
            return result;
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var result = MultipleOfSums(number);
            Console.WriteLine(result);
        }
    }
}
