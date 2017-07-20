using System;

namespace Parse_URLs
{
    public class ParseURLs
    {
        public static void Main()
        {
            var inputUrl = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (inputUrl.Length != 2)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var protocol = inputUrl[0];

                var splitIndex = inputUrl[1].IndexOf('/');

                if (splitIndex == -1)
                {
                    Console.WriteLine("Invalid URL");
                }
                else
                {
                    var server = inputUrl[1].Substring(0, splitIndex);
                    var resources = inputUrl[1].Substring(splitIndex + 1);
                    Console.WriteLine($"Protocol = {protocol}\nServer = {server}\nResources = {resources}");
                }
            }
        }
    }
}
