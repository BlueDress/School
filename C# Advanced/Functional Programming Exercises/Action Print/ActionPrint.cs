using System;

namespace Action_Print
{
    public class ActionPrint
    {
        public static void Main()
        {
            Action<string> PrintString = x => Console.WriteLine(x);

            var tokens = Console.ReadLine().Split();

            for (int i = 0; i < tokens.Length; i++)
            {
                PrintString(tokens[i]);
            }
        }
    }
}
