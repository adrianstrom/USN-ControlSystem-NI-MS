using System;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class PIDController
    {
        public double Kp { get; set; }
        public double Ti { get; set; }
        public double Td { get; set; }

        public double OutputMinimum { get; set; } = 0;
        public double OutputMaximum { get; set; } = 5;

        public double TimeStep { get; set; }

        public event EventHandler PIDModeChanged;

        private bool _previousModeManual;

        private bool _manual = false;
        public bool Manual
        {
            get => _manual;
            set
            {
                _previousModeManual = _manual;
                PIDModeChanged?.Invoke(null, null);
                _manual = value;
            }
        }

        public bool AntiWindup { get; set; }

        public double SetPoint { get; set; }
        public double ProcessVariable { get; set; }

        public double ControlSignal { get; set; }

        public double Error => SetPoint - ProcessVariable;

        private double _lastState;

        public PIDController(double Kp, double Ti = default, double Td = default)
        {
            this.Kp = Kp;
            this.Ti = Ti;
            this.Td = Td;

            PIDModeChanged += PIDController_PIDModeChanged;
        }

        private void PIDController_PIDModeChanged(object sender, EventArgs e)
        {
            if (_previousModeManual && !Manual)
            {
                _lastState = 0;
            }
            else if (!_previousModeManual && Manual)
            {

            }
        }

        private double AntiWindUp(double value)
        {
            if (value <= OutputMinimum)
            {
                return OutputMinimum;
            }
            if (value >= OutputMaximum)
            {
                return OutputMaximum;
            }
            return value;
        }

        public double GetControlSignal()
        {
            if (Manual)
            {
                return ControlSignal;
            }
            var u_p = Kp * Error;
            var u_i = AntiWindUp((_lastState + (Kp / Ti) * TimeStep) * Error);

            var u_tot = u_p + u_i;
            _lastState = u_p + u_i;
            return u_tot;
        }
    }
}
