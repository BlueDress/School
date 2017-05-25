using System;

namespace Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static int CharMultiplier(string firstString, string secondString)
        {
            var result = 0;

            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                result += firstString[i] * secondString[i];
            }

            var longerStringTail = string.Empty;

            if (firstString.Length > secondString.Length)
            {
                longerStringTail = firstString.Remove(0, secondString.Length);
            }
            else if (firstString.Length < secondString.Length)
            {
                longerStringTail = secondString.Remove(0, firstString.Length);
            }

            for (int i = 0; i < longerStringTail.Length; i++)
            {
                result += longerStringTail[i];
            }

            return result;
        }

        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var result = CharMultiplier(input[0], input[1]);
            Console.WriteLine(result);
        }
    }
}
