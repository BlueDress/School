using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var numberOfOperations = int.Parse(Console.ReadLine());

            var operations = new Stack<string>();
            var elements = new Stack<string>();

            var sb = new StringBuilder();
            sb.Append("");

            for (int i = 0; i < numberOfOperations; i++)
            {
                var commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        sb.Append(commands[1]);
                        operations.Push("1");
                        elements.Push(commands[1]);
                        break;
                    case "2":
                        var count = int.Parse(commands[1]);
                        var removedString = sb.ToString().Skip(sb.Length - count);
                        sb.Remove(sb.Length - count, count);
                        operations.Push("2");
                        elements.Push(string.Join("", removedString));
                        break;
                    case "3":
                        var index = int.Parse(commands[1]);
                        var element = sb[index - 1];
                        Console.WriteLine(element);
                        break;
                    case "4":
                        var checkPreviousOperation = operations.Pop();
                        var lastElement = elements.Pop();

                        if (checkPreviousOperation.Equals("1"))
                        {
                            sb.Remove(sb.Length - lastElement.Length, lastElement.Length);
                        }
                        else
                        {
                            sb.Append(lastElement);
                        }
                        break;
                }
            }
        }
    }
}
