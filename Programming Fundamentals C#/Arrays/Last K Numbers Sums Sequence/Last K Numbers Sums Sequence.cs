using System;

namespace Last_K_Numbers_Sums_Sequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            var sum = 0;
            numbers[0] = 1;

            Console.Write(numbers[0] + " ");
            if (k > n)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i - 1];
                    numbers[i] = sum;
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i < k; i++)
                {
                    sum = sum + numbers[i - 1];
                    numbers[i] = sum;
                    Console.Write(numbers[i] + " ");
                }
                for (int i = k; i < numbers.Length; i++)
                {
                    sum = 0;
                    for (int j = 1; j <= k; j++)
                    {
                        sum = sum + numbers[i - j];
                    }
                    numbers[i] = sum;
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
