namespace Emergency_Skeleton.Interfaces.Entities
{
    public interface IEmergencyCenter
    {
        int MaximumEmergencies { get; }

        void ProcessEmergency(IEmergency emergencyToProcess);
    }
}
