using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var commands = Console.ReadLine().Split();

                if (commands[0].Equals("end"))
                {
                    break;
                }
                else
                {
                    switch (commands[0])
                    {
                        case "exchange":

                            inputArray = ExchageTwoParts(inputArray, commands);

                            break;

                        case "max":

                            IndexOfMaxOddEven(inputArray, commands);

                            break;

                        case "min":

                            IndexOfMinOddEven(inputArray, commands);

                            break;

                        case "first":

                            FirstNEvenOddElements(inputArray, commands);

                            break;

                        case "last":

                            LastNEvenOddElements(inputArray, commands);

                            break;
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        private static void LastNEvenOddElements(List<int> inputArray, string[] commands)
        {
            var countLast = int.Parse(commands[1]);

            if (countLast > inputArray.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var toPrint = new List<int>();

                switch (commands[2])
                {
                    case "even":

                        for (int i = inputArray.Count - 1; i >= 0; i--)
                        {
                            if (inputArray[i] % 2 == 0)
                            {
                                toPrint.Add(inputArray[i]);
                                countLast--;

                                if (countLast == 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (toPrint.Count > 0)
                        {
                            toPrint.Reverse();
                            Console.WriteLine($"[{string.Join(", ", toPrint)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                        break;

                    case "odd":

                        for (int i = inputArray.Count - 1; i >= 0; i--)
                        {
                            if (inputArray[i] % 2 != 0)
                            {
                                toPrint.Add(inputArray[i]);
                                countLast--;

                                if (countLast == 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (toPrint.Count > 0)
                        {
                            toPrint.Reverse();
                            Console.WriteLine($"[{string.Join(", ", toPrint)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                        break;
                }
            }
        }

        private static void FirstNEvenOddElements(List<int> inputArray, string[] commands)
        {
            var countFirst = int.Parse(commands[1]);

            if (countFirst > inputArray.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var toPrint = new List<int>();

                switch (commands[2])
                {
                    case "even":

                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            if (inputArray[i] % 2 == 0)
                            {
                                toPrint.Add(inputArray[i]);
                                countFirst--;

                                if (countFirst == 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (toPrint.Count > 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", toPrint)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                        break;

                    case "odd":

                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            if (inputArray[i] % 2 != 0)
                            {
                                toPrint.Add(inputArray[i]);
                                countFirst--;

                                if (countFirst == 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (toPrint.Count > 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", toPrint)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                        break;
                }
            }
        }

        private static void IndexOfMinOddEven(List<int> inputArray, string[] commands)
        {
            switch (commands[1])
            {
                case "even":

                    var indexMinEvenElement = -1;
                    var minEvenElement = int.MaxValue;

                    for (int i = 0; i < inputArray.Count; i++)
                    {
                        if (inputArray[i] % 2 == 0)
                        {
                            if (inputArray[i] <= minEvenElement)
                            {
                                minEvenElement = inputArray[i];
                                indexMinEvenElement = i;
                            }
                        }
                    }

                    if (indexMinEvenElement > -1)
                    {
                        Console.WriteLine(indexMinEvenElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                    break;

                case "odd":

                    var indexMinOddElement = -1;
                    var minOddElement = int.MaxValue;

                    for (int i = 0; i < inputArray.Count; i++)
                    {
                        if (inputArray[i] % 2 != 0)
                        {
                            if (inputArray[i] <= minOddElement)
                            {
                                minOddElement = inputArray[i];
                                indexMinOddElement = i;
                            }
                        }
                    }

                    if (indexMinOddElement > -1)
                    {
                        Console.WriteLine(indexMinOddElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                    break;
            }
        }

        private static void IndexOfMaxOddEven(List<int> inputArray, string[] commands)
        {
            switch (commands[1])
            {
                case "even":

                    var indexMaxEvenElement = -1;
                    var maxEvenElement = int.MinValue;

                    for (int i = 0; i < inputArray.Count; i++)
                    {
                        if (inputArray[i] % 2 == 0)
                        {
                            if (inputArray[i] >= maxEvenElement)
                            {
                                maxEvenElement = inputArray[i];
                                indexMaxEvenElement = i;
                            }
                        }
                    }

                    if (indexMaxEvenElement > -1)
                    {
                        Console.WriteLine(indexMaxEvenElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                    break;

                case "odd":

                    var indexMaxOddElement = -1;
                    var maxOddElement = int.MinValue;

                    for (int i = 0; i < inputArray.Count; i++)
                    {
                        if (inputArray[i] % 2 != 0)
                        {
                            if (inputArray[i] >= maxOddElement)
                            {
                                maxOddElement = inputArray[i];
                                indexMaxOddElement = i;
                            }
                        }
                    }

                    if (indexMaxOddElement > -1)
                    {
                        Console.WriteLine(indexMaxOddElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                    break;
            }
        }

        private static List<int> ExchageTwoParts(List<int> inputArray, string[] commands)
        {
            var index = int.Parse(commands[1]);
            if (index < 0 || index >= inputArray.Count)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }
            else
            {
                var leftSplit = inputArray.Take(index + 1);
                inputArray = inputArray.Skip(index + 1).ToList();
                inputArray.AddRange(leftSplit);
                return inputArray;
            }
        }
    }
}
