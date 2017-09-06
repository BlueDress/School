using System;

namespace Traffic_Lights
{
    public class TrafficSignal
    {
        private TrafficLights light;

        public TrafficSignal(string light)
        {
            this.light = (TrafficLights)Enum.Parse(typeof(TrafficLights), light);
        }

        public void ChangeLight()
        {
            var lights = typeof(TrafficLights).GetEnumValues();
            this.light = (TrafficLights)lights.GetValue(((int)this.light + 1) % 3);
        }

        public override string ToString()
        {
            return this.light.ToString();
        }
    }
}
