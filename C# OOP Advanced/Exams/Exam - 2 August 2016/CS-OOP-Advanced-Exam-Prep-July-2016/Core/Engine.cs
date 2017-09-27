using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using System;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Core
{
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IDatabase database;

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}