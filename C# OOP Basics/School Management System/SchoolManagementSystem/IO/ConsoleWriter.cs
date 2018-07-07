using SchoolManagementSystem.Contracts.IO;
using System;

namespace SchoolManagementSystem.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
