using System;
using System.IO;

namespace Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var input = new string[]
            {
                "Two households, both alike in dignity,",
                "In fair Verona, where we lay our scene,",
                "From ancient grudge break to new mutiny,",
                "Where civil blood makes civil hands unclean.",
                "From forth the fatal loins of these two foes",
                "A pair of star-cross'd lovers take their life;",
                "Whose misadventured piteous overthrows",
                "Do with their death bury their parents' strife."
            };

            File.WriteAllLines("input.txt", input);

            var text = File.ReadAllLines("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. " + text[i] + Environment.NewLine);
            }
        }
    }
}
