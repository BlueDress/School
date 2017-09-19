using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Entities;
using Emergency_Skeleton.Models;

namespace Emergency_Skeleton.Entities.EmergencyCentres
{
    public class FireServiceCenter : BaseEmergencyCenter
    {
        public FireServiceCenter(string name, int maximumEmergencies, IList<IEmergency> emergencies) : base(name, maximumEmergencies, emergencies)
        {
        }
    }
}
