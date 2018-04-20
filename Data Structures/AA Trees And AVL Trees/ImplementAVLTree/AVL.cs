using System;

namespace ImplementAVLTree
{
    public class AVL<T> where T : IComparable<T>
    {
        private Node<T> root;

        public Node<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public bool Contains(T item)
        {
            var node = this.Search(this.root, item);
            return node != null;
        }

        public void Insert(T item)
        {
            this.root = this.Insert(this.root, item);
        }

        public void Delete(T item)
        {
            this.root = this.Delete(this.root, item);
        }

        public void DeleteMin()
        {
            this.root = this.DeleteMin(this.root);
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }
        
        private Node<T> Search(Node<T> node, T item)
        {
            if (node == null)
            {
                return null;
            }

            var cmp = item.CompareTo(node.Value);

            if (cmp < 0)
            {
                return Search(node.Left, item);
            }
            else if (cmp > 0)
            {
                return Search(node.Right, item);
            }

            return node;
        }

        private Node<T> Insert(Node<T> node, T item)
        {
            if (node == null)
            {
                return new Node<T>(item);
            }

            var cmp = item.CompareTo(node.Value);

            if (cmp < 0)
            {
                node.Left = this.Insert(node.Left, item);
            }
            else if (cmp > 0)
            {
                node.Right = this.Insert(node.Right, item);
            }

            node = Balance(node);
            UpdateHeight(node);

            return node;
        }
        
        private void EachInOrder(Node<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.Left, action);
            action(node.Value);
            this.EachInOrder(node.Right, action);
        }

        private static Node<T> Balance(Node<T> node)
        {
            var balance = Height(node.Left) - Height(node.Right);

            if (balance > 1)
            {
                var childBalance = Height(node.Left.Left) - Height(node.Left.Right);

                if (childBalance < 0)
                {
                    node.Left = RotateLeft(node.Left);
                }

                node = RotateRight(node);
            }
            else if (balance < -1)
            {
                var childBalance = Height(node.Right.Left) - Height(node.Right.Right);

                if (childBalance > 0)
                {
                    node.Right = RotateRight(node.Right);
                }

                node = RotateLeft(node);
            }

            return node;
        }

        private static Node<T> RotateLeft(Node<T> node)
        {
            var temp = node.Right;
            node.Right = temp.Left;
            temp.Left = node;

            UpdateHeight(node);

            return temp;
        }

        private static Node<T> RotateRight(Node<T> node)
        {
            var temp = node.Left;
            node.Left = temp.Right;
            temp.Right = node;

            UpdateHeight(node);

            return temp;
        }

        private static int Height(Node<T> node)
        {
            return node == null ? 0 : node.Height;
        }

        private static void UpdateHeight(Node<T> node)
        {
            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
        }
        
        private Node<T> Delete(Node<T> node, T item)
        {
            if (node == null)
            {
                return null;
            }

            var cmp = node.Value.CompareTo(item);

            if (cmp < 0)
            {
                node.Right = this.Delete(node.Right, item);
            }
            else if (cmp > 0)
            {
                node.Left = this.Delete(node.Left, item);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }
                else
                {
                    var newNode = GetMin(node.Right);
                    newNode.Right = this.DeleteMin(node.Right);
                    newNode.Left = node.Left;
                    
                    node = newNode;
                }
            }

            node = Balance(node);
            UpdateHeight(node);

            return node;
        }

        private Node<T> GetMin(Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left == null)
            {
                return node;
            }

            return GetMin(node.Left);
        }

        private Node<T> DeleteMin(Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                node.Left = this.DeleteMin(node.Left);
            }
            else
            {
                return node.Right;
            }

            node = Balance(node);
            UpdateHeight(node);

            return node;
        }
    }
}
