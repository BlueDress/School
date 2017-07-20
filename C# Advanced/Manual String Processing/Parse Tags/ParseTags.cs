using System;

namespace Parse_Tags
{
    public class ParseTags
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            while (true)
            {
                var startIndex = inputText.IndexOf(openTag);
                var endIndex = inputText.IndexOf(closeTag);

                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }
                else
                {
                    var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                    var replacer = toBeReplaced.Substring(openTag.Length, toBeReplaced.Length - openTag.Length - closeTag.Length).ToUpper();

                    inputText = inputText.Replace(toBeReplaced, replacer);
                }
            }

            Console.WriteLine(inputText);
        }
    }
}
