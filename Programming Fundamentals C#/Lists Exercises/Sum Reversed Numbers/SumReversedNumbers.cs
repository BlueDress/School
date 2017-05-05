using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int item = 0; item < inputList.Count; item++)
            {
                var tempList = inputList[item].ToString().ToList();
                tempList.Reverse();

                var sum = 0;
                var a = 1;
                for (int i = tempList.Count - 1; i >= 0; i--)
                {
                    sum = sum + (tempList[i] - '0') * a;
                    a = a * 10;
                }
                inputList[item] = sum;
            }

            for (int item = 0; item < inputList.Count; item++)
            {
                inputList[0] = inputList[0] + inputList[1];
                inputList.RemoveAt(1);
            }
            Console.WriteLine(inputList[0]);
        }
    }
}
