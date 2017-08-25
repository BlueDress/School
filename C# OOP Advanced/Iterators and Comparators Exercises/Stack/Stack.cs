using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack(params T[] elements)
        {
            this.collection = new List<T>(elements);
        }

        public void Push(params T[] elements)
        {
            this.collection.AddRange(elements);
        }

        public void Pop()
        {
            if (this.collection.Count > 0)
            {
                this.collection.RemoveAt(this.collection.Count - 1);
            }
            else
            {
                throw new ArgumentException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
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
