using System;

namespace Melrah_Shake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var mainString = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (mainString != string.Empty)
            {
                var firstIndex = mainString.IndexOf(pattern);
                var lastIndex = mainString.LastIndexOf(pattern);

                if (firstIndex < lastIndex && lastIndex - firstIndex >= pattern.Length && !pattern.Equals(string.Empty))
                {
                    mainString = mainString.Remove(lastIndex, pattern.Length);
                    mainString = mainString.Remove(firstIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(mainString);
        }
    }
}
