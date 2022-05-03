using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class ForwardEuler
    {
        public ForwardEuler(double initialValue, TimeSpan timeStep)
        {
            InitialValue = initialValue;
            TimeStep = timeStep;
        }

        private bool _initial = true;

        public int NumberOfTimesIntegrated { get; set; }

        public double InitialValue { get; private set; }

        public TimeSpan TimeStep { get; private set; }

        public double IntegratedValue { get; set; }

        public double Y_previous { get; set; }
        public double Y_min { get; set; } = 0;
        public double Y_max { get; set; } = 99999999999999;

        public void Integrate(double valueFromModel)
        {
            if (_initial)
            {
                Y_previous = InitialValue;
                _initial = false;
            }
            IntegratedValue = Clamp(Y_previous + TimeStep.TotalSeconds * valueFromModel);
            NumberOfTimesIntegrated++;
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
}
