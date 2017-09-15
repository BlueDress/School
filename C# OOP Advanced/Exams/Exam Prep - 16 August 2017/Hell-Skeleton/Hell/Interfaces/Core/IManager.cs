using System.Collections.Generic;

namespace Hell.Interfaces.Core
{
    public interface IManager
    {
        string Quit(IList<string> args);
        string AddHero(IList<string> args);
        string AddItemToHero(IList<string> args);
        string Inspect(IList<string> args);
    }
}
