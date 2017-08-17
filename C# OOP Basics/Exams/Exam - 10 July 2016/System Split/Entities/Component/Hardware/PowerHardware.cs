



namespace System_Split.Entities.Component.Hardware
{
    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, int capacity, int memory) : base(name, capacity, memory)
        {
            this.Capacity = capacity - (int)(capacity * 0.75);
            this.Memory = memory + (int)(memory * 0.75);
            this.Type = "Power";
            this.MaxCapacity = capacity - (int)(capacity * 0.75);
            this.MaxMemory = memory + (int)(memory * 0.75);
        }
    }
}
