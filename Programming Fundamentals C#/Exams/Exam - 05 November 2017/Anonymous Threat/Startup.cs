using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    public class Startup
    {
        public static void Main()
        {
            var initialData = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("3:1"))
                {
                    break;
                }

                var args = input.Split();
                var command = args[0];

                if (command.Equals("merge"))
                {
                    var startIndex = int.Parse(args[1]);
                    var endIndex = int.Parse(args[2]);
                    var concatinated = new StringBuilder();

                    for (int i = Math.Min(endIndex, initialData.Count - 1); i >= Math.Max(0, startIndex); i--)
                    {
                        concatinated.Insert(0, initialData[i]);
                        initialData.RemoveAt(i);
                    }

                    if (!concatinated.ToString().Equals(string.Empty))
                    {
                        initialData.Insert(Math.Max(0, startIndex), concatinated.ToString());
                    }

                }
                else
                {
                    var index = int.Parse(args[1]);
                    var partitions = int.Parse(args[2]);
                    var partitionsToInsert = new List<string>();
                    var currentIndex = 0;

                    if (partitions != 0)
                    {
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                var lastPartition = initialData[index].Substring(currentIndex);
                                partitionsToInsert.Add(lastPartition);
                            }
                            else
                            {
                                var partition = initialData[index].Substring(currentIndex, initialData[index].Count() / partitions);
                                partitionsToInsert.Add(partition);
                            }

                            currentIndex += initialData[index].Count() / partitions;
                        }

                        initialData.RemoveAt(index);
                        initialData.InsertRange(index, partitionsToInsert);
                    }
                }

            }
            Console.WriteLine(string.Join(" ", initialData));
        }
    }
}
