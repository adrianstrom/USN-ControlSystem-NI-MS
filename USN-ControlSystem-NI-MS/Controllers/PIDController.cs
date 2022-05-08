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

        private bool _previousModeManual;

        private bool _manual = true;
        public bool Manual
        {
            get => _manual;
            set
            {
                _previousModeManual = _manual;
                _manual = value;
            }
        }

        public bool AntiWindup { get; set; }

        public double SetPoint { get; set; }
        public double ProcessVariable { get; set; }

        public double ControlSignal { get; set; }

        public double Error => SetPoint - ProcessVariable;

        private double u_i_k_previous;

        public PIDController(double Kp, double Ti = default, double Td = default)
        {
            this.Kp = Kp;
            this.Ti = Ti;
            this.Td = Td;
        }

        public bool Transferred = false;

        private void BumplessTransfer()
        {
            if (_previousModeManual && !Manual && !Transferred)
            {
                u_i_k_previous = 0;
                Transferred = true;
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
            BumplessTransfer();
            var u_man = ControlSignal;
            var u_p = Manual ? 0 : Kp * Error;
            var u_i = Manual ? 0 : AntiWindUp(u_i_k_previous + (Kp / Ti) * TimeStep * Error);
            var u_d = 0;

            var u_tot = u_man + u_p + u_i + u_d;

            u_i_k_previous = u_i;
            return AntiWindUp(u_tot);
        }
    }
}
