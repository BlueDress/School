using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var usernameTime = new SortedDictionary<string, int>();
            var usernameIp = new Dictionary<string, List<string>>();

            var n = int.Parse(Console.ReadLine());

            for (int input = 0; input < n; input++)
            {
                var inputCommands = Console.ReadLine().Split().ToList();

                var ip = inputCommands[0];
                var username = inputCommands[1];
                var time = int.Parse(inputCommands[2]);

                if (!usernameTime.ContainsKey(username))
                {
                    usernameTime[username] = 0;
                }
                usernameTime[username] += time;

                if (!usernameIp.ContainsKey(username))
                {
                    usernameIp[username] = new List<string>();
                }
                if (!usernameIp[username].Contains(ip))
                {
                    usernameIp[username].Add(ip);
                    usernameIp[username].Sort();
                }
            }

            foreach (var name in usernameTime)
            {
                Console.Write($"{name.Key}: {name.Value} ");
                var tempString = string.Empty;
                foreach (var item in usernameIp[name.Key])
                {
                    tempString += (item + ", ");
                }
                var printString = tempString.Remove(tempString.Length - 2, 2);
                Console.WriteLine($"[{printString}]");
            }
        }
    }
}
