using System;

namespace Linked_List_Traversal
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var intLinkedList = new LinkedList<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var commandArgs = Console.ReadLine().Split();
                var command = commandArgs[0];

                if (command.Equals("Add"))
                {
                    intLinkedList.Add(int.Parse(commandArgs[1]));
                }
                else
                {
                    intLinkedList.Remove(int.Parse(commandArgs[1]));
                }
            }

            Console.WriteLine(intLinkedList.Count);

            foreach (var intItem in intLinkedList)
            {
                Console.Write(intItem + " ");
            }

            Console.WriteLine();
        }
    }
}
