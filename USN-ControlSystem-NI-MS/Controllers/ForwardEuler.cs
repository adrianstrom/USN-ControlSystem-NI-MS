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

        public double InitialValue { get; private set; }

        public TimeSpan TimeStep { get; private set; }

        public double Y_previous { get; set; }
        public double Y_min { get; set; } = 0;
        public double Y_max { get; set; } = 99999999999999;

        public double Integrator(double valueFromModel)
        {
            if (_initial)
            {
                Y_previous = InitialValue;
                _initial = false;
            }
            var integratedValue = Clamp(Y_previous + TimeStep.TotalSeconds * valueFromModel);
            return integratedValue;
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
