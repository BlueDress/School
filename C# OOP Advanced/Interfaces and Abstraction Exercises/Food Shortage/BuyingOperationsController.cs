using System.Collections.Generic;

namespace Food_Shortage
{
    internal class BuyingOperationsController
    {
        internal Dictionary<string, IBuyer> Buyers { get; }
        
        internal BuyingOperationsController()
        {
            this.Buyers = new Dictionary<string, IBuyer>();
        }

        internal void RegisterCitizen(string[] citizenData)
        {
            var name = citizenData[0];
            var age = int.Parse(citizenData[1]);
            var id = citizenData[2];
            var birthdate = citizenData[3];

            var citizen = new Citizen(name, age, id, birthdate);

            Buyers[name] = citizen;
        }

        internal void RegisterRebel(string[] rebelData)
        {
            var name = rebelData[0];
            var age = int.Parse(rebelData[1]);
            var group = rebelData[2];

            var rebel = new Rebel(name, age, group);

            Buyers[name] = rebel;
        }
    }
}
