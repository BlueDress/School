using System;
using System.Collections.Generic;

namespace Ch19P08
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> priorityQueue;

        public PriorityQueue()
        {
            this.priorityQueue = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.priorityQueue.Count;
            }
        }

        public void Insert(T item)
        {
            this.priorityQueue.Add(item);

            int childIndex = this.Count - 1;

            while (true)
            {
                if (this.priorityQueue[childIndex].CompareTo(this.priorityQueue[(childIndex - 1) / 2]) < 0 || childIndex == 0)
                {
                    break;
                }

                int parentIndex = (childIndex - 1) / 2;

                this.Swap(childIndex, parentIndex);

                childIndex = this.priorityQueue.IndexOf(priorityQueue[parentIndex]);
            }
        }

        public T Peek()
        {
            return this.priorityQueue[0];
        }

        public T Pull()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T item = this.priorityQueue[0];

            this.Swap(0, this.Count - 1);
            this.priorityQueue.RemoveAt(this.Count - 1);

            int parentIndex = 0;

            while (true)
            {
                if (parentIndex >= this.Count / 2)
                {
                    break;
                }

                if (this.Count > 2 * parentIndex + 2 && this.priorityQueue[2 * parentIndex + 1].CompareTo(this.priorityQueue[2 * parentIndex + 2]) <= 0 && this.priorityQueue[parentIndex].CompareTo(this.priorityQueue[2 * parentIndex + 2]) <= 0)
                {
                    this.Swap(parentIndex, 2 * parentIndex + 2);

                    parentIndex = 2 * parentIndex + 2;
                }
                else if (this.priorityQueue[parentIndex].CompareTo(this.priorityQueue[2 * parentIndex + 1]) <= 0)
                {
                    this.Swap(parentIndex, 2 * parentIndex + 1);

                    parentIndex = 2 * parentIndex + 1;
                }
                else
                {
                    break;
                }
            }

            return item;
        }

        private void Swap(int childIndex, int parentIndex)
        {
            T temp = this.priorityQueue[childIndex];
            this.priorityQueue[childIndex] = this.priorityQueue[parentIndex];
            this.priorityQueue[parentIndex] = temp;
        }
    }
}
