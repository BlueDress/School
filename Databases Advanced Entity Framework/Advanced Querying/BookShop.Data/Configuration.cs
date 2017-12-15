using System.IO;

namespace BookShop.Data
{
    internal class Configuration
    {
        internal static string ConnectionString => File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\Instructions2.txt");
    }
}
