namespace Ch16P18
{
    public class MazeCell
    {
        public string Value { get; set; }

        public MazeCell Left { get; set; }
        public MazeCell Top { get; set; }
        public MazeCell Right { get; set; }
        public MazeCell Bottom { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }

        public bool IsChecked { get; set; }

        public override string ToString()
        {
            return $"Cell at [{this.Row}][{this.Column}] -> Value: {this.Value}";
        }
    }
}
