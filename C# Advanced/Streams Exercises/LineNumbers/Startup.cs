using System.IO;

namespace LineNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var sr = new StreamReader("text.txt");
            var sw = new StreamWriter("output.txt");
            var lineCounter = 0;

            using (sr)
            {
                using (sw)
                {
                    while (true)
                    {
                        var line = sr.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        lineCounter++;

                        sw.WriteLine($"Line{lineCounter}: {line}");
                    }
                }
            }
        }
    }
}
