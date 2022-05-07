using NationalInstruments.DAQmx;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public interface IDataReader
    {
        double ReadFromDAQ();
    }
    public interface IDataWriter
    {
        void WriteToDAQ(double valueToWrite);
    }
    public class TemperatureReader : IDataReader
    {
        public double ReadFromDAQ() => 5;
    }
    public class ControlSignalWriter : IDataWriter
    {
        public void WriteToDAQ(double valueToWrite) { }
    }
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

    public class DAQReader : DAQBase, IDataReader
    {
        private AnalogSingleChannelReader _reader;
        public DAQReader(string channelName, double voltageMinValue, double voltageMaxValue) : base()
        {
            _task.AIChannels.CreateVoltageChannel(
                channelName,
                null,
                AITerminalConfiguration.Differential,
                voltageMinValue,
                voltageMaxValue,
                AIVoltageUnits.Volts);
            _reader = new AnalogSingleChannelReader(_task.Stream);
        }

        public double ReadFromDAQ() => _reader.ReadSingleSample();

        public class DAQWriter : DAQBase, IDataWriter
        {
            private AnalogSingleChannelWriter _writer;
            public DAQWriter(string channelName, double voltageMinValue, double voltageMaxValue) : base()
            {
                _task.AOChannels.CreateVoltageChannel(
                    channelName,
                    null,
                    voltageMinValue,
                    voltageMaxValue,
                    AOVoltageUnits.Volts);
                _writer = new AnalogSingleChannelWriter(_task.Stream);
            }

            public void WriteToDAQ(double valueToWrite) => _writer.WriteSingleSample(true, valueToWrite);
        }
    }
}
