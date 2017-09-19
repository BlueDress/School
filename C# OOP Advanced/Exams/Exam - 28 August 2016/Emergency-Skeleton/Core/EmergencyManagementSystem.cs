using System;
using System.Collections.Generic;
using Emergency_Skeleton.Interfaces.Core;
using Emergency_Skeleton.Interfaces.Entities;
using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Utils;
using Emergency_Skeleton.Entities.Emergencies;
using Emergency_Skeleton.Entities.EmergencyCentres;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Emergency_Skeleton.Core
{
    public class EmergencyManagementSystem : IEmergencyManagementSystem
    {
        private const string propertyEmergency = "PropertyEmergency";
        private const string healthEmergency = "HealthEmergency";
        private const string orderEmergency = "OrderEmergency";

        private const string fireServiceCenter = "FireServiceCenter";
        private const string medicalServiceCenter = "MedicalServiceCenter";
        private const string policeServiceCenter = "PoliceServiceCenter";

        private const string emergencyAsString = "Emergency";

        private const string propertyKey = "Property";
        private const string healthKey = "Health";
        private const string orderKey = "Order";


        private IDictionary<string, IList<IEmergency>> registeredEmergencies;
        private IDictionary<string, IList<IEmergencyCenter>> registeredEmergencyCenters;
        private IDictionary<string, IList<IEmergency>> processedEmergencies;

        public EmergencyManagementSystem(IDictionary<string, IList<IEmergency>> listOfEmergencies, IDictionary<string, IList<IEmergencyCenter>> listOfEmergencyCenters, IDictionary<string, IList<IEmergency>> processedEmergencies)
        {
            this.registeredEmergencies = listOfEmergencies;
            AssignKeys(this.registeredEmergencies);
            this.registeredEmergencyCenters = listOfEmergencyCenters;
            AssignKeys(this.registeredEmergencyCenters);
            this.processedEmergencies = processedEmergencies;
            AssignKeys(this.processedEmergencies);
        }

        public string EmergencyReport(IList<string> arguments)
        {
            var sb = new StringBuilder();

            sb.AppendLine("PRRM Services Live Statistics");
            sb.AppendLine($"Fire Service Centers: {this.registeredEmergencyCenters[propertyKey].Count}");
            sb.AppendLine($"Medical Service Centers: {this.registeredEmergencyCenters[healthKey].Count}");
            sb.AppendLine($"Police Service Centers: {this.registeredEmergencyCenters[orderKey].Count}");
            sb.AppendLine($"Total Processed Emergencies: {this.processedEmergencies.Sum(kvp => kvp.Value.Count)}");
            sb.AppendLine($"Currently Registered Emergencies: {this.registeredEmergencies.Sum(kvp => kvp.Value.Count)}");
            sb.AppendLine($"Total Property Damage Fixed: {this.processedEmergencies[propertyKey].Sum(e => e.PropertyDamage)}");
            sb.AppendLine($"Total Health Casualties Saved: {this.processedEmergencies[healthKey].Sum(e => e.NumberOfCasualties)}");
            sb.AppendLine($"Total Special Cases Processed: {this.processedEmergencies[orderKey].Where(e => e.Status.Equals("Special")).Count()}");

            return sb.ToString();
        }

        public string ProcessEmergencies(IList<string> arguments)
        {
            var emergencyType = arguments[0];

            while (this.registeredEmergencies[emergencyType].Count > 0 && this.registeredEmergencyCenters[emergencyType].Count > 0)
            {
                var currentEmergency = this.registeredEmergencies[emergencyType][0];
                this.registeredEmergencies[emergencyType].RemoveAt(0);
                this.processedEmergencies[emergencyType].Add(currentEmergency);

                var currentEmergencyCenter = this.registeredEmergencyCenters[emergencyType][0];
                currentEmergencyCenter.ProcessEmergency(currentEmergency);
                this.registeredEmergencyCenters[emergencyType].RemoveAt(0);

                if (currentEmergencyCenter.MaximumEmergencies > 0)
                {
                    this.registeredEmergencyCenters[emergencyType].Add(currentEmergencyCenter);
                }
            }

            if (this.registeredEmergencies[emergencyType].Count == 0)
            {
                return $"Successfully responded to all {emergencyType} emergencies.";
            }
            else
            {
                return $"{emergencyType} Emergencies left to process: {this.registeredEmergencies[emergencyType].Count}.";
            }
        }

        public string RegisterFireServiceCenter(IList<string> arguments)
        {
            this.registeredEmergencyCenters[propertyKey].Add((FireServiceCenter)RegisterEmergencyCenter(arguments, fireServiceCenter));

            return $"Registered Fire Service Emergency Center – {arguments[0]}.";
        }

        public string RegisterHealthEmergency(IList<string> arguments)
        {
            var numberOfCasualties = int.Parse(arguments[3]);
            arguments.RemoveAt(3);

            var emergency = (HealthEmergency)RegisterEmergency(arguments, healthEmergency);
            emergency.NumberOfCasualties = numberOfCasualties;

            this.registeredEmergencies[healthKey].Add(emergency);

            return $"Registered Public Health Emergency of level {emergency.EmergencyLevel} at {emergency.RegistrationTime}.";
        }

        public string RegisterMedicalServiceCenter(IList<string> arguments)
        {
            this.registeredEmergencyCenters[healthKey].Add((MedicalServiceCenter)RegisterEmergencyCenter(arguments, medicalServiceCenter));

            return $"Registered Medical Service Emergency Center – {arguments[0]}.";
        }

        public string RegisterOrderEmergency(IList<string> arguments)
        {
            var status = arguments[3];
            arguments.RemoveAt(3);

            var emergency = (OrderEmergency)RegisterEmergency(arguments, orderEmergency);
            emergency.Status = status;

            this.registeredEmergencies[orderKey].Add(emergency);

            return $"Registered Public Order Emergency of level {emergency.EmergencyLevel} at {emergency.RegistrationTime}.";
        }

        public string RegisterPoliceServiceCenter(IList<string> arguments)
        {
            this.registeredEmergencyCenters[orderKey].Add((PoliceServiceCenter)RegisterEmergencyCenter(arguments, policeServiceCenter));

            return $"Registered Police Service Emergency Center – {arguments[0]}.";
        }

        public string RegisterPropertyEmergency(IList<string> arguments)
        {
            var propertyDamage = int.Parse(arguments[3]);
            arguments.RemoveAt(3);

            var emergency = (PropertyEmergency)RegisterEmergency(arguments, propertyEmergency);
            emergency.PropertyDamage = propertyDamage;

            this.registeredEmergencies[propertyKey].Add(emergency);

            return $"Registered Public Property Emergency of level {emergency.EmergencyLevel} at {emergency.RegistrationTime}.";
        }

        private IEmergencyCenter RegisterEmergencyCenter(IList<string> arguments, string centerType)
        {
            var centerName = arguments[0];
            var maximumEmergencies = int.Parse(arguments[1]);
            var emergencies = new List<IEmergency>();

            var emergencyCenterType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(centerType));
            var constructors = emergencyCenterType.GetConstructors();

            return (IEmergencyCenter)constructors[0].Invoke(new object[] { centerName, maximumEmergencies, emergencies });
        }

        private IEmergency RegisterEmergency(IList<string> emergencyInfo, string emergencyName)
        {
            var description = emergencyInfo[0];
            var emergencyLevel = new EmergencyLevel();
            Enum.TryParse(emergencyInfo[1], out emergencyLevel);
            var registrationTime = new RegistrationTime(emergencyInfo[2]).ToString();

            var emergencyType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(emergencyName));
            var constructors = emergencyType.GetConstructors();

            return (IEmergency)constructors[0].Invoke(new object[] { description, emergencyLevel, registrationTime });
        }

        private void AssignKeys(IDictionary<string, IList<IEmergency>> dictionary)
        {
            dictionary[orderKey] = new List<IEmergency>();
            dictionary[healthKey] = new List<IEmergency>();
            dictionary[propertyKey] = new List<IEmergency>();
        }

        private void AssignKeys(IDictionary<string, IList<IEmergencyCenter>> dictionary)
        {
            dictionary[orderKey] = new List<IEmergencyCenter>();
            dictionary[healthKey] = new List<IEmergencyCenter>();
            dictionary[propertyKey] = new List<IEmergencyCenter>();
        }
    }
}
