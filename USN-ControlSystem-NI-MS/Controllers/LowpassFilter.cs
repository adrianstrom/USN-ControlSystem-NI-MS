using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class LowpassFilter
    {
        public double Amplitude => (TimeStep.TotalSeconds) / (TimeStep.TotalSeconds + FilterTimeConstant.TotalSeconds);
        public TimeSpan TimeStep { get; set; } = new TimeSpan(0, 0, 1);
        public TimeSpan FilterTimeConstant { get; set; } = new TimeSpan(0, 0, 1);
        public bool Enabled { get; set; } = true;

        private double _previous;

        public double GetFilteredValue(double measuredValue)
        {
            var output = (1 - Amplitude) * _previous + Amplitude * measuredValue;
            _previous = output;
            return output;
        }
    }
}
