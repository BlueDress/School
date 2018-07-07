using System;
using System.Numerics;

namespace Ch04P12
{
    public class Startup
    {
        public static void Main()
        {
            BigInteger firstFibonacciMember = 0;
            BigInteger secondFibonacciMember = 1;

            Console.WriteLine(firstFibonacciMember);
            Console.WriteLine(secondFibonacciMember);

            for (int i = 0; i < 99; i++)
            {
                BigInteger nextFibonacciMember = firstFibonacciMember + secondFibonacciMember;
                Console.WriteLine(nextFibonacciMember);

                firstFibonacciMember = secondFibonacciMember;
                secondFibonacciMember = nextFibonacciMember;
            }
        }
    }
}
