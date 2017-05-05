using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            do
            {
                List<string> inputCommands = Console.ReadLine().Split().ToList();

                if (inputCommands[0] == "print")
                {
                    break;
                }

                switch (inputCommands[0])
                {
                    case "add":
                        inputList.Insert(int.Parse(inputCommands[1]), int.Parse(inputCommands[2]));
                        break;

                    case "addMany":
                        inputList.InsertRange(int.Parse(inputCommands[1]), inputCommands.Skip(2).Select(int.Parse));
                        break;

                    case "contains":
                        if (inputList.Contains(int.Parse(inputCommands[1])) == true)
                        {
                            Console.WriteLine(inputList.IndexOf(int.Parse(inputCommands[1])));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;

                    case "shift":
                        for (int i = 0; i < int.Parse(inputCommands[1]); i++)
                        {
                            var temp = inputList[0];
                            inputList.RemoveAt(0);
                            inputList.Add(temp);
                        }
                        break;

                    case "sumPairs":
                        for (int item = 0; item < inputList.Count - 1; item++)
                        {
                            inputList[item] = inputList[item] + inputList[item + 1];
                            inputList.RemoveAt(item + 1);
                        }
                        break;
                    case "remove":
                        inputList.RemoveAt(int.Parse(inputCommands[1]));
                        break;
                }
            } while (true);

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }
    }
}
