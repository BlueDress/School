using Hell.Entities.Miscellaneous;
using Hell.Interfaces.Core;
using Hell.Interfaces.Entities;
using Hell.Interfaces.IO;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        IInputReader reader = new ConsoleReader();
        IOutputWriter writer = new ConsoleWriter();

        var heroes = new SortedSet<IHero>(new HeroComparator());
        IManager manager = new HeroManager(heroes);

        IEngine engine = new Engine(reader, writer, manager);
        engine.Run();
    }
}