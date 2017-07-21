using System;
using System.Linq;

namespace FirstName
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine().Split().OrderBy(x => x).ToArray();
            var hasMatch = false;

            foreach (var name in names)
            {
                foreach (var letter in letters)
                {
                    if (name.StartsWith(letter))
                    {
                        Console.WriteLine(name);
                        hasMatch = true;
                        return;
                    }
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
