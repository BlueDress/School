using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SpyGram
{
    public class SpyGram
    {
        public static void Main()
        {
            var privateKey = Console.ReadLine();

            var privateKeyToNumbers = StringToNumbers(privateKey);

            var messages = new Dictionary<string, string>();

            while (true)
            {
                var message = Console.ReadLine();

                if (message.Equals("END"))
                {
                    break;
                }
                else
                {
                    var pattern = @"TO:\s[A-Z]+;\sMESSAGE:\s.*;";
                    var regex = new Regex(pattern);
                    var match = regex.Match(message).ToString();

                    if (message.Equals(match))
                    {
                        var sender = string.Join("", message.Skip(4).TakeWhile(x => x != ';').ToArray());

                        if (!messages.ContainsKey(sender))
                        {
                            messages[sender] = message;
                        }
                    }
                }
            }

            foreach (var message in messages.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{EncryptMessage(message.Value, privateKeyToNumbers)}");
            }
        }

        private static int[] StringToNumbers(string privateKey)
        {
            var privateKeyToNumbers = new int[privateKey.Length];

            for (int i = 0; i < privateKey.Length; i++)
            {
                privateKeyToNumbers[i] = privateKey[i] - '0';
            }

            return privateKeyToNumbers;
        }

        private static string EncryptMessage(string message, int[] privateKey)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                var currentChar = (char)(message[i] + privateKey[i % privateKey.Length]);

                sb = sb.Append(currentChar);
            }

            return sb.ToString();
        }
    }
}
