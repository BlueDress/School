using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    public class Startup
    {
        public static void Main()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            
            var filesExtensions = new Dictionary<string, List<MyFile>>();

            foreach (var file in files)
            {
                var extension = file.Substring(file.LastIndexOf("."));

                if (!filesExtensions.ContainsKey(extension))
                {
                    filesExtensions[extension] = new List<MyFile>();
                }

                var fileSize = File.ReadAllBytes(file);
                var fileName = file.Substring(file.LastIndexOf("\\") + 1);

                var currentFile = new MyFile(fileName, fileSize.Length);

                filesExtensions[extension].Add(currentFile);
            }

            var sb = new StringBuilder();

            foreach (var kvp in filesExtensions.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(kvp.Key);

                foreach (var file in kvp.Value.OrderBy(f => f.Size))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Size / 1000}kb");
                }
            }

            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/report.txt", sb.ToString());
        }
    }
}
