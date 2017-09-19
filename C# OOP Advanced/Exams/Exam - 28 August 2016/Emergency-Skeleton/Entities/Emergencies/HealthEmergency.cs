using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Emergencies
{
    public class HealthEmergency : BaseEmergency
    {
        public HealthEmergency(string description, EmergencyLevel emergencyLevel, string registrationTime) : base(description, emergencyLevel, registrationTime)
        {
        }
    }
}
