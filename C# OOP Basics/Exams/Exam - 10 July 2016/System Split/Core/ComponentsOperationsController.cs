

using System.Collections.Generic;
using System_Split.Entities.Component.Hardware;
using System.Linq;
using System_Split.Entities.Component.SoftWare;
using System.Text;

namespace System_Split.Core
{
    public class ComponentsOperationsController
    {
        public List<Hardware> HardwareComponents { get; set; }
        public List<Hardware> DumpedComponents { get; set; }

        public ComponentsOperationsController()
        {
            this.HardwareComponents = new List<Hardware>();
            this.DumpedComponents = new List<Hardware>();
        }

        public void RegisterPowerHardware(string name, int capacity, int memory)
        {
            var powerHardware = new PowerHardware(name, capacity, memory);
            this.HardwareComponents.Add(powerHardware);
        }

        public void RegisterHeavyHardware(string name, int capacity, int memory)
        {
            var heavyHardware = new HeavyHardware(name, capacity, memory);
            this.HardwareComponents.Add(heavyHardware);
        }

        public void RegisterExpressSoftware(string hardwareComponentName, string name, int capacityConsumption, int memoryConsumption)
        {
            if (this.HardwareComponents.Any(hw => hw.Name.Equals(hardwareComponentName)))
            {
                var hardwareComponent = this.HardwareComponents.Find(hw => hw.Name.Equals(hardwareComponentName));

                if (hardwareComponent.Capacity >= capacityConsumption && hardwareComponent.Memory >= memoryConsumption)
                {
                    hardwareComponent.Capacity -= capacityConsumption;
                    hardwareComponent.Memory -= memoryConsumption;
                    var softwareComponent = new ExpressSoftware(name, capacityConsumption, memoryConsumption);
                    hardwareComponent.SoftwareComponentsInstalled.Add(softwareComponent);
                }
            }
        }

        public void RegisterLightSoftware(string hardwareComponentName, string name, int capacityConsumption, int memoryConsumption)
        {
            if (this.HardwareComponents.Any(hw => hw.Name.Equals(hardwareComponentName)))
            {
                var hardwareComponent = this.HardwareComponents.Find(hw => hw.Name.Equals(hardwareComponentName));

                if (hardwareComponent.Capacity >= capacityConsumption && hardwareComponent.Memory >= memoryConsumption)
                {
                    hardwareComponent.Capacity -= capacityConsumption;
                    hardwareComponent.Memory -= memoryConsumption;
                    var softwareComponent = new LightSoftware(name, capacityConsumption, memoryConsumption);
                    hardwareComponent.SoftwareComponentsInstalled.Add(softwareComponent);
                }
            }
        }

        public void ReleaseSoftwareComponent(string hardwareComponentName, string softwareComponentName)
        {
            if (this.HardwareComponents.Any(hw => hw.Name.Equals(hardwareComponentName)))
            {
                var hardwareComponent = this.HardwareComponents.Find(hw => hw.Name.Equals(hardwareComponentName));

                if (hardwareComponent.SoftwareComponentsInstalled.Any(swc => swc.Name.Equals(softwareComponentName)))
                {
                    var softwareComponent = hardwareComponent.SoftwareComponentsInstalled.Find(swc => swc.Name.Equals(softwareComponentName));
                    hardwareComponent.SoftwareComponentsInstalled.Remove(softwareComponent);
                }
            }
        }

        public string Analyze()
        {
            var sb = new StringBuilder();

            sb.AppendLine("System Analysis");
            sb.AppendLine($"Hardware Components: {HardwareComponents.Count()}");
            sb.AppendLine($"Software Components: {CountOfSoftwareComponents()}");
            sb.AppendLine($"Total Operational Memory: {TotalOperationalMemoryInUse()} / {MaximumMemory()}");
            sb.AppendLine($"Total Capacity Taken: {TotalCapacityTaken()} / {MaximumCapacity()}");

            return sb.ToString();
        }

        private int MaximumCapacity()
        {
            return this.HardwareComponents.Sum(hwc => hwc.MaxCapacity);
        }

        private int TotalCapacityTaken()
        {
            return this.HardwareComponents.Sum(hwc => hwc.SoftwareComponentsInstalled.Sum(swc => swc.CapacityConsumption));
        }

        private int MaximumMemory()
        {
            return this.HardwareComponents.Sum(hwc => hwc.MaxMemory);
        }

        private int TotalOperationalMemoryInUse()
        {
            return this.HardwareComponents.Sum(hwc => hwc.SoftwareComponentsInstalled.Sum(swc => swc.MemoryConsumption));
        }

        private int CountOfSoftwareComponents()
        {
            return this.HardwareComponents.Sum(hwc => hwc.SoftwareComponentsInstalled.Count());
        }

        public string SystemSplit()
        {
            var sb = new StringBuilder();

            foreach (var hardwareComponent in HardwareComponents.OrderByDescending(hwc => hwc.Type))
            {
                sb.AppendLine($"Hardware Component – {hardwareComponent.Name}");
                sb.AppendLine($"Express Software Components: {CountOfExpressSoftwareComponents(hardwareComponent)}");
                sb.AppendLine($"Light Software Components: {CountOfLightSoftwareComponents(hardwareComponent)}");
                sb.AppendLine($"Memory Usage: {MemoryInUse(hardwareComponent)} / {hardwareComponent.MaxMemory}");
                sb.AppendLine($"Capacity Usage: {CapacityUsed(hardwareComponent)} / {hardwareComponent.MaxCapacity}");
                sb.AppendLine($"Type: {hardwareComponent.Type}");
                if (hardwareComponent.SoftwareComponentsInstalled.Count > 0)
                {
                    sb.AppendLine($"Software Components: {string.Join(", ", hardwareComponent.SoftwareComponentsInstalled)}");
                }
                else
                {
                    sb.AppendLine("Software Components: None");
                }
            }
            return sb.ToString();
        }

        private int CapacityUsed(Hardware hardwareComponent)
        {
            return hardwareComponent.SoftwareComponentsInstalled.Sum(swc => swc.CapacityConsumption);
        }
        
        private int MemoryInUse(Hardware hardwareComponent)
        {
            return hardwareComponent.SoftwareComponentsInstalled.Sum(swc => swc.MemoryConsumption);
        }

        private object CountOfLightSoftwareComponents(Hardware hardwareComponent)
        {
            return hardwareComponent.SoftwareComponentsInstalled.Count(swc => swc.Type.Equals("Light"));
        }

        private int CountOfExpressSoftwareComponents(Hardware hardwareComponent)
        {
            return hardwareComponent.SoftwareComponentsInstalled.Count(swc => swc.Type.Equals("Express"));
        }

        public void Dump(string hardwareComponentName)
        {
            if (this.HardwareComponents.Any(hwc => hwc.Name.Equals(hardwareComponentName)))
            {
                var hardwareComponent = this.HardwareComponents.Find(hwc => hwc.Name.Equals(hardwareComponentName));
                this.DumpedComponents.Add(hardwareComponent);
                this.HardwareComponents.Remove(hardwareComponent);
            }
        }

        public void Restore(string hardwareComponentName)
        {
            if (this.DumpedComponents.Any(dc => dc.Name.Equals(hardwareComponentName)))
            {
                var dumpedComponent = this.DumpedComponents.Find(dc => dc.Name.Equals(hardwareComponentName));
                this.HardwareComponents.Add(dumpedComponent);
                this.DumpedComponents.Remove(dumpedComponent);
            }
        }

        public void Destroy(string hardwareComponentName)
        {
            if (this.DumpedComponents.Any(dc => dc.Name.Equals(hardwareComponentName)))
            {
                var dumpedComponent = this.DumpedComponents.Find(dc => dc.Name.Equals(hardwareComponentName));
                this.DumpedComponents.Remove(dumpedComponent);
            }
        }

        public string DumpAnalyze()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Dump Analysis");
            sb.AppendLine($"Power Hardware Components: {this.DumpedComponents.Count(dc => dc.Type.Equals("Power"))}");
            sb.AppendLine($"Heavy Hardware Components: {this.DumpedComponents.Count(dc => dc.Type.Equals("Heavy"))}");
            sb.AppendLine($"Express Software Components: - {CountOfExpressSoftwareComponents()}");
            sb.AppendLine($"Light Software Components: - {CountOfLightSoftwareComponents()}");
            sb.AppendLine($"Total Dumped Memory: {TotalDumpedMemory()}");
            sb.AppendLine($"Total Dumped Capacity: {TotalDumpedCapacity()}");

            return sb.ToString();
        }

        private int CountOfExpressSoftwareComponents()
        {
            return this.DumpedComponents.Sum(dc => dc.SoftwareComponentsInstalled.Count(swc => swc.Type.Equals("Express")));
        }

        private int CountOfLightSoftwareComponents()
        {
            return this.DumpedComponents.Sum(dc => dc.SoftwareComponentsInstalled.Count(swc => swc.Type.Equals("Light")));
        }

        private int TotalDumpedMemory()
        {
            return this.DumpedComponents.Sum(dc => dc.SoftwareComponentsInstalled.Sum(swc => swc.MemoryConsumption));
        }

        private int TotalDumpedCapacity()
        {
            return this.DumpedComponents.Sum(dc => dc.SoftwareComponentsInstalled.Sum(swc => swc.CapacityConsumption));
        }
    }
}
