using Minedraft.IO.Contracts;
using System;

namespace Minedraft.IO.Implementations
{
    public class ConsoleWriter : IWriter
    {
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
