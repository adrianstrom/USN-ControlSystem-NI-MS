namespace USN_ControlSystem_NI_MS.Controllers
{
    public class LowpassFilter
    {
        public double Amplitude => (TimeStep) / (TimeStep + FilterTimeConstant);
        public int TimeStep { get; set; }
        public int FilterTimeConstant { get; set; }

        private double _previous;

        public double GetFilteredValue(double measuredValue) => (1 - Amplitude) * _previous + Amplitude * measuredValue;
    }
}
