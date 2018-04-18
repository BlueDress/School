using System;
using System.Collections.Generic;

namespace AStarAlgorithm
{
    public class AStar
    {
        private char[,] map;

        public AStar(char[,] map)
        {
            this.map = map;
        }

        public static int GetH(Node current, Node goal)
        {
            return Math.Abs(current.Row - goal.Row) + Math.Abs(current.Col - goal.Col);
        }

        public IEnumerable<Node> GetPath(Node start, Node goal)
        {
            var queue = new PriorityQueue<Node>();
            queue.Enqueue(start);

            var parent = new Dictionary<Node, Node>();
            parent[start] = null;

            var cost = new Dictionary<Node, int>();
            cost[start] = 0;

            while (true)
            {
                if (queue.Count == 0)
                {
                    break;
                }

                var current = queue.Dequeue();

                if (current.Equals(goal))
                {
                    break;
                }

                var neighbours = GetNeighbours(current);

                foreach (var neighbour in neighbours)
                {
                    var newCost = cost[current] + 1;

                    if (!cost.ContainsKey(neighbour) || cost[neighbour] > newCost)
                    {
                        cost[neighbour] = newCost;
                        neighbour.F = newCost + GetH(neighbour, goal);
                        queue.Enqueue(neighbour);
                        parent[neighbour] = current;
                    }
                }
            }

            return Path(goal, parent);
        }

        private IEnumerable<Node> GetNeighbours(Node currentNode)
        {
            var neighbours = new List<Node>();

            var row = currentNode.Row;
            var col = currentNode.Col;

            if (IsInBounds(row, col - 1) && IsPassable(row, col - 1))
            {
                neighbours.Add(new Node(row, col - 1));
            }

            if (IsInBounds(row, col + 1) && IsPassable(row, col + 1))
            {
                neighbours.Add(new Node(row, col + 1));
            }

            if (IsInBounds(row - 1, col) && IsPassable(row - 1, col))
            {
                neighbours.Add(new Node(row - 1, col));
            }

            if (IsInBounds(row + 1, col) && IsPassable(row + 1, col))
            {
                neighbours.Add(new Node(row + 1, col));
            }

            return neighbours;
        }

        private bool IsInBounds(int row, int col)
        {
            return 0 <= row && row < this.map.GetLength(0) && 0 <= col && col < this.map.GetLength(1);
        }

        private bool IsPassable(int row, int col)
        {
            return this.map[row, col] != ('W');
        }

        private static IEnumerable<Node> Path(Node goal, Dictionary<Node, Node> parent)
        {
            var path = new Stack<Node>();

            var current = goal;

            while (true)
            {
                if (!parent.ContainsKey(current))
                {
                    break;
                }

                if (parent[current] == null)
                {
                    path.Push(current);
                    break;
                }

                path.Push(current);
                current = parent[current];
            }

            return path.ToArray();
        }
    }
}
