


namespace System_Split.Entities.Component.SoftWare
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, int capacityConsumption, int memoryConsumption) : base(name, capacityConsumption, memoryConsumption)
        {
            this.CapacityConsumption = capacityConsumption + (int)(capacityConsumption * 0.5);
            this.MemoryConsumption = memoryConsumption - (int)(memoryConsumption * 0.5);
            this.Type = "Light";
        }
    }
}
