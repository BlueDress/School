using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using System;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}