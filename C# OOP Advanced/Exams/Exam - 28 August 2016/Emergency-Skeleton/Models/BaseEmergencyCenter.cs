using Emergency_Skeleton.Interfaces.Entities;
using System.Collections.Generic;

namespace Emergency_Skeleton.Models
{
    public abstract class BaseEmergencyCenter : IEmergencyCenter
    {
        private string name;

        private int maximumEmergencies;

        private IList<IEmergency> emergencies;

        public BaseEmergencyCenter(string name, int maximumEmergencies, IList<IEmergency> emergencies)
        {
            this.name = name;
            this.maximumEmergencies = maximumEmergencies;
            this.emergencies = emergencies;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int MaximumEmergencies
        {
            get
            {
                return this.maximumEmergencies;
            }
        }

        public IList<IEmergency> Emergencies
        {
            get
            {
                return this.emergencies;
            }
        }

        public void ProcessEmergency(IEmergency emergencyToProcess)
        {
            this.emergencies.Add(emergencyToProcess);
            this.maximumEmergencies--;
        }
    }
}
