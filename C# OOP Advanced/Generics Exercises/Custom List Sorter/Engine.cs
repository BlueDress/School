using System;

namespace Custom_List_Sorter
{
    public class Engine
    {
        private CustomList<string> collection;

        public Engine()
        {
            this.collection = new CustomList<string>();
        }

        public void Run()
        {
            ReadData();
        }

        private void ReadData()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var commands = input.Split();
                    var command = commands[0];

                    switch (command)
                    {
                        case "Add":
                            this.collection.Add(commands[1]);
                            break;
                        case "Remove":
                            this.collection.Remove(int.Parse(commands[1]));
                            break;
                        case "Contains":
                            Console.WriteLine(this.collection.Contains(commands[1]));
                            break;
                        case "Swap":
                            this.collection.Swap(int.Parse(commands[1]), int.Parse(commands[2]));
                            break;
                        case "Greater":
                            Console.WriteLine(this.collection.CountGreaterThan(commands[1]));
                            break;
                        case "Max":
                            Console.WriteLine(this.collection.Max());
                            break;
                        case "Min":
                            Console.WriteLine(this.collection.Min());
                            break;
                        case "Print":
                            this.collection.Print();
                            break;
                        case "Sort":
                            this.collection.Sort();
                            break;
                    }
                }
            }
        }
    }
}
