using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.collection = new List<T>(elements);
            this.currentIndex = 0;
        }

        public bool Move()
        {
            if (this.currentIndex < this.collection.Count - 1)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex == this.collection.Count - 1)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.currentIndex < this.collection.Count)
            {
                Console.WriteLine(this.collection[this.currentIndex]);
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
