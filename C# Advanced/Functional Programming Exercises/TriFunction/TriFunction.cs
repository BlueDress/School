using System;

namespace TriFunction
{
    public class TriFunction
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> NameLengthCheck = (name, num) =>
            {
                var symbolsSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    symbolsSum += name[i];
                }

                if (symbolsSum >= num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int i = 0; i < names.Length; i++)
            {
                if (NameLengthCheck(names[i], number))
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
