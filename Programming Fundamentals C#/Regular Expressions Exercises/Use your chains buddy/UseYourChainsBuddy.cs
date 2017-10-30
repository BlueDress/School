using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=<p>)[\w*\W*]*?(?=<\/p>)";

            var codes = new List<string>();

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var code = Regex.Replace(match.ToString(), @"[A-Z_\W]+", " ");
                code = Regex.Replace(code, @"\s+", " ").Trim();
                codes.Add(code);
            }

            var decryptedCodes = new List<string>();

            foreach (var code in codes)
            {
                var codeToArray = code.ToCharArray();

                for (int i = 0; i < codeToArray.Length; i++)
                {
                    if (codeToArray[i] >= 'a' && codeToArray[i] <= 'm')
                    {
                        codeToArray[i] = (char)(codeToArray[i] + 13);
                    }
                    else if (codeToArray[i] >= 'n' && codeToArray[i] <= 'z')
                    {
                        codeToArray[i] = (char)(codeToArray[i] - 13);
                    }
                }

                var decryptedCode = string.Join("", codeToArray);

                if (!decryptedCode.Equals(string.Empty))
                {
                    decryptedCodes.Add(decryptedCode);
                }
            }

            Console.WriteLine(string.Join(" ", decryptedCodes));
        }
    }
}