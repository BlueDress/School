using System;
using System.IO;

namespace Folder_Size
{
    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");
            var sum = 0d;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            File.WriteAllText("output.txt", (sum / 1024 / 1024).ToString());
        }
    }
}
