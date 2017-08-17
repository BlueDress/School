


namespace System_Split.Entities.Component.Hardware
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, int capacity, int memory) : base(name, capacity, memory)
        {
            this.Capacity = capacity * 2;
            this.Memory = memory - (int)(memory * 0.25);
            this.Type = "Heavy";
            this.MaxCapacity = capacity * 2;
            this.MaxMemory = memory - (int)(memory * 0.25);
        }
    }
}
