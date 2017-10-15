using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    public class ChangeList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("Odd"))
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                    break;
                }

                if (command.Equals("Even"))
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                    break;
                }

                var args = command.Split();
                var action = args[0];
                var number = int.Parse(args[1]);

                if (action.Equals("Delete"))
                {
                    numbers.RemoveAll(n => n == number);
                }
                else
                {
                    var index = int.Parse(args[2]);
                    numbers.Insert(index, number);
                }
            }
        }
    }
}
