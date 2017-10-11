using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            double[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            bool found = false;

            for (int j = 0; j < input.Length; j++)
            {
                double currentNum = input[j];

                if (currentNum >= 0)
                {

                    Console.Write(currentNum + " ");

                    found = true;
                }
                else
                {
                    if (j < input.Length - 1)
                    {
                        currentNum += input[j + 1];
                    }

                    j++;

                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum + " ");
                        found = true;
                    }
                }

            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}