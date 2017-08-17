

namespace System_Split.Entities.Component.SoftWare
{
    public abstract class Software : Component
    {
        public int CapacityConsumption { get; set; }
        public int MemoryConsumption { get; set; }

        public Software(string name, int capacityConsumption, int memoryConsumption) : base(name)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
