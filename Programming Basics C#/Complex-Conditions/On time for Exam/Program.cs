using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_time_for_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете час на изпита ");
            var h1 = int.Parse(Console.ReadLine());

            Console.Write("Въведете минути на изпита ");
            var m1 = int.Parse(Console.ReadLine());

            Console.Write("Въведете час на пристигане ");
            var h2 = int.Parse(Console.ReadLine());

            Console.Write("Въведете минути на пристигане ");
            var m2 = int.Parse(Console.ReadLine());

            var v = 0;

            if (m2 > m1)
            {
                if (h2 > h1)
                {
                    Console.WriteLine("Late");
                    v = 1;
                }
                else if (h2 == h1)
                {
                    Console.WriteLine("Late");
                    v = 2;
                }
                else if (h2 == h1 - 1)
                {
                    if (m2 - m1 >= 30)
                    {
                        Console.WriteLine("On time");
                        v = 3;
                    }
                    else    // m2 - m1 < 30
                    {
                        Console.WriteLine("Early");
                        v = 4;
                    }
                }
                else    // h2 < h1 - 1
                {
                    Console.WriteLine("Early");
                    v = 5;
                }
            }
            else if (m2 == m1)
            {
                if (h2 > h1)
                {
                    Console.WriteLine("Late");
                    v = 6;
                }
                else if (h2 == h1)
                {
                    Console.WriteLine("On time");                    
                }
                else    // h2 < h1
                {
                    Console.WriteLine("Early");
                    v = 7;
                }
            }
            else      // m2 < m1
            {
                if (h2 > h1 + 1)
                {
                    Console.WriteLine("Late");
                    v = 8;
                }
                else if (h2 == h1 + 1)
                {
                    Console.WriteLine("Late");
                    v = 9;
                }
                else if (h2 == h1)
                {
                    if (m1 - m2 > 30)
                    {
                        Console.WriteLine("Early");
                        v = 10;
                    }
                    else  // m1 - m2 <= 30
                    {
                        Console.WriteLine("On time");
                        v = 11;
                    }
                }
                else   // h2 < h1
                {
                    Console.WriteLine("Early");
                    v = 12;
                }
            }

            switch (v)
            {
                case 1:
                    if (m2 - m1 >= 10)
                    {
                        Console.WriteLine($"{h2 - h1}:{m2 - m1} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{h2 - h1}:0{m2 - m1} hours after the start");
                    }
                        break;
                case 2: Console.WriteLine($"{m2 - m1} minutes after the start"); break;
                case 3: Console.WriteLine($"{60 - (m2 - m1)} minutes before the start"); break;
                case 4: Console.WriteLine($"{60 - (m2 - m1)} minutes before the start"); break;
                case 5:
                    if (m2 - m1 >= 10)
                    {
                        Console.WriteLine($"{(h1 - h2) - 1}:{60 - (m2 - m1)} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(h1 - h2) - 1}:0{60 - (m2 - m1)} hours before the start");
                    }
                    break;
                case 6: Console.WriteLine($"{h2 - h1}:0{m2 - m1} hours after the start"); break;
                case 7: Console.WriteLine($"{h1 - h2}:0{m2 - m1} hours before the start"); break;
                case 8:
                    if (m1 - m2 > 50)
                    {
                        Console.WriteLine($"{(h2 - h1) - 1}:0{60 - (m1 - m2)} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(h2 - h1) - 1}:{60 - (m1 - m2)} hours after the start");
                    }
                    break;
                case 9: Console.WriteLine($"{60 - (m1 - m2)} minutes after the start"); break;
                case 10: Console.WriteLine($"{m1 - m2} minutes before the start"); break;
                case 11: Console.WriteLine($"{m1 - m2} minutes before the start"); break;
                case 12:
                    if (m1 - m2 >= 10)
                    {
                        Console.WriteLine($"{h1 - h2}:{m1 - m2} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{h1 - h2}:0{m1 - m2} hours after the start");
                    }
                    break;
            }
        }
    }
}
