using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using System;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}