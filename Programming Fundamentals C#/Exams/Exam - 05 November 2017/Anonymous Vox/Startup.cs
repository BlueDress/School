using System;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    public class Startup
    {
        public static void Main()
        {
            var encodedText = Console.ReadLine();
            var values = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = @"([a-zA-Z]+)(.+)(\1)";

            var matches = Regex.Matches(encodedText, pattern);

            for (int i = 0; i < Math.Min(values.Length, matches.Count); i++)
            {
                var index = encodedText.IndexOf(matches[i].Groups[2].ToString());
                encodedText = encodedText.Remove(index, matches[i].Groups[2].ToString().Length);
                encodedText = encodedText.Insert(index, values[i]);
            }

            Console.WriteLine(encodedText);
        }
    }
}
