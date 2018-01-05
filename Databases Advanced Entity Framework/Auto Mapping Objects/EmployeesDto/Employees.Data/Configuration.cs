using System.IO;

namespace Employees.Data
{
    public static class Configuration
    {
        public static string ConnectionSting => File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\Instructions3.txt");
    }
}
