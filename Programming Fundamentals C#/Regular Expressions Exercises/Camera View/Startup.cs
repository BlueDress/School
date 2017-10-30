using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Camera_View
{
    public class Startup
    {
        public static void Main()
        {
            var args = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elementsToSkip = args[0];
            var elementsToTake = args[1];

            var camerasString = Console.ReadLine();

            var numberOfMatches = Regex.Matches(camerasString, @"\|<").Count;

            var cameras = camerasString.Split(new[] { "|<" }, StringSplitOptions.None).ToList();

            if (numberOfMatches != cameras.Count)
            {
                cameras.RemoveAt(0);
            }

            var views = new List<string>();

            for (int i = 0; i < cameras.Count; i++)
            {
                var view = string.Join("", cameras[i].Skip(elementsToSkip).Take(elementsToTake));

                if (!view.Equals(string.Empty))
                {
                    views.Add(view);
                }
            }

            Console.WriteLine(string.Join(", ", views));
        }
    }
}
