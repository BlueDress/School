using System;

namespace Generating01Vectors
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var vector = new int[n];

            PrintVectors(0, vector);
        }

        private static void PrintVectors(int index, int[] vector)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            vector[index] = 0;
            PrintVectors(index + 1, vector);

            vector[index] = 1;
            PrintVectors(index + 1, vector);
        }
    }
}
