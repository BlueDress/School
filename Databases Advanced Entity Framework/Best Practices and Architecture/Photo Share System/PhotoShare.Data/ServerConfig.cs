using System.IO;

namespace PhotoShare.Data
{
    internal class ServerConfig
    {
        internal static string ConnectionString => File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\PhotoShareSystem.txt");
    }
}
