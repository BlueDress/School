using System;
using System.Collections.Generic;
using System.Linq;

namespace Command_Interpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

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
                        case "reverse":

                            var startIndexReverse = int.Parse(commands[2]);
                            var countReverse = int.Parse(commands[4]);

                            if ((startIndexReverse >= 0 && startIndexReverse < inputList.Count) && startIndexReverse + countReverse <= inputList.Count)
                            {
                                var tempList = new List<string>();

                                for (int i = startIndexReverse + countReverse - 1; i >= startIndexReverse; i--)
                                {
                                    tempList.Add(inputList[i]);
                                }

                                inputList.RemoveRange(startIndexReverse, countReverse);
                                inputList.InsertRange(startIndexReverse, tempList);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }

                            break;

                        case "sort":

                            var startIndexSort = int.Parse(commands[2]);
                            var countSort = int.Parse(commands[4]);

                            if ((startIndexSort >= 0 && startIndexSort < inputList.Count) && startIndexSort + countSort <= inputList.Count)
                            {
                                var tempList = new List<string>();

                                for (int i = startIndexSort + countSort - 1; i >= startIndexSort; i--)
                                {
                                    tempList.Add(inputList[i]);
                                }

                                tempList.Sort();
                                inputList.RemoveRange(startIndexSort, countSort);
                                inputList.InsertRange(startIndexSort, tempList);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }

                            break;

                        case "rollLeft":

                            var countRollLeft = int.Parse(commands[1]);

                            for (int i = 0; i < countRollLeft; i++)
                            {
                                var lastElement = inputList[0];

                                for (int j = 0; j < inputList.Count - 1; j++)
                                {
                                    inputList[j] = inputList[j + 1];
                                }

                                inputList[inputList.Count - 1] = lastElement;
                            }

                            break;

                        case "rollRight":

                            var countRollRight = int.Parse(commands[1]);

                            for (int i = 0; i < countRollRight; i++)
                            {
                                var firstElement = inputList[inputList.Count - 1];

                                for (int j = inputList.Count - 1; j > 0; j--)
                                {
                                    inputList[j] = inputList[j - 1];
                                }

                                inputList[0] = firstElement;
                            }

                            break;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inputList));
        }
    }
}
