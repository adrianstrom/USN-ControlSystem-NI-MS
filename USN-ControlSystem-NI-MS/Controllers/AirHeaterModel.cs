using System;
using System.Linq;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class AirHeaterModel : SimulatorBase
    {
        public ForwardEuler _euler;

        public AirHeaterModel()
        {
            _euler = new ForwardEuler(InitialTemperature, TimeStep);
        }

        public double[] array => new double[(int)Math.Round(TimeDelay.TotalSeconds / TimeStep.TotalSeconds)];

        public void Output()
        {
            //TemperatureTubeOutlet = _euler.IntegratedValue;
        }

        public double CalculateU_Delay()
        {
            return array.Last();
        }

        public double InitialTemperature { get; set; } = 20;

        /// <summary>
        /// Outlet temperature
        /// </summary>
        public double TemperatureTubeOutlet => _euler.IntegratedValue;

        /// <summary>
        ///  Environmental (room) temperature.
        /// </summary>
        public double TemperatureEnvironment { get; set; } = 20;

        /// <summary>
        /// Control signal to the heater.
        /// </summary>
        public double ControlSignal { get; set; }

        public int TimeConstant { get; set; } = 22;

        public double HeaterGain { get; set; } = 3.5;

        public TimeSpan TimeDelay { get; set; } = new TimeSpan(0, 0, 0, 10);

        public bool Initial { get; set; }

        public double CalculateTemperatureRateOfChange()
        {
            var u_delay = CalculateU_Delay();
            var dT_dt = ((TemperatureEnvironment - TemperatureTubeOutlet) + HeaterGain * u_delay) / (TimeConstant);
            return dT_dt;
        }
    }
}
