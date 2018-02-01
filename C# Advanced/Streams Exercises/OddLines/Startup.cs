using System;
using System.IO;

namespace OddLines
{
    public class Startup
    {
        public static void Main()
        {
            var sr = new StreamReader("text.txt");
            var lineCounter = -1;

            using (sr)
            {
                while (true)
                {
                    var line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    lineCounter++;

                    if (lineCounter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
