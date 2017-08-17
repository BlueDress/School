using System.Collections.Generic;
using System_Split.Entities.Component.SoftWare;

namespace System_Split.Entities.Component.Hardware
{
    public abstract class Hardware : Component
    {
        public int Capacity { get; set; }
        public int Memory { get; set; }
        public List<Software> SoftwareComponentsInstalled { get; set; }
        public int MaxCapacity { get; set; }
        public int MaxMemory { get; set; }

        public Hardware(string name, int capacity, int memory) : base(name)
        {
            this.Capacity = capacity;
            this.Memory = memory;
            this.SoftwareComponentsInstalled = new List<Software>();
            this.MaxCapacity = capacity;
            this.MaxMemory = memory;
        }
    }
}
