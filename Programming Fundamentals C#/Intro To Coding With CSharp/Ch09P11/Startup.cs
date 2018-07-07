using System;
using System.Linq;

namespace Ch09P11
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter number for action:");
            Console.WriteLine("1 - Reversing digits");
            Console.WriteLine("2 - Calculate average");
            Console.WriteLine("3 - Solving eqation");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Enter number:");
                    int number = int.Parse(Console.ReadLine());

                    Console.WriteLine(ReverseDigits(number)); 
                    break;
                case 2:
                    Console.Write("Enter numbers separated by empty space:");
                    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    Console.WriteLine($"Average is: {CalculateAverage(numbers)}");
                    break;
                case 3:
                    Console.Write("Enter coefficient before X:");
                    int coefficientBeforeX = int.Parse(Console.ReadLine());

                    Console.Write("Enter free coefficient:");
                    int freeCoefficient = int.Parse(Console.ReadLine());

                    Console.WriteLine($"X is equal to: {CalculateX(coefficientBeforeX, freeCoefficient)}");
                    break;
                default:
                    throw new Exception("You must enter number between 1 and 3 both inclusive.");
            }
        }

        private static string ReverseDigits(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must be positive.");
            }

            return string.Join("", number.ToString().Reverse());
        }

        private static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("There should be atleast one number.");
            }

            return numbers.Average();
        }

        private static double CalculateX(int coefficientBeforeX, int freeCoefficient)
        {
            if (coefficientBeforeX == 0)
            {
                throw new ArgumentException("The coefficient before X should not be equal to 0.");
            }

            return (freeCoefficient * (-1)) / coefficientBeforeX;
        }
    }
}
