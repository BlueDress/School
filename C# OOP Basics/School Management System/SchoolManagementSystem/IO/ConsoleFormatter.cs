using SchoolManagementSystem.Contracts.IO;
using System;

namespace SchoolManagementSystem.IO
{
    public class ConsoleFormatter : ITextFormatter
    {
        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
