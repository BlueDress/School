using System;

namespace ImplementTree
{
    public class BinaryTree<T>
    {
        public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value { get; set; }

        public BinaryTree<T> LeftChild { get; private set; }

        public BinaryTree<T> RightChild { get; private set; }

        public void PrintIndentedPreOrder(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}{this.Value}");
            indent += 2;
            this.LeftChild?.PrintIndentedPreOrder(indent);
            this.RightChild?.PrintIndentedPreOrder(indent);
        }

        public void EachInOrder(Action<T> action)
        {
            this.LeftChild?.EachInOrder(action);
            action(this.Value);
            this.RightChild?.EachInOrder(action);
        }

        public void EachPostOrder(Action<T> action)
        {
            this.LeftChild?.EachPostOrder(action);
            this.RightChild?.EachPostOrder(action);
            action(this.Value);
        }
    }
}
