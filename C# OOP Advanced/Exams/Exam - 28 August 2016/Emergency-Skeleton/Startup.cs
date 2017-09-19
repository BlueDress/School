using Emergency_Skeleton.Core;
using Emergency_Skeleton.Interfaces.Entities;
using Emergency_Skeleton.IO;
using System.Collections.Generic;

namespace Emergency_Skeleton
{
    public class Startup
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var emergencies = new Dictionary<string, IList<IEmergency>>();
            var emergencyCenters = new Dictionary<string, IList<IEmergencyCenter>>();
            var processedEmergencies = new Dictionary<string, IList<IEmergency>>();

            var emergencyManager = new EmergencyManagementSystem(emergencies, emergencyCenters, processedEmergencies);

            var engine = new Engine(reader, writer, emergencyManager);
            engine.Run();
        }
    }
}
