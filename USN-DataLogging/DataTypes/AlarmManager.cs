using System;
using System.Collections.Generic;

namespace USN_DataLogging.DataTypes
{
    public class AlarmManager
    {
        private List<PreConfiguredAlarm> _preConfiguredAlarms => GetPreConfiguredAlarms();
        private Dictionary<Guid, PreConfiguredAlarm> _triggeredAlarms = new Dictionary<Guid, PreConfiguredAlarm>();
        private SqlHandler _sqlHandler;

        public AlarmManager(SqlHandler sqlHandler)
        {
            _sqlHandler = sqlHandler;
        }

        private PreConfiguredAlarm CreatePreConfiguredAlarm(AlarmType alarmType, double value, double deadBandInPercentage)
        {
            var preConfiguredAlarm = new PreConfiguredAlarm();
            preConfiguredAlarm.AlarmType = alarmType;
            preConfiguredAlarm.Limit = value;
            preConfiguredAlarm.DeadBandInPercentage = deadBandInPercentage;
            return preConfiguredAlarm;
        }

        public List<PreConfiguredAlarm> GetPreConfiguredAlarms()
        {
            var preconfiguredAlarms = new List<PreConfiguredAlarm>();

            var temperatureHighAlarm = CreatePreConfiguredAlarm(AlarmType.Hi, 40, 1);
            var temperatureHighHighAlarm = CreatePreConfiguredAlarm(AlarmType.HiHi, 50, 1);
            var temperatureLowAlarm = CreatePreConfiguredAlarm(AlarmType.Lo, 20, 1);
            var temperatureLowLowAlarm = CreatePreConfiguredAlarm(AlarmType.LoLo, 10, 1);

            preconfiguredAlarms.Add(temperatureHighAlarm);
            preconfiguredAlarms.Add(temperatureHighHighAlarm);
            preconfiguredAlarms.Add(temperatureLowAlarm);
            preconfiguredAlarms.Add(temperatureLowLowAlarm);

            return preconfiguredAlarms;
        }

        private bool HiAlarm(PreConfiguredAlarm preConfiguredAlarm, double measuredValue) =>
            preConfiguredAlarm.AlarmType == AlarmType.Hi
                    || preConfiguredAlarm.AlarmType == AlarmType.HiHi
                    || preConfiguredAlarm.AlarmType == AlarmType.HiHiHi
                    && preConfiguredAlarm.Limit >= measuredValue
                    && DeadBand(preConfiguredAlarm.DeadBandInPercentage, measuredValue);

        private bool LoAlarm(PreConfiguredAlarm preConfiguredAlarm, double measuredValue) =>
            preConfiguredAlarm.AlarmType == AlarmType.Lo
                    || preConfiguredAlarm.AlarmType == AlarmType.LoLo
                    || preConfiguredAlarm.AlarmType == AlarmType.LoLoLo
                    && preConfiguredAlarm.Limit <= measuredValue
                    && DeadBand(preConfiguredAlarm.DeadBandInPercentage, measuredValue);

        private bool DeadBand(double deadBandInPercentage, double measuredValue) =>
            measuredValue >= deadBandInPercentage * measuredValue
                    && measuredValue <= deadBandInPercentage * measuredValue;

        public void CheckForAlarm(double measuredValue)
        {
            foreach (var preConfiguredAlarm in _preConfiguredAlarms)
            {
                if (HiAlarm(preConfiguredAlarm, measuredValue))
                {
                    //_sqlHandler.InsertAlarm();
                    _triggeredAlarms.Add(preConfiguredAlarm.Id, preConfiguredAlarm);
                }
                else if (LoAlarm(preConfiguredAlarm, measuredValue))
                {
                    //_sqlHandler.InsertAlarm();
                    _triggeredAlarms.Add(preConfiguredAlarm.Id, preConfiguredAlarm);
                }
            }
        }
    }
}
