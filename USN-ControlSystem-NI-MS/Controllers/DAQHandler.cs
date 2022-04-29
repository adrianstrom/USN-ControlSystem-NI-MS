using NationalInstruments.DAQmx;

namespace USN_ControlSystem_NI_MS.Controllers

{
    public static class VoltageConverter
    {
        public static double Temperature1Converter(double voltage) => (25 + 15 * voltage) / 2;
    }
    public class DAQBase
    {
        protected Task _task;

        public DAQBase()
        {
            _task = new Task();
        }
    }

    public class DAQReader : DAQBase
    {
        public DAQReader(string channelName, double voltageMinValue, double voltageMaxValue) : base()
        {
            _task.AIChannels.CreateVoltageChannel(
                channelName,
                null,
                AITerminalConfiguration.Differential,
                voltageMinValue,
                voltageMaxValue,
                AIVoltageUnits.Volts);
        }

        public double ReadFromDAQ()
        {
            var reader = new AnalogSingleChannelReader(_task.Stream);
            var value = reader.ReadSingleSample();
            return value;
        }

        public class DAQWriter : DAQBase
        {
            public DAQWriter(string channelName, double voltageMinValue, double voltageMaxValue) : base()
            {
                _task.AOChannels.CreateVoltageChannel(
                    channelName,
                    null,
                    voltageMinValue,
                    voltageMaxValue,
                    AOVoltageUnits.Volts);
            }

            public void WriteToDAQ(double valueToWrite)
            {
                var writer = new AnalogSingleChannelWriter(_task.Stream);
                writer.WriteSingleSample(true, valueToWrite);
            }
        }
    }
}
