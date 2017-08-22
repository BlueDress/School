using System.Collections.Generic;
using System.Linq;

namespace Military_Elite
{
    internal class MilitaryOperationsController
    {
        internal List<ISoldier> Soldiers { get; }
        private List<Private> Privates { get; }

        internal MilitaryOperationsController()
        {
            this.Soldiers = new List<ISoldier>();
            this.Privates = new List<Private>();
        }

        internal void RegisterPrivate(string[] privateData)
        {
            var id = privateData[0];
            var firstName = privateData[1];
            var lastName = privateData[2];
            var salary = double.Parse(privateData[3]);

            var privateSoldier = new Private(id, firstName, lastName, salary);

            this.Soldiers.Add(privateSoldier);
            this.Privates.Add(privateSoldier);
        }

        internal void RegisterLeutenantGeneral(string[] leutenantGeneralData)
        {
            var id = leutenantGeneralData[0];
            var firstName = leutenantGeneralData[1];
            var lastName = leutenantGeneralData[2];
            var salary = double.Parse(leutenantGeneralData[3]);

            var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);

            leutenantGeneralData.ToList().RemoveRange(0, 4);

            for (int i = 0; i < leutenantGeneralData.Count(); i++)
            {
                foreach (var privateSoldier in this.Privates)
                {
                    if (privateSoldier.Id.Equals(leutenantGeneralData[i]))
                    {
                        leutenantGeneral.PrivatesUnderCommand.Add(privateSoldier);
                    }
                }
            }

            this.Soldiers.Add(leutenantGeneral);
        }

        internal void RegisterEngineer(string[] engineerData)
        {
            var id = engineerData[0];
            var firstName = engineerData[1];
            var lastName = engineerData[2];
            var salary = double.Parse(engineerData[3]);
            var corps = engineerData[4];

            var engineer = new Engineer(id, firstName, lastName, salary, corps);

            var partsData = engineerData.ToList();
            partsData.RemoveRange(0, 5);

            if (partsData.Count() > 0)
            {
                for (int i = 0; i < partsData.Count(); i += 2)
                {
                    var partName = partsData[i];
                    var workedHours = int.Parse(partsData[i + 1]);

                    var repair = new Repair(partName, workedHours);

                    engineer.Repairs.Add(repair);
                }
            }

            this.Soldiers.Add(engineer);
        }

        internal void RegisterCommando(string[] commandoData)
        {
            var id = commandoData[0];
            var firstName = commandoData[1];
            var lastName = commandoData[2];
            var salary = double.Parse(commandoData[3]);
            var corps = commandoData[4];

            var commando = new Commando(id, firstName, lastName, salary, corps);

            var missionData = commandoData.ToList();
            missionData.RemoveRange(0, 5);

            if (missionData.Count() > 0)
            {
                for (int i = 0; i < missionData.Count(); i += 2)
                {
                    var missionName = missionData[i];
                    var missionState = missionData[i + 1];

                    if (missionState.Equals("inProgress") || missionState.Equals("Finished"))
                    {
                        var mission = new Mission(missionName, missionState);

                        commando.Missions.Add(mission);
                    }
                }
            }

            this.Soldiers.Add(commando);
        }

        internal void RegisterSpy(string[] spyData)
        {
            var id = spyData[0];
            var firstName = spyData[1];
            var lastName = spyData[2];
            var codeNumber = int.Parse(spyData[3]);

            var spy = new Spy(id, firstName, lastName, codeNumber);

            this.Soldiers.Add(spy);
        }
    }
}
