using System;
using System.IO;

namespace Ch21P01
{
    public class Startup
    {
        public static void Main()
        {
            string filePath = "example.bin";

            using (FileStream fileStream = new FileStream(filePath, FileMode.CreateNew))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        binaryWriter.Write(i);
                    }
                }
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine(binaryReader.ReadInt32());
                    }
                }
            }
        }
    }
}
