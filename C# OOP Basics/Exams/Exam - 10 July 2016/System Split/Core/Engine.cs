

using System;
using System.Linq;

namespace System_Split.Core
{
    public class Engine
    {
        public ComponentsOperationsController Controller { get; set; }

        public Engine()
        {
            this.Controller = new ComponentsOperationsController();
        }

        public void Run()
        {
            ReadData(this.Controller);
        }

        private void ReadData(ComponentsOperationsController controller)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("System Split"))
                {
                    Console.WriteLine(controller.SystemSplit());
                    break;
                }
                else
                {
                    var componentsData = input.Split(new[] {'(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var command = componentsData[0];

                    switch (command)
                    {
                        case "RegisterPowerHardware":
                            controller.RegisterPowerHardware(componentsData[1], int.Parse(componentsData[2]), int.Parse(componentsData[3]));
                            break;
                        case "RegisterHeavyHardware":
                            controller.RegisterHeavyHardware(componentsData[1], int.Parse(componentsData[2]), int.Parse(componentsData[3]));
                            break;
                        case "RegisterExpressSoftware":
                            controller.RegisterExpressSoftware(componentsData[1], componentsData[2], int.Parse(componentsData[3]), int.Parse(componentsData[4]));
                            break;
                        case "RegisterLightSoftware":
                            controller.RegisterLightSoftware(componentsData[1], componentsData[2], int.Parse(componentsData[3]), int.Parse(componentsData[4]));
                            break;
                        case "ReleaseSoftwareComponent":
                            controller.ReleaseSoftwareComponent(componentsData[1], componentsData[2]);
                            break;
                        case "Analyze":
                            Console.WriteLine(controller.Analyze());
                            break;
                        case "Dump":
                            controller.Dump(componentsData[1]);
                            break;
                        case "Restore":
                            controller.Restore(componentsData[1]);
                            break;
                        case "Destroy":
                            controller.Destroy(componentsData[1]);
                            break;
                        case "DumpAnalyze":
                            Console.WriteLine(controller.DumpAnalyze());
                            break;
                    }
                }
            }
        }
    }
}
