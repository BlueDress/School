using System;
using Emergency_Skeleton.Interfaces.IO;

namespace Emergency_Skeleton.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
