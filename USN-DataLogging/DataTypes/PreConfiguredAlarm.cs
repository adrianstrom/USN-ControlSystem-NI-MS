using System;

namespace USN_DataLogging.DataTypes
{
    public class PreConfiguredAlarm
    {
        public Guid Id => Guid.NewGuid();
        public AlarmType AlarmType { get; set; }
        public double Limit { get; set; }

        private double _deadBandInPercentage = 1;
        public double DeadBandInPercentage
        {
            get => _deadBandInPercentage;
            set
            {
                if (value > 100)
                {
                    _deadBandInPercentage = 100;
                }
                else if (value < 0)
                {
                    _deadBandInPercentage = 0;
                }
                else
                {
                    _deadBandInPercentage = value;
                }
            }
        }
    }
}
