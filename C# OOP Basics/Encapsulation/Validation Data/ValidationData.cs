using System;
using System.Collections.Generic;

namespace Validation_Data
{
    public class ValidationData
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            double.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

