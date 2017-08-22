namespace Military_Elite
{
    internal class Repair : IRepair
    {
        public int HourWorked
        {
            get;
        }

        public string PartName
        {
            get;
        }

        public Repair(string partName, int workedHours)
        {
            this.PartName = partName;
            this.HourWorked = workedHours;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HourWorked}";
        }
    }
}
