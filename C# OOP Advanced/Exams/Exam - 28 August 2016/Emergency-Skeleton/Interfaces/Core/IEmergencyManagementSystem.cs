using System.Collections.Generic;

namespace Emergency_Skeleton.Interfaces.Core
{
    public interface IEmergencyManagementSystem
    {
        string RegisterPropertyEmergency(IList<string> arguments);

        string RegisterHealthEmergency(IList<string> arguments);

        string RegisterOrderEmergency(IList<string> arguments);

        string RegisterFireServiceCenter(IList<string> arguments);

        string RegisterMedicalServiceCenter(IList<string> arguments);

        string RegisterPoliceServiceCenter(IList<string> arguments);

        string ProcessEmergencies(IList<string> arguments);

        string EmergencyReport(IList<string> arguments);
    }
}
