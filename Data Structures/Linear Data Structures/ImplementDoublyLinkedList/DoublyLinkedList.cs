using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementDoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = new Node<T>(element);
                this.tail = new Node<T>(element);
            }
            else
            {
                var newHead = new Node<T>(element);
                var currentHead = this.head;

                currentHead.Previuos = newHead;
                newHead.Next = currentHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                var newTail = new Node<T>(element);
                var currentTail = this.tail;

                currentTail.Next = newTail;
                newTail.Previuos = currentTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            var removedNode = this.head.Value;

            this.head = this.head.Next;

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.Previuos = null;
            }

            this.Count--;

            return removedNode;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            var removedNode = this.tail.Value;

            this.tail = this.tail.Previuos;

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.Next = null;
            }

            this.Count--;

            return removedNode;
        }

        public void ForEach(Action<T> action)
        {
            var node = this.head;

            while (true)
            {
                if (node == null)
                {
                    break;
                }

                action(node.Value);
                node = node.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;

            while (true)
            {
                if (node == null)
                {
                    break;
                }

                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];

            var index = 0;

            this.ForEach(node =>
            {
                array[index++] = node;
            });

            return array;
        }

        private class Node<T>
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previuos { get; set; }
        }
    }
}
