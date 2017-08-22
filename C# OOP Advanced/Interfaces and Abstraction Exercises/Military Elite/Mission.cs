using System;

namespace Military_Elite
{
    internal class Mission : IMission
    {
        public string CodeName
        {
            get;
        }

        public string MissionState
        {
            get;
        }

        public Mission(string codeName, string missionState)
        {
            this.CodeName = codeName;
            this.MissionState = missionState;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MissionState}";
        }
    }
}
