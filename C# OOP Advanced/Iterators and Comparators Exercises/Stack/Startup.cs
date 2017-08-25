using System;
using System.Linq;

namespace Stack
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input.RemoveAt(0);
            var stackData = input.Select(int.Parse).ToArray();

            var stack = new Stack<int>(stackData);

            while (true)
            {
                var commands = Console.ReadLine();

                if (commands.Equals("END"))
                {
                    break;
                }

                var tokens = commands.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = tokens[0];

                if (command.Equals("Pop"))
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    tokens.RemoveAt(0);
                    stackData = tokens.Select(int.Parse).ToArray();

                    stack.Push(stackData);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
