using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace ZippingSlicedFiles
{
    public class Startup
    {
        public static void Main()
        {
            var parts = 5;
            var sourceFile = "../SlicingFile/sliceMe.mp4";
            var destinationDirectory = "./";

            var zippedFiles = Zip(sourceFile, destinationDirectory, parts);

            Unzip(zippedFiles, destinationDirectory);
        }

        private static void Unzip(List<string> zippedFiles, string destinationDirectory)
        {
            var assembledFile = $"{destinationDirectory}AssembledFile.mp4";

            using (var writer = new FileStream(assembledFile, FileMode.Create))
            {
                var pieceSize = Math.Ceiling(7164754 / (double)zippedFiles.Count);
                var buffer = new byte[4096];
                var actualSlicedPieceSize = 0;

                for (int i = 0; i < zippedFiles.Count; i++)
                {
                    var currentPieceSize = 0;

                    using (var unzipper = new GZipStream(new FileStream(zippedFiles[i], FileMode.Open), CompressionMode.Decompress))
                    {
                        while (true)
                        {
                            if (unzipper.Read(buffer, 0, 4096) != 4096)
                            {
                                writer.Write(buffer, 0, 4096);
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
        }

        private static List<string> Zip(string sourceFile, string destinationDirectory, int parts)
        {
            var zippedFiles = new List<string>();

            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var pieceSize = Math.Ceiling(reader.Length / (double)parts);
                var buffer = new byte[4096];
                var actualSlicedPieceSize = 0;

                for (int i = 0; i < parts; i++)
                {
                    var currentPieceSize = 0;
                    var currentPart = $"{destinationDirectory}Partition - {i + 1}.mp4.gz";

                    zippedFiles.Add(currentPart);

                    using (var zipper = new GZipStream(new FileStream(currentPart, FileMode.Create), CompressionLevel.Optimal))
                    {
                        while (true)
                        {
                            if (reader.Read(buffer, 0, 4096) != 4096)
                            {
                                zipper.Write(buffer, 0, (int)reader.Length - ((actualSlicedPieceSize * 4) + currentPieceSize));
                                break;
                            }

                            zipper.Write(buffer, 0, 4096);
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

            return zippedFiles;
        }
    }
}
