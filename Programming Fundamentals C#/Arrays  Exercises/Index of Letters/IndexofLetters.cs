using System;

namespace Index_of_Letters
{
    class IndexofLetters
    {
        static void Main()
        {
            char[] Alphabet = new char[26];

            for (int i = 0; i < Alphabet.Length; i++)
            {
                Alphabet[i] = (char)('a' + i);
            }
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (input[i] == Alphabet[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
