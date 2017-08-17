

namespace System_Split.Entities.Component.SoftWare
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) : base(name, capacityConsumption, memoryConsumption)
        {
            this.MemoryConsumption = memoryConsumption * 2;
            this.Type = "Express";
        }
    }
}
