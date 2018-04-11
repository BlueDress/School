using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingWithTrees
{
    public class Startup
    {
        private static Dictionary<int, Tree<int>> nodes = new Dictionary<int, Tree<int>>();

        public static void Main()
        {
            ReadNodes();

            var root = GetRoot();
            var leafs = GetLeafs();
            var middleNodes = GetMiddleNodes();
            var deepestNode = GetDeepestNode(root);
            var longestPath = GetLongestPath(deepestNode);
            var pathsWithGivenSum = GetPathsWithGivenSum(root);
            var subtreesWithGivenSum = GetSubtreesWithGivenSum(root);

            root.Print();
            Console.WriteLine($"Root node: {root.Value}");
            Console.WriteLine($"Leaf nodes: {string.Join(", ", leafs.Select(n => n.Value).OrderBy(v => v))}");
            Console.WriteLine($"Middle nodes: {string.Join(", ", middleNodes.Select(n => n.Value).OrderBy(v => v))}");
            Console.WriteLine($"Deepest node: {deepestNode.Value}");
            Console.WriteLine($"Longest path: {string.Join(", ", longestPath.Select(n => n.Value))}");
            Console.WriteLine($"Paths of sum {string.Join(Environment.NewLine, pathsWithGivenSum)}");
            Console.WriteLine($"Subtrees of sum {string.Join(Environment.NewLine, subtreesWithGivenSum)}");
        }

        private static void ReadNodes()
        {
            var numberOfNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var parentChildPair = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var parent = GetNode(parentChildPair[0]);
                var child = GetNode(parentChildPair[1]);

                parent.Children.Add(child);
                child.Parent = parent;
            }
        }

        private static Tree<int> GetNode(int value)
        {
            if (!nodes.ContainsKey(value))
            {
                nodes[value] = new Tree<int>(value);
            }

            return nodes[value];
        }

        private static Tree<int> GetRoot()
        {
            return nodes.Values.Where(n => n.Parent == null).FirstOrDefault();
        }

        private static IEnumerable<Tree<int>> GetLeafs()
        {
            return nodes.Values.Where(n => n.Children.Count == 0);
        }

        private static IEnumerable<Tree<int>> GetMiddleNodes()
        {
            return nodes.Values.Where(n => n.Children.Count != 0 && n.Parent != null);
        }

        private static Tree<int> GetDeepestNode(Tree<int> root)
        {
            Tree<int> deepestNode = null;

            var queue = new Queue<Tree<int>>();
            queue.Enqueue(root);

            while (true)
            {
                if (queue.Count == 0)
                {
                    break;
                }

                deepestNode = queue.Dequeue();

                foreach (var child in deepestNode.Children.Reverse())
                {
                    queue.Enqueue(child);
                }
            }

            return deepestNode;
        }

        private static IEnumerable<Tree<int>> GetLongestPath(Tree<int> deepestNode)
        {
            var longestPath = new List<Tree<int>>();
            longestPath.Add(deepestNode);

            var previousNode = deepestNode.Parent;

            while (true)
            {
                if (previousNode == null)
                {
                    break;
                }

                longestPath.Add(previousNode);
                previousNode = previousNode.Parent;
            }

            longestPath.Reverse();

            return longestPath;
        }

        private static IEnumerable<string> GetPathsWithGivenSum(Tree<int> root)
        {
            var sumToCheck = int.Parse(Console.ReadLine());
            var pathsWithGivenSum = new List<string>();
            pathsWithGivenSum.Add(sumToCheck.ToString());

            GetPaths(root, sumToCheck, pathsWithGivenSum);

            return pathsWithGivenSum;
        }

        private static void GetPaths(Tree<int> root, int sumToCheck, List<string> pathsWithGivenSum, int currentSum = 0)
        {
            currentSum += root.Value;

            foreach (var child in root.Children)
            {
                GetPaths(child, sumToCheck, pathsWithGivenSum, currentSum);
            }

            if (currentSum == sumToCheck)
            {
                var currentPath = new List<int>();
                var currentNode = root;

                while (true)
                {
                    if (currentNode == null)
                    {
                        break;
                    }

                    currentPath.Add(currentNode.Value);
                    currentNode = currentNode.Parent;
                }

                currentPath.Reverse();
                pathsWithGivenSum.Add(string.Join(", ", currentPath)); 
            }
        }

        private static IEnumerable<string> GetSubtreesWithGivenSum(Tree<int> root)
        {
            var sumToCheck = int.Parse(Console.ReadLine());
            var subtreesWithGivenSum = new List<string>();
            subtreesWithGivenSum.Add(sumToCheck.ToString());

            var queue = new Queue<Tree<int>>();
            queue.Enqueue(root);

            while (true)
            {
                if (queue.Count == 0)
                {
                    break;
                }

                var currentNode = queue.Dequeue();

                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }

                var currentSubtree = currentNode.OrderBFS();

                if (sumToCheck == currentSubtree.Sum())
                {
                    subtreesWithGivenSum.Add(string.Join(", ", currentSubtree));
                }
            }

            return subtreesWithGivenSum;
        }
    }
}
