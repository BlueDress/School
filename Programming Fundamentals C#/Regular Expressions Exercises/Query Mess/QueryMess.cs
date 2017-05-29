using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Query_Mess
{
    public class QueryMess
    {
        public static void Main()
        {
            var result = new List<Dictionary<string, List<string>>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var queryStrings = input.Split(new[] { '?', '&' }, StringSplitOptions.RemoveEmptyEntries);

                    var keyValuePairs = new Dictionary<string, List<string>>();

                    foreach (var query in queryStrings)
                    {

                        if (query.Contains("="))
                        {
                            var keyValuePair = query.Split('=');

                            keyValuePair[0] = Regex.Replace(keyValuePair[0], @"%20", " ");
                            keyValuePair[0] = Regex.Replace(keyValuePair[0], @"\+", " ");
                            keyValuePair[0] = Regex.Replace(keyValuePair[0], @"\s+", " ").Trim();

                            keyValuePair[1] = Regex.Replace(keyValuePair[1], @"%20", " ");
                            keyValuePair[1] = Regex.Replace(keyValuePair[1], @"\+", " ");
                            keyValuePair[1] = Regex.Replace(keyValuePair[1], @"\s+", " ").Trim();

                            if (!keyValuePairs.ContainsKey(keyValuePair[0]))
                            {
                                keyValuePairs[keyValuePair[0]] = new List<string>();
                            }

                            keyValuePairs[keyValuePair[0]].Add(keyValuePair[1]);
                        }
                    }
                    result.Add(keyValuePairs);
                }
            }

            foreach (var dictionary in result)
            {
                foreach (var key in dictionary)
                {
                    Console.Write($"{key.Key}=[{string.Join(", ", key.Value)}]");
                }
                Console.WriteLine();
            }
        }
    }
}
