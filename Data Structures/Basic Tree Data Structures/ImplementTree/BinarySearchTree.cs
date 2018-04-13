using System;
using System.Collections.Generic;

namespace ImplementTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node root;

        private int count;

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
            this.count++;

            if (this.root.Value == null)
            {
                this.root = new Node(value);
                return;
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

            this.count--;
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

        public void Delete(T value)
        {
            Node parent = null;
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

                parent = currentNode;
            }

            var deleteRightChild = false;

            if (parent.RightChild.Value.CompareTo(currentNode.Value) == 0)
            {
                deleteRightChild = true;
            }

            this.Delete(parent, currentNode, deleteRightChild);
        }

        private void Delete(Node parent, Node node, bool deleteRightChild)
        {
            if (node == null)
            {
                return;
            }

            if (node.RightChild != null)
            {
                var currentNode = node.RightChild;

                if (deleteRightChild)
                {
                    parent.RightChild = currentNode;
                }
                else
                {
                    parent.LeftChild = currentNode;
                }

                while (true)
                {
                    if (currentNode.LeftChild == null)
                    {
                        break;
                    }

                    currentNode = currentNode.LeftChild;
                }

                currentNode.LeftChild = node.LeftChild;

                if (parent == null)
                {
                    this.root = currentNode;
                }
            }
            else if (node.LeftChild != null)
            {
                if (deleteRightChild)
                {
                    parent.RightChild = node.LeftChild;
                }
                else
                {
                    parent.LeftChild = node.LeftChild;
                }

                if (parent == null)
                {
                    this.root = node.LeftChild;
                }
            }
            else
            {
                if (deleteRightChild)
                {
                    parent.RightChild = null;
                }
                else
                {
                    parent.LeftChild = null;
                }

                if (parent == null)
                {
                    this.root = null;
                }
            }
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

            this.count--;
        }

        public int Count()
        {
            return this.count;
        }

        public int Rank(T value)
        {
            var elements = new List<T>();

            this.Rank(value, elements, this.root);

            return elements.Count - 1;
            //var currentNode = this.root;
            //
            //while (true)
            //{
            //    if (currentNode == null)
            //    {
            //        break;
            //    }
            //
            //    if (currentNode.Value.CompareTo(value) > 0)
            //    {
            //        currentNode = currentNode.LeftChild;
            //    }
            //    else if (currentNode.Value.CompareTo(value) < 0)
            //    {
            //        currentNode = currentNode.RightChild;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //
            //if (currentNode.LeftChild == null)
            //{
            //    return 0;
            //}
            //
            //var count = 1;
            //var queue = new Queue<Node>();
            //queue.Enqueue(currentNode.LeftChild);
            //
            //while (true)
            //{
            //    if (queue.Count == 0)
            //    {
            //        break;
            //    }
            //
            //    var current = queue.Dequeue();
            //
            //    if (current.LeftChild != null)
            //    {
            //        queue.Enqueue(current.LeftChild);
            //        count++;
            //    }
            //
            //    if (current.RightChild != null)
            //    {
            //        queue.Enqueue(current.RightChild);
            //        count++;
            //    }
            //}
            //
            //return count;
        }

        private void Rank(T value, List<T> elements, Node node)
        {
            if (node.LeftChild != null)
            {
                this.Rank(value, elements, node.LeftChild);
            }

            elements.Add(node.Value);

            if (node.Value.CompareTo(value) == 0)
            {
                return;
            }

            if (node.RightChild != null)
            {
                this.Rank(value, elements, node.RightChild);
            }
        }

        public T Select(int rank)
        {
            var elements = new List<T>();

            this.Select(rank, elements, this.root);

            return elements[rank];
        }

        private void Select(int rank, List<T> elements, Node node)
        {
            if (node.LeftChild != null)
            {
                this.Select(rank, elements, node.LeftChild);
            }

            elements.Add(node.Value);

            if (elements.Count - 1 == rank)
            {
                return;
            }

            if (node.RightChild != null)
            {
                this.Select(rank, elements, node.RightChild);
            }
        }

        public T Ceiling(T value)
        {
            return this.Ceiling(this.root, value);
        }

        private T Ceiling(Node node, T value)
        {
            if (node == null)
            {
                return node.Value;
            }
            
            if (node.Value.CompareTo(value) <= 0)
            {
                return this.Ceiling(node.RightChild, value);
            }

            var ceiling = this.Ceiling(node.LeftChild, value);

            if (ceiling == null)
            {
                return node.Value;
            }

            return ceiling;
        }

        public T Floor(T value)
        {
            return this.Floor(this.root, value);
        }

        private T Floor(Node node, T value)
        {
            if (node == null)
            {
                return node.Value;
            }

            if (node.Value.CompareTo(value) >= 0)
            {
                return this.Floor(node.LeftChild, value);
            }

            var floor = this.Floor(node.RightChild, value);

            if (floor == null)
            {
                return node.Value;
            }

            return floor;
        }
    }
}
