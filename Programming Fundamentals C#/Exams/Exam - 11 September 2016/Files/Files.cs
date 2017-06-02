using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            var numberOfFiles = int.Parse(Console.ReadLine());

            var files = new List<File>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                var inputPath = Console.ReadLine().Split('\\', ';');
                var root = inputPath[0];
                var size = long.Parse(inputPath[inputPath.Length - 1]);
                var fileName = inputPath[inputPath.Length - 2];

                var file = new File();
                file.Name = fileName;
                file.Root = root;
                file.Size = size;

                files.Add(file);
            }

            var inputCommands = Console.ReadLine().Split();
            var rootCheck = inputCommands[2];
            var extensionCheck = inputCommands[0];

            var filesToPrint = new Dictionary<string, long>();

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Root.Equals(rootCheck) && files[i].Name.EndsWith(extensionCheck))
                {
                    if (!filesToPrint.ContainsKey(files[i].Name))
                    {
                        filesToPrint[files[i].Name] = files[i].Size;
                    }
                    else
                    {
                        filesToPrint[files[i].Name + i] = files[i].Size;
                    }
                }
            }

            if (filesToPrint.Count > 0)
            {
                foreach (var file in filesToPrint.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(extensionCheck))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                    else
                    {
                        var index = file.Key.IndexOf(extensionCheck);
                        var toPrint = file.Key.Substring(0, index + extensionCheck.Length);

                        Console.WriteLine($"{toPrint} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
