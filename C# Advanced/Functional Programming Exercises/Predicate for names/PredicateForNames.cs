using System;

namespace Predicate_for_names
{
    public class PredicateForNames
    {
        public static void Main()
        {
            var nameLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> CheckLength = x => x.Length <= nameLength;
            Action<string> PrintName = str => Console.WriteLine(str);

            foreach (var name in names)
            {
                if (CheckLength(name))
                {
                    PrintName(name);
                }
            }
        }
    }
}
