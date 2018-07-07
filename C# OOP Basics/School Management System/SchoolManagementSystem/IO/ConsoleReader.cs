using SchoolManagementSystem.Contracts.IO;
using System;

namespace SchoolManagementSystem.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
