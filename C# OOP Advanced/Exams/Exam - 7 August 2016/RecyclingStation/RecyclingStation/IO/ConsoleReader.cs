namespace RecyclingStation.IO
{
    using System;
    using RecyclingStation.Contracts;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
