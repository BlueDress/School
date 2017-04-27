using System;
namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            string[] inputFirst = Console.ReadLine().Split();
            int[] firstArray = new int[inputFirst.Length];

            for (int i = 0; i < inputFirst.Length; i++)
            {
                firstArray[i] = int.Parse(inputFirst[i]);
            }

            string[] inputSecond = Console.ReadLine().Split();
            int[] secondArray = new int[inputSecond.Length];

            for (int i = 0; i < inputSecond.Length; i++)
            {
                secondArray[i] = int.Parse(inputSecond[i]);
            }

            int[] resultArray = new int[Math.Max(inputFirst.Length, inputSecond.Length)];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstArray[i % inputFirst.Length] + secondArray[i % inputSecond.Length];                
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
