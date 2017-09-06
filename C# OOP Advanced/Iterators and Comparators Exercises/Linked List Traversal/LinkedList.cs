using System.Collections;
using System.Collections.Generic;

namespace Linked_List_Traversal
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node Next { get; set; }
        }

        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }

        public void Add(T item)
        {
            var old = this.Tail;
            this.Tail = new Node(item);

            if (this.Count == 0)
            {
                this.Head = this.Tail;
            }
            else
            {
                old.Next = this.Tail;
            }

            this.Count++;
        }

        public void Remove(T item)
        {
            var current = this.Head;
            Node preCurrent = null;

            while (true)
            {
                if (current == null)
                {
                    break;
                }

                if (current.Value.Equals(item))
                {
                    if (preCurrent == null)
                    {
                        this.Head = current.Next;
                    }
                    else
                    {
                        preCurrent.Next = current.Next;
                    }

                    current = null;
                    this.Count--;
                }
                else
                {
                    preCurrent = current;
                    current = current.Next;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.Head;

            while (true)
            {
                if (current == null)
                {
                    break;
                }

                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
