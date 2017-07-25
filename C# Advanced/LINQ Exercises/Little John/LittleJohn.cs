using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Little_John
{
    public class LittleJohn
    {
        public static void Main()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                sb.Append(Console.ReadLine());
            }

            var inputString = sb.ToString();

            var bigArrow = ">>>----->>";
            var mediumArrow = ">>----->";
            var smallArrow = ">----->";

            var bigArrowMatches = Regex.Matches(inputString, bigArrow);
            var bigArrowsCount = bigArrowMatches.Count;

            inputString = Regex.Replace(inputString, bigArrow, "");

            var mediumArrowMatches = Regex.Matches(inputString, mediumArrow);
            var mediumArrowsCount = mediumArrowMatches.Count;

            inputString = Regex.Replace(inputString, mediumArrow, "");

            var smallArrowMatches = Regex.Matches(inputString, smallArrow);
            var smallArrowsCount = smallArrowMatches.Count;

            var concatinatedArrowCounts = 100 * smallArrowsCount + 10 * mediumArrowsCount + bigArrowsCount;
            var concatinatedArrowCountsInBinary = Convert.ToString(concatinatedArrowCounts, 2);
            var resultInBinary = concatinatedArrowCountsInBinary + string.Join("", concatinatedArrowCountsInBinary.Reverse());
            var resultInDecimal = Convert.ToInt32(resultInBinary, 2);

            Console.WriteLine(resultInDecimal);
        }
    }
}
