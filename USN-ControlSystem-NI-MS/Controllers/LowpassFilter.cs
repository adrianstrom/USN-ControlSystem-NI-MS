using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class LowpassFilter
    {
        public double Amplitude => (TimeStep) / (TimeStep + FilterTimeConstant.TotalSeconds);
        public int TimeStep { get; set; }
        public TimeSpan FilterTimeConstant { get; set; };

        private double _previous;

        public double GetFilteredValue(double measuredValue)
        {
            var output = (1 - Amplitude) * _previous + Amplitude * measuredValue;
            _previous = output;
            return output;
        }
    }
}
