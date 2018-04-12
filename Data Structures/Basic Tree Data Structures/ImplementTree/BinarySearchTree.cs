using System;
using System.Collections.Generic;

namespace ImplementTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node root;

        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        public BinarySearchTree()
        {

        }

        private BinarySearchTree(Node node)
        {
            this.Copy(node);
        }

        private void Copy(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.Insert(node.Value);
            this.Copy(node.LeftChild);
            this.Copy(node.RightChild);
        }

        public void Insert(T value)
        {
            if (this.root.Value == null)
            {
                this.root = new Node(value);
            }

            Node parrent = null;
            var currentNode = this.root;

            while (true)
            {
                if (currentNode == null)
                {
                    break;
                }

                parrent = currentNode;

                if (currentNode.Value.CompareTo(value) > 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    break;
                }
            }

            if (parrent.Value.CompareTo(value) > 0)
            {
                parrent.LeftChild = new Node(value);
            }
            else
            {
                parrent.RightChild = new Node(value);
            }
        }

        public bool Contains(T value)
        {
            var currentNode = this.root;

            while (true)
            {
                if (currentNode == null)
                {
                    break;
                }

                if (currentNode.Value.CompareTo(value) > 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteMin()
        {
            if (this.root == null)
            {
                return;
            }

            Node parrent = null;
            var currentNode = this.root;

            while (true)
            {
                if (currentNode.LeftChild == null)
                {
                    break;
                }

                parrent = currentNode;
                currentNode = currentNode.LeftChild;
            }

            if (parrent == null)
            {
                this.root = this.root.RightChild;
            }
            else
            {
                parrent.LeftChild = currentNode.RightChild;
            }
        }

        public BinarySearchTree<T> Search(T value)
        {
            var currentNode = this.root;

            while (true)
            {
                if (currentNode == null)
                {
                    break;
                }

                if (currentNode.Value.CompareTo(value) > 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    break;
                }
            }

            return new BinarySearchTree<T>(currentNode);
        }

        public IEnumerable<T> Range(T startRange, T endRange)
        {
            var queue = new Queue<T>();

            this.Range(this.root, queue, startRange, endRange);

            return queue;
        }

        private void Range(Node node, Queue<T> queue, T startRange, T endRange)
        {
            if (node == null)
            {
                return;
            }

            var nodeInLowerRange = node.Value.CompareTo(startRange);
            var nodeInHigherRange = node.Value.CompareTo(endRange);

            if (nodeInLowerRange > 0)
            {
                this.Range(node.LeftChild, queue, startRange, endRange);
            }

            if (nodeInLowerRange >= 0 && nodeInHigherRange <= 0)
            {
                queue.Enqueue(node.Value);
            }

            if (nodeInHigherRange < 0)
            {
                this.Range(node.RightChild, queue, startRange, endRange);
            }
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }

        private void EachInOrder(Node node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.LeftChild, action);
            action(node.Value);
            this.EachInOrder(node.RightChild, action);
        }

        public void Delete(T element)
        {
            throw new NotImplementedException();
        }

        public void DeleteMax()
        {
            if (this.root == null)
            {
                return;
            }

            Node parrent = null;
            var currentNode = this.root;

            while (true)
            {
                if (currentNode.RightChild == null)
                {
                    break;
                }

                parrent = currentNode;
                currentNode = currentNode.RightChild;
            }

            if (parrent == null)
            {
                this.root = this.root.LeftChild;
            }
            else
            {
                parrent.RightChild = currentNode.LeftChild;
            }
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Rank(T element)
        {
            throw new NotImplementedException();
        }

        public T Select(int rank)
        {
            throw new NotImplementedException();
        }

        public T Ceiling(T element)
        {
            throw new NotImplementedException();
        }

        public T Floor(T element)
        {
            throw new NotImplementedException();
        }
    }
}
