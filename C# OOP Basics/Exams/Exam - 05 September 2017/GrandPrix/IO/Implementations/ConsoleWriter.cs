using GrandPrix.IO.Contracts;
using System;

namespace GrandPrix.IO.Implementations
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
