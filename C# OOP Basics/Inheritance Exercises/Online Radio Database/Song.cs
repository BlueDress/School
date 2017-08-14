
namespace Online_Radio_Database
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;
        private int totalLength;

        public string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < 3 || 20 < value.Length)
                {
                    throw new InvalidArtistNameException();
                };
                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < 3 || 20 < value.Length)
                {
                    throw new InvalidSongNameException();
                };
                this.songName = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || 14 < value)
                {
                    throw new InvalidSongMinutesException();
                };
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || 59 < value)
                {
                    throw new InvalidSongSecondsException();
                };
                this.seconds = value;
            }
        }

        public int TotalLength
        {
            get { return this.totalLength; }
            set
            {
                var totalSeconds = this.seconds + this.minutes * 60;
                if (totalSeconds >= 900)
                {
                    throw new InvalidSongLengthException();
                };
                this.totalLength = value;
            }
        }

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
            this.TotalLength = totalLength;
        }
    }
}
