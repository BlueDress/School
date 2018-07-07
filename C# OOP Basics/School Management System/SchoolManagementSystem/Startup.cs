using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.Core;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Controllers;
using SchoolManagementSystem.Core;
using SchoolManagementSystem.IO;

namespace SchoolManagementSystem
{
    public class Startup
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            ITextFormatter formatter = new ConsoleFormatter();
            IManager manager = new SchoolManager();

            IEngine engine = new Engine(manager, reader, writer, formatter);
            engine.Run();
        }
    }
}
