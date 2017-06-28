using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var symbols = Console.ReadLine().ToCharArray();
            var symbolsCount = new SortedDictionary<char, int>();

            foreach (var symbol in symbols)
            {
                if (!symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount[symbol] = 0;
                }

                symbolsCount[symbol]++;
            }

            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} times/s");
            }
        }
    }
}
