using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.Emergencies
{
    public class OrderEmergency : BaseEmergency
    {
        public OrderEmergency(string description, EmergencyLevel emergencyLevel, string registrationTime) : base(description, emergencyLevel, registrationTime)
        {
        }
    }
}
