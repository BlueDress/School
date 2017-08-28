using System;

namespace Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private Weekday weekday;
        private string notes;

        public WeeklyEntry(string weekday, string notes)
        {
            Enum.TryParse(weekday, out this.weekday);
            this.notes = notes;
        }

        public int CompareTo(WeeklyEntry other)
        {
            return this.weekday.CompareTo(other.weekday) != 0 ? this.weekday.CompareTo(other.weekday) : this.notes.CompareTo(other.notes);
        }

        public override string ToString()
        {
            return $"{this.weekday} - {this.notes}";
        }
    }
}
