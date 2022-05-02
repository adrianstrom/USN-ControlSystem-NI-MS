using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class AirHeaterModel
    {
        private ForwardEuler _euler;

        public AirHeaterModel()
        {
            _euler = new ForwardEuler(InitialTemperature, TimeSpan.FromSeconds(1));
        }

        public void Output()
        {
            //TemperatureTubeOutlet = _euler.Integrate(CalculateTemperatureRateOfChange());
        }

        public double InitialTemperature { get; set; }

        public double TemperatureTubeOutlet { get; set; }

        public double TemperatureEnvironment { get; set; } = 20;
        public double ControlSignal { get; set; }
        public int TimeConstant { get; set; } = 22;
        public double HeaterGain { get; set; } = 3.5;
        public int TimeDelay { get; set; } // Add time delay
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
