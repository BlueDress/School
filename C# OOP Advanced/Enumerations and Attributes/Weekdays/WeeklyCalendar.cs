using System.Collections.Generic;

namespace Weekdays
{
    public class WeeklyCalendar
    {
        public List<WeeklyEntry> WeeklySchedule { get; }

        public WeeklyCalendar()
        {
            this.WeeklySchedule = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekday, string notes)
        {
            var newEntry = new WeeklyEntry(weekday, notes);
            this.WeeklySchedule.Add(newEntry);
        }
    }
}
