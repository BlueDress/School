using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Radio_Database
{
    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            var songs = new List<Song>();
            ReadSongsData(songs);
            PrintResult(songs);
        }

        private static void PrintResult(List<Song> songs)
        {
            Console.WriteLine($"Songs added: {songs.Count}");
            var totalSeconds = songs.Sum(s => s.Seconds);
            var totalMinutes = songs.Sum(s => s.Minutes);
            var seconds = totalSeconds % 60;
            var minutes = (totalSeconds / 60 + totalMinutes) % 60;
            var hours = (totalSeconds / 60 + totalMinutes) / 60;
            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }

        private static void ReadSongsData(List<Song> songs)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                var tokens = Console.ReadLine().Split(';');
                var artistName = tokens[0];
                var songName = tokens[1];
                var songLength = tokens[2].Split(':');
                var minutes = int.Parse(songLength[0]);
                var seconds = int.Parse(songLength[1]);
                try
                {
                    var song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

