using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var inputCommands = Console.ReadLine().Split().ToList();

                if (inputCommands[0] == "end")
                {
                    break;
                }
                else
                {
                    var getUserName = inputCommands[2].Split('=');
                    var userName = getUserName[1];

                    var getIp = inputCommands[0].Split('=');
                    var ip = getIp[1];

                    if (!result.ContainsKey(userName))
                    {
                        result[userName] = new Dictionary<string, int>();
                    }
                    if (!result[userName].ContainsKey(ip))
                    {
                        result[userName][ip] = 0;
                    }
                    result[userName][ip]++; 
                }
            }
            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key}:");
                var tempString = string.Empty;    
                foreach (var ip in user.Value)
                {
                    tempString += ($"{ip.Key} => {ip.Value}, ");  
                }
                var printString = tempString.Remove(tempString.Length - 2, 2);
                printString += ".";
                Console.WriteLine(printString); 
            }            
        }
    }
}
