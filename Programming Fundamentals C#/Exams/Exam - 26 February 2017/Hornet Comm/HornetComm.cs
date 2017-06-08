using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Hornet_Comm
{
    public class HornetComm
    {
        public static void Main()
        {
            var broadcasts = new List<Broadcast>();
            var messages = new List<Message>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Hornet is Green"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var firstQuery = tokens[0];
                    var secondQuery = tokens[2];

                    var onlyDigitsPattern = @"\b[0-9]+\b";
                    var anythingButDigitsPattern = @"[^0-9]+";
                    var digitsAndOrLettersPattern = @"\b[0-9a-zA-Z]+\b";

                    var messageCheck = Regex.Match(firstQuery, onlyDigitsPattern);
                    var broadcastCheck = Regex.Match(firstQuery, anythingButDigitsPattern);
                    var secondQueryCheck = Regex.Match(secondQuery, digitsAndOrLettersPattern);

                    if (firstQuery.Length == messageCheck.Length && secondQuery.Length == secondQueryCheck.Length)
                    {
                        var message = ReverseString(firstQuery);

                        var newMessage = new Message
                        {
                            Recipient = message,
                            MessageText = secondQuery
                        };

                        messages.Add(newMessage);
                    }
                    else if (firstQuery.Length == broadcastCheck.Length && secondQuery.Length == secondQueryCheck.Length)
                    {
                        var casingChanged = ChangeCasingOfLetters(secondQuery);

                        var newBroadcast = new Broadcast
                        {
                            Frequency = casingChanged,
                            MessageText = firstQuery
                        };

                        broadcasts.Add(newBroadcast);
                    }
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.MessageText}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Recipient} -> {message.MessageText}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

        }

        private static string ChangeCasingOfLetters(string s)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    sb.Append(char.ToUpper(s[i], CultureInfo.InvariantCulture));
                }
                else if (char.IsUpper(s[i]))
                {
                    sb.Append(char.ToLower(s[i], CultureInfo.InvariantCulture));
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            var result = sb.ToString();
            return result;
        }

        public static string ReverseString(string s)
        {
            var reversedInput = s.Reverse();

            var result = new StringBuilder();

            foreach (var item in reversedInput)
            {
                result = result.Append(item);
            }
            return result.ToString();
        }
    }
}
