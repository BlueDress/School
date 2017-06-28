using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            var inputParentheses = Console.ReadLine().ToCharArray();

            var parentheses = new Queue<char>(inputParentheses);
            var toLookFor = new Stack<char>();

            var firstElement = parentheses.Dequeue();
            parentheses.Enqueue(firstElement);
            var secondElement = parentheses.Peek();

            var isBalanced = false;

            for (int i = 0; i < parentheses.Count; i++)
            {
                isBalanced = ParenthesesBalanceCheck(parentheses, toLookFor, ref firstElement, ref secondElement);

                if (!isBalanced)
                {
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool ParenthesesBalanceCheck(Queue<char> parentheses, Stack<char> toLookFor, ref char firstElement, ref char secondElement)
        {
            bool isBalanced;
            switch (firstElement)
            {
                case '{':
                    if (secondElement.Equals(']') || secondElement.Equals(')'))
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (secondElement.Equals('[') || secondElement.Equals('(') || secondElement.Equals('{'))
                    {
                        firstElement = secondElement;
                        parentheses.Enqueue(parentheses.Dequeue());
                        secondElement = parentheses.Peek();
                        toLookFor.Push('}');

                        isBalanced = true;
                    }
                    else
                    {
                        parentheses.Enqueue(parentheses.Dequeue());
                        firstElement = parentheses.Dequeue();
                        parentheses.Enqueue(firstElement);
                        secondElement = parentheses.Peek();

                        isBalanced = true;
                    }
                    break;
                case '[':
                    if (secondElement.Equals('}') || secondElement.Equals(')'))
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (secondElement.Equals('[') || secondElement.Equals('(') || secondElement.Equals('{'))
                    {
                        firstElement = secondElement;
                        parentheses.Enqueue(parentheses.Dequeue());
                        secondElement = parentheses.Peek();
                        toLookFor.Push(']');

                        isBalanced = true;
                    }
                    else
                    {
                        parentheses.Enqueue(parentheses.Dequeue());
                        firstElement = parentheses.Dequeue();
                        parentheses.Enqueue(firstElement);
                        secondElement = parentheses.Peek();

                        isBalanced = true;
                    }
                    break;
                case '(':
                    if (secondElement.Equals(']') || secondElement.Equals('}'))
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (secondElement.Equals('[') || secondElement.Equals('(') || secondElement.Equals('{'))
                    {
                        firstElement = secondElement;
                        parentheses.Enqueue(parentheses.Dequeue());
                        secondElement = parentheses.Peek();
                        toLookFor.Push(')');

                        isBalanced = true;
                    }
                    else
                    {
                        parentheses.Enqueue(parentheses.Dequeue());
                        firstElement = parentheses.Dequeue();
                        parentheses.Enqueue(firstElement);
                        secondElement = parentheses.Peek();

                        isBalanced = true;
                    }
                    break;
                default:
                    if (toLookFor.Count > 0 && firstElement.Equals(toLookFor.Pop()))
                    {
                        firstElement = secondElement;
                        parentheses.Enqueue(parentheses.Dequeue());
                        secondElement = parentheses.Peek();

                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                    break;
            }

            return isBalanced;
        }
    }
}
