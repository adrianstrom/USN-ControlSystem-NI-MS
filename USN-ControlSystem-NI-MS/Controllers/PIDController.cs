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

        public bool Manual { get; set; }

        public double SetPoint { get; set; }
        public double ProcessVariable { get; set; }

        public double ControlSignal { get; set; }

        public double Error => Math.Abs(SetPoint - ProcessVariable);

        private double _lastState;

        public PIDController(double Kp, double Ti = default, double Td = default)
        {
            this.Kp = Kp;
            this.Ti = Ti;
            this.Td = Td;
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
        /// <summary>
        /// It is important that the control signal does not jump (too much) when the controller is
        //  switched from automatic to manual mode, or from manual to automatic mode. In other
        //  words, the transfer between the automatic and manual modes should be bumpless.
        //  Bumpless transfer is implemented in commercial controllers. [Finn H. Haugen, Automatic Control]
        /// </summary>
        public void BumplessTransfer()
        {

        }

        public double GetControlSignal()
        {
            if (Manual)
            {
                return ControlSignal;
            }
            var u_p = Kp * Error;
            var u_i = _lastState + AntiWindUp((Kp / Ti) * TimeStep * Error));
            var u_d = 0;

            var u_tot = u_p + u_i;
            _lastState = u_i;
            return u_tot;
        }
    }
}
