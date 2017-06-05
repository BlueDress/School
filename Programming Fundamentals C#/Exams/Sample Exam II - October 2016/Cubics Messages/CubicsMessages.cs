using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubics_Messages
{
    public class CubicsMessages
    {
        public static void Main()
        {
            var validMessages = new List<string>();

            while (true)
            {
                var inputString = Console.ReadLine();

                if (inputString.Equals("Over!"))
                {
                    break;
                }
                else
                {
                    var lenghtOfMessage = int.Parse(Console.ReadLine());

                    var pattern = $@"\d+[a-zA-Z]{{{lenghtOfMessage}}}[^a-zA-Z]*";
                    var matchCheck = Regex.Match(inputString, pattern).ToString();

                    if (inputString.Equals(matchCheck))
                    {
                        validMessages.Add(inputString);
                    }
                }
            }

            var messageCode = new Dictionary<string, string>();

            foreach (var validMessage in validMessages)
            {
                var numbers = new List<int>();
                var sb = new StringBuilder();

                foreach (var symbol in validMessage)
                {

                    if (char.IsNumber(symbol))
                    {
                        numbers.Add(symbol - '0');
                    }
                    else if (char.IsLetter(symbol))
                    {
                        sb.Append(symbol);
                    }
                }

                var message = sb.ToString();

                sb = sb.Clear();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < 0 || numbers[i] >+ message.Length)
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append(message[numbers[i]]);
                    }
                }

                var verificationCode = sb.ToString();

                messageCode[message] = verificationCode;
            }

            foreach (var kvp in messageCode)
            {
                Console.WriteLine($"{kvp.Key} == {kvp.Value}");
            }
        }
    }
}
