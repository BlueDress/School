using Minedraft.IO.Contracts;
using System;

namespace Minedraft.IO.Implementations
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
