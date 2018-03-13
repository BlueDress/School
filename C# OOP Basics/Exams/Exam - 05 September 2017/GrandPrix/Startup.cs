using GrandPrix.App;
using GrandPrix.IO.Implementations;
using GrandPrix.Services.Implementations;

namespace GrandPrix
{
    public class Startup
    {
        public static void Main()
        {
            var writer = new ConsoleWriter();
            var reader = new ConsoleReader();
            var raceTower = new RaceTower();

            var engine = new Engine(writer, reader, raceTower);
            engine.Run();
        }
    }
}
