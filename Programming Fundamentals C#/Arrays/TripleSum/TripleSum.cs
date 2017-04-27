using System;

namespace TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(); 
            var numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            bool check = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var sum = numbers[i] + numbers[j];
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (sum == numbers[k])
                        {
                            check = true;
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            break;
                        }
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
