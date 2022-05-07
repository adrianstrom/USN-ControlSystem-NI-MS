using System;
using System.Linq;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class AirHeaterModel : SimulatorBase
    {
        public ForwardEuler _euler;

        public AirHeaterModel(double initialTemperature)
        {
            _euler = new ForwardEuler(initialTemperature, TimeStep);
            Delay_Array = new double[Nd];
            Delay_Array = Enumerable.Repeat<double>(3, Delay_Array.Length).ToArray();
        }

        public int Nd => (int)Math.Round(TimeDelay.TotalSeconds / TimeStep.TotalSeconds) + 1;

        public double[] Delay_Array { get; set; }

        public double[] ShiftRight(double[] arr)
        {
            double[] array = new double[arr.Length];
            for (int i = 1; i < arr.Length; i++)
            {
                array[i] = arr[i - 1];
            }
            array[0] = ControlSignal;
            return array;
        }

        public void ControlSignalDelay()
        {
            TimeDelayedControlSignal = Delay_Array.Last();
            Delay_Array = ShiftRight(Delay_Array);
        }

        public double InitialTemperatureOutlet { get; set; } = 20;

        /// <summary>
        /// Outlet temperature.
        /// </summary>
        public double TemperatureTubeOutlet { get; set; } = 20;

        /// <summary>
        ///  Environmental (room) temperature.
        /// </summary>
        public double TemperatureEnvironment { get; set; } = 20;

        /// <summary>
        /// Time Delayed Control signal to the heater. Shouldn't be exposed.
        /// </summary>
        private double TimeDelayedControlSignal { get; set; }

        /// <summary>
        /// Real time Control signal to the heater.
        /// </summary>
        public double ControlSignal { get; set; } = 2;

        public int TimeConstant { get; set; } = 22;

        public double HeaterGain { get; set; } = 3.5;

        private bool Initial { get; set; }

        private double _lastState;

        public TimeSpan TimeDelay { get; set; } = new TimeSpan(0, 0, 0, 3);

        public double CalculateOutput()
        {
            ControlSignalDelay();
            if (Initial)
            {
                Initial = false;
                return InitialTemperatureOutlet;
            }
            else
            {
                _lastState = TemperatureTubeOutlet;
                var dT_dt = ((TemperatureEnvironment - _lastState) + HeaterGain * TimeDelayedControlSignal) / (TimeConstant);
                var output = _euler.Integrator(dT_dt);
                return output;
            }
        }
    }
}
