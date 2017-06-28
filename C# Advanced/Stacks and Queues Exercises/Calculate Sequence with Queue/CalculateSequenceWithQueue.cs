using System;
using System.Collections.Generic;

namespace Calculate_Sequence_with_Queue
{
    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var firstElement = int.Parse(Console.ReadLine());

            var temporaryQueue = new Queue<int>();
            var queueToPrint = new Queue<int>();

            temporaryQueue.Enqueue(firstElement);

            while (queueToPrint.Count < 50)
            {
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(2 * temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 2);
                queueToPrint.Enqueue(temporaryQueue.Dequeue());
            }

            var result = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                result.Add(queueToPrint.Dequeue());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
