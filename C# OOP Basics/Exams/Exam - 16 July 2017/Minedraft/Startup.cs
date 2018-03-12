using Minedraft.App;
using Minedraft.IO.Implementations;
using Minedraft.Services.Implementations;

namespace Minedraft
{
    public class Startup
    {
        public static void Main()
        {
            var draftManager = new DraftManager();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new Engine(draftManager, reader, writer);
            engine.Run();
        }
    }
}
