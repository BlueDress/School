using System;
using System.Linq;

namespace Applied_Arithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("end"))
                {
                    break;
                }
                else
                {
                    ApplyCommand(numbers, command);
                }
            }
        }

        private static void ApplyCommand(int[] numbers, string command)
        {
            switch (command)
            {
                case "add":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] += 1;
                    }
                    break;
                case "multiply":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *= 2;
                    }
                    break;
                case "subtract":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                    break;
                case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                    break;
            }
        }
    }
}
