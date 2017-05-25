using System;
using System.Text;

namespace Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append($"{((int)c).ToString("x4")}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
