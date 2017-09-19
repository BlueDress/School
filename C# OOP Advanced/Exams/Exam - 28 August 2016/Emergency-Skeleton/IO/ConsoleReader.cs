using System;
using Emergency_Skeleton.Interfaces.IO;

namespace Emergency_Skeleton.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
