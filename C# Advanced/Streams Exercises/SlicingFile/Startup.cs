using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
    public class Startup
    {
        public static void Main()
        {
            var parts = 5;
            var sourceFile = "sliceMe.mp4";
            var destinationDirectory = "./";

            var slicedPieces = Slice(sourceFile, destinationDirectory, parts);

            Assemble(slicedPieces, destinationDirectory);
        }

        private static void Assemble(List<string> slicedFiles, string destinationDirectory)
        {
            var assembledFile = $"{destinationDirectory}AssembledFile.mp4";

            using (var writer = new FileStream(assembledFile, FileMode.Create))
            {
                for (int i = 0; i < slicedFiles.Count; i++)
                {
                    using (var reader = new FileStream(slicedFiles[i], FileMode.Open))
                    {
                        var buffer = new byte[reader.Length];

                        reader.Read(buffer, 0, (int)reader.Length);

                        writer.Write(buffer, 0, (int)reader.Length);
                    }
                }
            }
        }

        private static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            var slicedPieces = new List<string>();

            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var pieceSize = Math.Ceiling(reader.Length / (double)parts);
                var buffer = new byte[4096];
                var actualSlicedPieceSize = 0;

                for (int i = 0; i < parts; i++)
                {
                    var currentPieceSize = 0;
                    var currentPart = $"{destinationDirectory}Partition - {i + 1}.mp4";

                    slicedPieces.Add(currentPart);

                    using (var writer = new FileStream(currentPart, FileMode.Create))
                    {
                        while (true)
                        {
                            if (reader.Read(buffer, 0, 4096) != 4096)
                            {
                                writer.Write(buffer, 0, (int)reader.Length - ((actualSlicedPieceSize * 4) + currentPieceSize));
                                break;
                            }

                            writer.Write(buffer, 0, 4096);
                            currentPieceSize += 4096;

                            if (currentPieceSize >= pieceSize)
                            {
                                actualSlicedPieceSize = currentPieceSize;
                                break;
                            }
                        }
                    }
                }
            }

            return slicedPieces;
        }
    }
}
