namespace RecyclingStation.IO
{
    using System;
    using RecyclingStation.Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string args)
        {
            Console.Write(args);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string args)
        {
            Console.WriteLine(args);
        }
    }
}
