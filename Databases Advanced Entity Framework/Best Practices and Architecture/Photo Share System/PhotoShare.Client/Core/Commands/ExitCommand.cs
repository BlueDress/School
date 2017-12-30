namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using System;

    public class ExitCommand : ICommand
    {
        private PhotoShareContext context;

        public ExitCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            Console.WriteLine("Bye-bye!");
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
