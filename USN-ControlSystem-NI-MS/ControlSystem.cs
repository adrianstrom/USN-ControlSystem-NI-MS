using Opc.UaFx.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using USN_ControlSystem_NI_MS.Controllers;

namespace USN_ControlSystem_NI_MS
{
    public partial class ControlSystem : Form
    {
        private PIDController _pidController;
        private OpcClient _opcClient;
        private AirHeaterModel _airHeaterModel;

        public ControlSystem()
        {
            InitializeComponent();
            InitializePID();
            InitializeAirHeaterModel();
            InitializeControls();

            //var temperatureDaqHandler = new DAQReader("Dev2/ai0", 1, 5);
            //var controlDaqHandler = new DAQWriter("Dev2/ao1", 0, 5);
            var temperatureDaqHandler = new TemperatureReader();
            var controlDaqHandler = new ControlSignalWriter();


            InitializeOPC();
            Task.Run(async () => await ControlAirHeater(_pidController, temperatureDaqHandler, controlDaqHandler));
        }

        private void InitializeControls()
        {
            txtControl.Enabled = false;
            txtTemperature.Enabled = false;

            neGain.Value = _pidController.Kp;
            neTi.Value = _pidController.Ti;
            neTd.Value = _pidController.Td;
            neOutputMin.Value = _pidController.OutputMinimum;
            neOutputMax.Value = _pidController.OutputMaximum;

            switchMode.Value = _pidController.Manual;
            switchAntiWindup.Value = _pidController.AntiWindup;

            neControlSignal.Value = _airHeaterModel.ControlSignal;
            sliderControlSignal.Value = _airHeaterModel.ControlSignal;

            neTemperautureEnvironment.Value = _airHeaterModel.TemperatureEnvironment;
            neKh.Value = _airHeaterModel.HeaterGain;
        }

        private void InitializeOPC()
        {
            _opcClient = new OpcClient("opc.tcp://localhost:4840/");
            _opcClient.Security.UserIdentity =
                new OpcClientIdentity("usn_system_user", "usn.password!");
            _opcClient.SessionName = "Control System application";
            _opcClient.Connect();
        }

        private void InitializeAirHeaterModel()
        {
            _airHeaterModel = new AirHeaterModel(25);
            _airHeaterModel.TimeStep = TimeSpan.FromSeconds(_pidController.TimeStep);
        }

        public async Task ControlAirHeater(PIDController pidControl = null, IDataReader daqReader = null, IDataWriter daqWriter = null)
        {
            try
            {
                while (true)
                {
                    // Read temperature.
                    var voltage = daqReader.ReadFromDAQ();
                    var temperature = VoltageConverter.Temperature1Converter(voltage);

                    // Write values to textboxes.
                    AppendTemperatureTextBox(String.Format("{0:0.00}", temperature));
                    AppendErrorTextBox(String.Format("{0:0.00}", pidControl.Error));

                    pltTemperature.PlotYAppend(temperature);
                    pltSetPoint.PlotYAppend(sliderSetpoint.Value);
                    pltTemperatureOutlet.PlotYAppend(_airHeaterModel.CalculateOutput());

                    // Update process variable in PID control.
                    pidControl.ProcessVariable = temperature;

                    // Write control signal to heater and plot.
                    var u = pidControl.GetControlSignal();
                    pltControlSignal.PlotYAppend(20 * u); // scale to percentage
                    AppendControlTextBox(String.Format("{0:0.00}", u));
                    daqWriter.WriteToDAQ(u);

                    // Write values to OPC UA Server.
                    _opcClient.WriteNode("ns=2;s=MeasurementSites/USN/Temperature", temperature);
                    _opcClient.WriteNode("ns=2;s=MeasurementSites/USN/ControlSignal", u);

                    await Task.Delay(1000);
                }
            }
            catch (NationalInstruments.DAQmx.DaqException e)
            {
                AppendStatusTextBox("DAQ error.");
                MessageBox.Show($"Error controlling air heater. {e.Message}");
            }
            catch (Opc.UaFx.OpcException e)
            {
                AppendStatusTextBox("OPC error.");
                MessageBox.Show($"OPC operation failed. {e.Message}");
            }
        }

        public void InitializePID()
        {
            _pidController = new PIDController(0.5, 10, 0);
            _pidController.TimeStep = 1;
            _pidController.SetPoint = 20;
        }

        public void AppendTemperatureTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTemperatureTextBox), new object[] { value });
                return;
            }
            txtTemperature.Text = value;
        }

        public void AppendControlTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendControlTextBox), new object[] { value });
                return;
            }
            txtControl.Text = value;
        }

        public void AppendErrorTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendErrorTextBox), new object[] { value });
                return;
            }
            txtError.Text = value;
        }

        public void AppendStatusTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendStatusTextBox), new object[] { value });
                return;
            }
            lblStatus.Text = value;
        }

        private void sliderSetpoint_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_pidController == null)
            {
                return;
            }
            _pidController.SetPoint = e.NewValue;
        }

        private void switchMode_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            if (switchMode.Value == true)
            {
                sliderControlSignal.Enabled = false;
                neControlSignal.Enabled = false;
            }
            else
            {
                sliderControlSignal.Enabled = true;
                neControlSignal.Enabled = true;
            }
        }

        private void neGain_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_pidController != null)
            {
                _pidController.Kp = e.NewValue;
            }
        }

        private void neTi_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_pidController != null)
            {
                _pidController.Ti = e.NewValue;
            }
        }

        private void neTd_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_pidController != null)
            {
                _pidController.Td = e.NewValue;
            }
        }

        private void neControlSignal_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_airHeaterModel != null)
            {
                _airHeaterModel.ControlSignal = e.NewValue;
                sliderControlSignal.Value = e.NewValue;
            }
        }

        private void sliderControlSignal_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_airHeaterModel != null)
            {
                _airHeaterModel.ControlSignal = e.NewValue;
                neControlSignal.Value = e.NewValue;
            }
        }

        private void neTemperautureEnvironment_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_airHeaterModel != null)
            {
                _airHeaterModel.TemperatureEnvironment = e.NewValue;
            }
        }

        private void neKh_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_airHeaterModel != null)
            {
                _airHeaterModel.HeaterGain = e.NewValue;
            }
        }

        private void neTimeDelay_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (_airHeaterModel != null)
            {
                _airHeaterModel.TimeDelay = TimeSpan.FromSeconds(e.NewValue);
            }
        }
    }
}