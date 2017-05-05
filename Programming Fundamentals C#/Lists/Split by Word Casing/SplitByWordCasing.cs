using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int item = 0; item < input.Count; item++)
            {
                char[] tempArray = input[item].ToArray();
                var lowerCaseCount = 0;
                var upperCaseCount = 0;

                for (int index = 0; index < tempArray.Length; index++)
                {
                    if (tempArray[index] - 'a' >= 0 && tempArray[index] - 'a' <= 25)
                    {
                        lowerCaseCount++;
                    }
                    else if (tempArray[index] - 'A' >= 0 && tempArray[index] - 'A' <= 25)
                    {
                        upperCaseCount++;
                    }

                }
                if (lowerCaseCount == tempArray.Length)
                {
                    lowerCase.Add(input[item]);
                }
                else if (upperCaseCount == tempArray.Length)
                {
                    upperCase.Add(input[item]);
                }
                else
                {
                    mixedCase.Add(input[item]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
