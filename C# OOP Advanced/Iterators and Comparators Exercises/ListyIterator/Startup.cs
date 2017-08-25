using System;
using System.Linq;

namespace ListyIterator
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            input.RemoveAt(0);
            var listIteratorData = input.ToArray();

            var listyIterator = new ListyIterator<string>(listIteratorData);

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
            }
        }
    }
}
