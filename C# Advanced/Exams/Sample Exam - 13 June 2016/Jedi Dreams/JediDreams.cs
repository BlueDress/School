using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Jedi_Dreams
{
    public class JediDreams
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var methods = new Dictionary<string, List<string>>();
            var declaredMethodPattern = @"static.*?([A-Z]\w+)\(";
            var invokedMethodPattern = @".*?\.*?([A-Z]\w+)\(";
            var currentKey = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                var inputLine = Console.ReadLine();

                if (Regex.IsMatch(inputLine, declaredMethodPattern))
                {
                    var match = Regex.Match(inputLine, declaredMethodPattern);
                    currentKey = match.Groups[1].Value;
                    methods[currentKey] = new List<string>();
                }
                else if(Regex.IsMatch(inputLine, invokedMethodPattern))
                {
                    var matches = Regex.Matches(inputLine, invokedMethodPattern);

                    foreach (Match match in matches)
                    {
                        methods[currentKey].Add(match.Groups[1].Value);
                    }
                }
            }

            foreach (var declaredMethod in methods.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (declaredMethod.Value.Count() > 0)
                {
                    Console.WriteLine($"{declaredMethod.Key} -> {declaredMethod.Value.Count()} -> {string.Join(", ", declaredMethod.Value.OrderBy(x => x))}");
                }
                else
                {
                    Console.WriteLine($"{declaredMethod.Key} -> None");
                }
            }
        }
    }
}
