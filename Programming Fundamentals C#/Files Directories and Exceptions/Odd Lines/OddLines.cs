using System;
using System.IO;

namespace Odd_Lines
{
    public class OddLines
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

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
