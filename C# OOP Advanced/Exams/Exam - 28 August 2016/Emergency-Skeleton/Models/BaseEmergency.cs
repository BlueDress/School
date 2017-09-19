using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Interfaces.Entities;

namespace Emergency_Skeleton.Models
{
    public abstract class BaseEmergency : IEmergency
    {
        private string description;

        private EmergencyLevel emergencyLevel;

        private string registrationTime;

        public BaseEmergency(string description, EmergencyLevel emergencyLevel, string registrationTime)
        {
            this.description = description;
            this.emergencyLevel = emergencyLevel;
            this.registrationTime = registrationTime;
        }

        public int NumberOfCasualties
        {
            get;

            set;
        }

        public EmergencyLevel EmergencyLevel
        {
            get
            {
                return this.emergencyLevel;
            }
        }

        public int PropertyDamage
        {
            get;

            set;
        }

        public string RegistrationTime
        {
            get
            {
                return this.registrationTime;
            }
        }

        public string Status
        {
            get;

            set;
        }
    }
}
