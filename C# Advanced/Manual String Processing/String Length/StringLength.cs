using System;

namespace String_Length
{
    public class StringLength
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var textToPrint = string.Empty;

            if (inputText.Length < 20)
            {
                textToPrint = inputText.PadRight(20, '*');
            }
            else
            {
                textToPrint = inputText.Substring(0, 20);
            }

            Console.WriteLine(textToPrint);
        }
    }
}
