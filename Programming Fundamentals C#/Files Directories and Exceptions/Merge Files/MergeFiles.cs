using System;
using System.Collections.Generic;
using System.IO;

namespace Merge_Files
{
    public class MergeFiles
    {
        public static void Main()
        {
            var firstInput = File.ReadAllLines("Input1.txt");
            var secondInput = File.ReadAllLines("Input2.txt");

            var output = new List<string>();

            for (int i = 0; i < firstInput.Length; i++)
            {
                output.Add(firstInput[i]);
                output.Add(secondInput[i]);
            }

            foreach (var item in output)
            {
                File.AppendAllText("output.txt", item + Environment.NewLine);
            }
        }
    }
}
