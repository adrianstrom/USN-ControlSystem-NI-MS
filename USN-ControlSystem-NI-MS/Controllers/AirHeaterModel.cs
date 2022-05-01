namespace USN_ControlSystem_NI_MS.Controllers
{
    public class ForwardEuler
    {
        public bool Initial { get; set; }

        public double InitialValue { get; set; }

        public double TimeStep { get; set; }

        public double IntegratedValue { get; set; }

        public double Y_previous { get; set; }
        public double Y_min { get; set; }
        public double Y_max { get; set; }

        public void Integrate(double valueFromModel)
        {
            if (Initial)
            {
                Initial = false;
                Y_previous = InitialValue;
            }
            IntegratedValue = Clamp(Y_previous * TimeStep * valueFromModel);
        }

        private double Clamp(double value)
        {
            if (value <= Y_min)
            {
                return Y_min;
            }
            if (value >= Y_max)
            {
                return Y_max;
            }
            return value;
        }
    }

    public class AirHeaterModel
    {
        public double InitialTemperature { get; set; }

        public double TemperatureTubeOutlet { get; set; }

        public double TemperatureEnvironment { get; set; } = 20;
        public double ControlSignal { get; set; }
        public int TimeConstant { get; set; } = 22;
        public double HeaterGain { get; set; } = 3.5;
        public int TimeDelay { get; set; }
        public double TimeStep { get; set; }
        public double TemperatureRateOfChange { get; set; }

        public bool Initial { get; set; }

        public double PreviousRate { get; set; }

        public double CalculateTemperatureRateOfChange()
        {
            var dT_dt = (TemperatureTubeOutlet - TemperatureEnvironment - HeaterGain * TimeDelay) / (1);
            return dT_dt;
        }
    }
}
