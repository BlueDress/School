using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Meditation
{
    public class JediMeditation
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());
            var padawans = new Queue<string>();
            var knights = new Queue<string>();
            var masters = new Queue<string>();
            var toshkoAndSlav = new Queue<string>();
            var yodaIsPresent = false;

            for (int i = 0; i < numberOfEntries; i++)
            {
                var jedi = Console.ReadLine().Split();

                for (int j = 0; j < jedi.Length; j++)
                {
                    if (jedi[j].StartsWith("m"))
                    {
                        masters.Enqueue(jedi[j]);
                    }
                    else if (jedi[j].StartsWith("k"))
                    {
                        knights.Enqueue(jedi[j]);
                    }
                    else if (jedi[j].StartsWith("p"))
                    {
                        padawans.Enqueue(jedi[j]);
                    }
                    else if (jedi[j].StartsWith("s") || jedi[j].StartsWith("t"))
                    {
                        toshkoAndSlav.Enqueue(jedi[j]);
                    }
                    else
                    {
                        yodaIsPresent = true;
                    }
                }
            }

            var jediMeditationOrder = new Queue<string>();

            if (yodaIsPresent)
            {
                Console.WriteLine(string.Join(" ", jediMeditationOrder.Concat(masters).Concat(knights).Concat(toshkoAndSlav).Concat(padawans)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", jediMeditationOrder.Concat(toshkoAndSlav).Concat(masters).Concat(knights).Concat(padawans)));
            }
        }
    }
}
