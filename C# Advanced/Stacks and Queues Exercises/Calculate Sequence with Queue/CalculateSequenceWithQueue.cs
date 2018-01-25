using System;
using System.Collections.Generic;

namespace Calculate_Sequence_with_Queue
{
    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var firstElement = long.Parse(Console.ReadLine());

            var temporaryQueue = new Queue<long>();
            var queueToPrint = new Queue<long>();

            temporaryQueue.Enqueue(firstElement);

            while (queueToPrint.Count < 50)
            {
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(2 * temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 2);
                queueToPrint.Enqueue(temporaryQueue.Dequeue());
            }

            Console.WriteLine(string.Join(" ", queueToPrint));
        }
    }
}
