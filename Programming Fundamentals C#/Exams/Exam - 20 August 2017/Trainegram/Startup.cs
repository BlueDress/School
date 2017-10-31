using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trainegram
{
    public class Startup
    {
        public static void Main()
        {
            var trains = new List<string>();

            var pattern = @"^(<\[[^a-zA-Z0-9]*\]\.){1}(\.\[[a-zA-Z0-9]*\]\.)*?$";

            while (true)
            {
                var trainWannaBe = Console.ReadLine();

                if (trainWannaBe.Equals("Traincode!"))
                {
                    break;
                }

                var match = Regex.Match(trainWannaBe, pattern).ToString();

                if (match.Equals(trainWannaBe))
                {
                    trains.Add(trainWannaBe);
                }
            }

            trains.ForEach(train => Console.WriteLine(train));
        }
    }
}
