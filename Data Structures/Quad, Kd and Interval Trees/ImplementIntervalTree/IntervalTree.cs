using System;
using System.Collections.Generic;

namespace ImplementIntervalTree
{
    public class IntervalTree
    {
        private class Node
        {
            internal Interval interval;
            internal double max;
            internal Node right;
            internal Node left;

            public Node(Interval interval)
            {
                this.interval = interval;
                this.max = interval.Hi;
            }
        }

        private Node root;

        public void Insert(double lo, double hi)
        {
            this.root = this.Insert(this.root, lo, hi);
        }

        public void EachInOrder(Action<Interval> action)
        {
            EachInOrder(this.root, action);
        }

        public Interval SearchAny(double lo, double hi)
        {
            var current = this.root;

            while (true)
            {
                if (current == null || current.interval.Intersects(lo, hi))
                {
                    break;
                }

                if (current.left != null && current.left.max > lo)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            if (current == null)
            {
                return null;
            }

            return current.interval;
        }

        public IEnumerable<Interval> SearchAll(double lo, double hi)
        {
            var intervals = new List<Interval>();

            SearchAll(this.root, lo, hi, intervals);

            return intervals;
        }

        private void SearchAll(Node node, double lo, double hi, List<Interval> intervals)
        {
            if (node == null)
            {
                return;
            }

            var goLeft = node.left != null && node.left.max > lo;
            var goRight = node.right != null && node.right.interval.Lo < hi;

            if (goLeft)
            {
                SearchAll(node.left, lo, hi, intervals);
            }

            if (node.interval.Intersects(lo, hi))
            {
                intervals.Add(node.interval);
            }

            if (goRight)
            {
                SearchAll(node.right, lo, hi, intervals);
            }
        }

        private void EachInOrder(Node node, Action<Interval> action)
        {
            if (node == null)
            {
                return;
            }

            EachInOrder(node.left, action);
            action(node.interval);
            EachInOrder(node.right, action);
        }

        private Node Insert(Node node, double lo, double hi)
        {
            if (node == null)
            {
                return new Node(new Interval(lo, hi));
            }

            int cmp = lo.CompareTo(node.interval.Lo);

            if (cmp < 0)
            {
                node.left = Insert(node.left, lo, hi);
            }
            else if (cmp > 0)
            {
                node.right = Insert(node.right, lo, hi);
            }

            UpdateMax(node);
            return node;
        }

        private void UpdateMax(Node node)
        {
            var maxChild = GetMax(node.left, node.right);
            node.max = GetMax(node, maxChild).max;
        }

        private Node GetMax(Node a, Node b)
        {
            if (a == null)
            {
                return b;
            }

            if (b == null)
            {
                return a;
            }

            return a.max > b.max ? a : b;
        }
    }
}
