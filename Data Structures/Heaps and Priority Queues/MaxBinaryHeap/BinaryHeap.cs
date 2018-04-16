using System;
using System.Collections.Generic;

namespace MaxBinaryHeap
{
    public class BinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heap;

        public BinaryHeap()
        {
            this.heap = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.heap.Count;
            }
        }

        public void Insert(T item)
        {
            this.heap.Add(item);

            var childIndex = this.Count - 1;

            while (true)
            {
                if (this.heap[childIndex].CompareTo(this.heap[(childIndex - 1) / 2]) < 0 || childIndex == 0)
                {
                    break;
                }

                var parentIndex = (childIndex - 1) / 2;

                this.Swap(childIndex, parentIndex);

                childIndex = this.heap.IndexOf(heap[parentIndex]);
            }
        }

        public T Peek()
        {
            return this.heap[0];
        }

        public T Pull()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var item = this.heap[0];

            this.Swap(0, this.Count - 1);
            this.heap.RemoveAt(this.Count - 1);

            var parentIndex = 0;

            while (true)
            {
                if (parentIndex >= this.Count / 2)
                {
                    break;
                }

                if (this.Count > 2 * parentIndex + 2 && this.heap[2 * parentIndex + 1].CompareTo(this.heap[2 * parentIndex + 2]) <= 0 && this.heap[parentIndex].CompareTo(this.heap[2 * parentIndex + 2]) <= 0)
                {
                    this.Swap(parentIndex, 2 * parentIndex + 2);

                    parentIndex = 2 * parentIndex + 2;
                }
                else if (this.heap[parentIndex].CompareTo(this.heap[2 * parentIndex + 1]) <= 0)
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
            var temp = this.heap[childIndex];
            this.heap[childIndex] = this.heap[parentIndex];
            this.heap[parentIndex] = temp;
        }
    }
}
