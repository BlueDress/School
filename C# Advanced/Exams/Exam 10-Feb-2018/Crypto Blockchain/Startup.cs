using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptoBlockchain
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();

                sb.Append(line);
            }

            var blockChain = sb.ToString();
            var pattern = @"[{\[].*?[}\]]";
            var numberPattern = @"\d{3,}";

            var matches = Regex.Matches(blockChain, pattern);

            var cryptoBlocks = new List<string>();

            foreach (Match match in matches)
            {
                var startSymbol = match.ToString()[0];
                var lastSymbol = match.ToString()[match.Length - 1];

                if (((startSymbol.Equals('[') && lastSymbol.Equals(']')) || ((startSymbol.Equals('{') && lastSymbol.Equals('}'))) && Regex.IsMatch(match.ToString(), numberPattern)))
                {
                    cryptoBlocks.Add(match.ToString());
                }
            }

            sb.Clear();

            foreach (var block in cryptoBlocks)
            {
                var validBlock = Regex.Match(block, numberPattern).ToString();

                if (validBlock.Length % 3 == 0)
                {
                    for (int i = 0; i < validBlock.Length; i += 3)
                    {
                        var asciiNumber = int.Parse($"{validBlock[i]}{validBlock[i + 1]}{validBlock[i + 2]}") - block.Length;
                        var symbol = Convert.ToChar(asciiNumber);

                        sb.Append(symbol);
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
