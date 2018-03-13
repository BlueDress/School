using GrandPrix.IO.Contracts;
using System;

namespace GrandPrix.IO.Implementations
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
