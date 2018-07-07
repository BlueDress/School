using System;
using System.IO;

namespace Ch10P15
{
    public class Startup
    {
        public static void Main()
        {
            string startDir = @"E:\For Watching";
            PrintDirectory(startDir);
        }

        private static void PrintDirectory(string startDir)
        {
            foreach (string directory in Directory.GetDirectories(startDir))
            {
                PrintDirectory(directory);
            }

            foreach (string file in Directory.GetFiles(startDir))
            {
                Console.WriteLine(file);
            }
        }
    }
}
