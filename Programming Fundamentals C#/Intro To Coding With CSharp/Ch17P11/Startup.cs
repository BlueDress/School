using System;
using System.IO;

namespace Ch17P11
{
    public class Startup
    {
        public static void Main()
        {
            string path = @"E:\For Watching\";

            string[] directories = Directory.GetDirectories(path);

            PrintExeFiles(directories);
        }

        private static void PrintExeFiles(string[] directories)
        {
            foreach (string directory in directories)
            {
                string[] subDirectories = Directory.GetDirectories(directory);

                if (subDirectories.Length == 0)
                {
                    string[] files = Directory.GetFiles(directory);

                    foreach (string file  in files)
                    {
                        if (file.ToLower().EndsWith(".srt"))
                        {
                            Console.WriteLine(file);
                        }
                    }
                }
                else
                {
                    PrintExeFiles(subDirectories);
                }
            }
        }
    }
}
