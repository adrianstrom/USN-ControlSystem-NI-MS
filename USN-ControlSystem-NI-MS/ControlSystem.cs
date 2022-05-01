using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using USN_ControlSystem_NI_MS.Controllers;
using static USN_ControlSystem_NI_MS.Controllers.DAQReader;

namespace USN_ControlSystem_NI_MS
{
    public partial class ControlSystem : Form
    {
        private PIDController _pidController;

        public ControlSystem()
        {
            InitializeComponent();
            _pidController = new PIDController(0.5, 10, 0);
            _pidController.TimeStep = 1;
            _pidController.SetPoint = 20;
            txtSetPoint.Text = _pidController.SetPoint.ToString();
            var temperatureDaqHandler = new DAQReader("Dev2/ai0", 1, 5);
            var controlDaqHandler = new DAQWriter("Dev2/ao1", 0, 5);
            txtControl.Enabled = false;
            txtTemperature.Enabled = false;

            Task.Run(async () => await ControlAirHeater(_pidController, temperatureDaqHandler, controlDaqHandler));
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

        public async Task ControlAirHeater(PIDController pidControl, DAQReader daqReader, DAQWriter daqWriter)
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

                    wfgTemperature.PlotYAppend(temperature);

                    //Update process variable in PID control.
                    pidControl.ProcessVariable = temperature;

                    // Write control signal to heater.
                    var u = pidControl.GetControlSignal();
                    AppendControlTextBox(String.Format("{0:0.00}", u));
                    daqWriter.WriteToDAQ(1);

                    await Task.Delay(1000);
                }
            }
            catch (NationalInstruments.DAQmx.DaqException e)
            {
                AppendStatusTextBox("Restart required.");
                System.Windows.Forms.MessageBox.Show($"Error controlling air heater. {e.Message}");
            }
        }

        private void btnSetSetpoint_Click(object sender, EventArgs e)
        {
            double.TryParse(txtSetPoint.Text, out var setPoint);
            _pidController.SetPoint = setPoint;
        }
    }
}