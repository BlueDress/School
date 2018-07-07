using System.IO;

namespace Ch15P03
{
    public class Startup
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader("text.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            int lineCounter = 0;

            using (sr)
            {
                using (sw)
                {
                    while (true)
                    {
                        string line = sr.ReadLine();

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
