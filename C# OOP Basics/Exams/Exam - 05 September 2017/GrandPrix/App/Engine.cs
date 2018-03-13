using GrandPrix.IO.Contracts;
using GrandPrix.Services.Implementations;
using System.Linq;

namespace GrandPrix.App
{
    public class Engine
    {
        private IWriter writer;
        private IReader reader;
        private RaceTower raceTower;

        public Engine(IWriter writer, IReader reader, RaceTower raceTower)
        {
            this.writer = writer;
            this.reader = reader;
            this.raceTower = raceTower;
        }

        public void Run()
        {
            SetTrackInfo();
            SimulateRace();
        }

        private void SetTrackInfo()
        {
            var numberOfLaps = int.Parse(this.reader.ReadLine());
            var trackLenght = int.Parse(this.reader.ReadLine());

            this.raceTower.SetTrackInfo(numberOfLaps, trackLenght);
        }

        private void SimulateRace()
        {
            while (true)
            {
                if (this.raceTower.LapsLeft == 0)
                {
                    var winner = this.raceTower.GetWinner();

                    this.writer.WriteLine($"{winner.Name} wins the race for {winner.TotalTime:f3} seconds.");
                    break;
                }

                var arguments = this.reader.ReadLine().Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
                var command = arguments[0];
                var commandArguments = arguments.Skip(1).ToList();

                switch (command)
                {
                    case "RegisterDriver":
                        this.raceTower.RegisterDriver(commandArguments);
                        break;
                    case "Box":
                        this.raceTower.DriverBoxes(commandArguments);
                        break;
                    case "CompleteLaps":
                        var result = this.raceTower.CompleteLaps(commandArguments);

                        if (result != null && result != string.Empty)
                        {
                            this.writer.WriteLine(result);
                        }

                        break;
                    case "Leaderboard":
                        this.writer.WriteLine(this.raceTower.GetLeaderboard());
                        break;
                    case "ChangeWeather":
                        this.raceTower.ChangeWeather(commandArguments);
                        break;
                }
            }
        }
    }
}
