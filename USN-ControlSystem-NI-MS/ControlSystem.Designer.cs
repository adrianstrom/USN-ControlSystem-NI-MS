
namespace USN_ControlSystem_NI_MS
{
    partial class ControlSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblControlSignalRampChange = new System.Windows.Forms.Label();
            this.neControlSignal = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblControlSignal = new System.Windows.Forms.Label();
            this.sliderControlSignal = new NationalInstruments.UI.WindowsForms.Slide();
            this.txtError = new System.Windows.Forms.TextBox();
            this.wfgControlSignal = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.pltControlSignal = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yControlSignal = new NationalInstruments.UI.YAxis();
            this.lblError = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.sliderSetpoint = new NationalInstruments.UI.WindowsForms.Slide();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.wfgTemperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.pltTemperature = new NationalInstruments.UI.WaveformPlot();
            this.xAxisTime = new NationalInstruments.UI.XAxis();
            this.yAxisTemperature = new NationalInstruments.UI.YAxis();
            this.pltSetPoint = new NationalInstruments.UI.WaveformPlot();
            this.pltTemperatureOutlet = new NationalInstruments.UI.WaveformPlot();
            this.lblSetPoint = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tcView = new System.Windows.Forms.TabControl();
            this.ControllerParameters = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.switchAntiWindup = new NationalInstruments.UI.WindowsForms.Switch();
            this.neOutputMax = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neOutputMin = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblOutputMax = new System.Windows.Forms.Label();
            this.lblOutputMinimum = new System.Windows.Forms.Label();
            this.lblModeManual = new System.Windows.Forms.Label();
            this.lblModeAuto = new System.Windows.Forms.Label();
            this.switchMode = new NationalInstruments.UI.WindowsForms.Switch();
            this.neTd = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neTi = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neGain = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblTi = new System.Windows.Forms.Label();
            this.lblKp = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimeDelay = new System.Windows.Forms.Label();
            this.lblKh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericEdit4 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neKh = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neTimeDelay = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neTemperautureEnvironment = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neControlSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControlSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgControlSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).BeginInit();
            this.tcView.SuspendLayout();
            this.ControllerParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchAntiWindup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTimeDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTemperautureEnvironment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1202, 800);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblControlSignalRampChange);
            this.tabPage1.Controls.Add(this.neControlSignal);
            this.tabPage1.Controls.Add(this.lblControlSignal);
            this.tabPage1.Controls.Add(this.sliderControlSignal);
            this.tabPage1.Controls.Add(this.txtError);
            this.tabPage1.Controls.Add(this.wfgControlSignal);
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.lblControl);
            this.tabPage1.Controls.Add(this.sliderSetpoint);
            this.tabPage1.Controls.Add(this.txtControl);
            this.tabPage1.Controls.Add(this.txtTemperature);
            this.tabPage1.Controls.Add(this.wfgTemperature);
            this.tabPage1.Controls.Add(this.lblSetPoint);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.lblTemperature);
            this.tabPage1.Controls.Add(this.tcView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PI regulator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblControlSignalRampChange
            // 
            this.lblControlSignalRampChange.AutoSize = true;
            this.lblControlSignalRampChange.Location = new System.Drawing.Point(498, 744);
            this.lblControlSignalRampChange.Name = "lblControlSignalRampChange";
            this.lblControlSignalRampChange.Size = new System.Drawing.Size(91, 13);
            this.lblControlSignalRampChange.TabIndex = 16;
            this.lblControlSignalRampChange.Text = "Ramp Change [V]";
            // 
            // neControlSignal
            // 
            this.neControlSignal.Location = new System.Drawing.Point(595, 744);
            this.neControlSignal.Name = "neControlSignal";
            this.neControlSignal.Size = new System.Drawing.Size(120, 20);
            this.neControlSignal.TabIndex = 15;
            this.neControlSignal.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neControlSignal_AfterChangeValue);
            // 
            // lblControlSignal
            // 
            this.lblControlSignal.AutoSize = true;
            this.lblControlSignal.Location = new System.Drawing.Point(424, 399);
            this.lblControlSignal.Name = "lblControlSignal";
            this.lblControlSignal.Size = new System.Drawing.Size(88, 13);
            this.lblControlSignal.TabIndex = 14;
            this.lblControlSignal.Text = "Control Signal [V]";
            // 
            // sliderControlSignal
            // 
            this.sliderControlSignal.FillColor = System.Drawing.SystemColors.Highlight;
            this.sliderControlSignal.Location = new System.Drawing.Point(436, 422);
            this.sliderControlSignal.Name = "sliderControlSignal";
            this.sliderControlSignal.Range = new NationalInstruments.UI.Range(0D, 5D);
            this.sliderControlSignal.Size = new System.Drawing.Size(54, 309);
            this.sliderControlSignal.TabIndex = 13;
            this.sliderControlSignal.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.sliderControlSignal_AfterChangeValue);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(982, 20);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 3;
            // 
            // wfgControlSignal
            // 
            this.wfgControlSignal.Location = new System.Drawing.Point(501, 422);
            this.wfgControlSignal.Name = "wfgControlSignal";
            this.wfgControlSignal.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.pltControlSignal});
            this.wfgControlSignal.Size = new System.Drawing.Size(581, 309);
            this.wfgControlSignal.TabIndex = 12;
            this.wfgControlSignal.UseColorGenerator = true;
            this.wfgControlSignal.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.wfgControlSignal.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yControlSignal});
            // 
            // pltControlSignal
            // 
            this.pltControlSignal.XAxis = this.xAxis1;
            this.pltControlSignal.YAxis = this.yControlSignal;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time [s]";
            // 
            // yControlSignal
            // 
            this.yControlSignal.Caption = "Control Signal [%]";
            this.yControlSignal.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yControlSignal.Range = new NationalInstruments.UI.Range(0D, 100D);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(894, 23);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(85, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Control Error [°C]";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(893, 395);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(86, 13);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Control signal [V]";
            // 
            // sliderSetpoint
            // 
            this.sliderSetpoint.FillColor = System.Drawing.SystemColors.Highlight;
            this.sliderSetpoint.Location = new System.Drawing.Point(427, 45);
            this.sliderSetpoint.Name = "sliderSetpoint";
            this.sliderSetpoint.Range = new NationalInstruments.UI.Range(0D, 60D);
            this.sliderSetpoint.Size = new System.Drawing.Size(54, 309);
            this.sliderSetpoint.TabIndex = 11;
            this.sliderSetpoint.Value = 25D;
            this.sliderSetpoint.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.sliderSetpoint_AfterChangeValue);
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(981, 392);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(100, 20);
            this.txtControl.TabIndex = 4;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(769, 20);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 2;
            // 
            // wfgTemperature
            // 
            this.wfgTemperature.Location = new System.Drawing.Point(501, 45);
            this.wfgTemperature.Name = "wfgTemperature";
            this.wfgTemperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.pltTemperature,
            this.pltSetPoint,
            this.pltTemperatureOutlet});
            this.wfgTemperature.Size = new System.Drawing.Size(581, 309);
            this.wfgTemperature.TabIndex = 0;
            this.wfgTemperature.UseColorGenerator = true;
            this.wfgTemperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxisTime});
            this.wfgTemperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxisTemperature});
            // 
            // pltTemperature
            // 
            this.pltTemperature.LineColor = System.Drawing.Color.Yellow;
            this.pltTemperature.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.pltTemperature.XAxis = this.xAxisTime;
            this.pltTemperature.YAxis = this.yAxisTemperature;
            // 
            // xAxisTime
            // 
            this.xAxisTime.Caption = "Time [s]";
            // 
            // yAxisTemperature
            // 
            this.yAxisTemperature.Caption = "Temperature [°C]";
            this.yAxisTemperature.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxisTemperature.Range = new NationalInstruments.UI.Range(0D, 60D);
            // 
            // pltSetPoint
            // 
            this.pltSetPoint.LineColor = System.Drawing.Color.LimeGreen;
            this.pltSetPoint.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.pltSetPoint.XAxis = this.xAxisTime;
            this.pltSetPoint.YAxis = this.yAxisTemperature;
            // 
            // pltTemperatureOutlet
            // 
            this.pltTemperatureOutlet.LineColor = System.Drawing.Color.MediumVioletRed;
            this.pltTemperatureOutlet.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.pltTemperatureOutlet.XAxis = this.xAxisTime;
            this.pltTemperatureOutlet.YAxis = this.yAxisTemperature;
            // 
            // lblSetPoint
            // 
            this.lblSetPoint.AutoSize = true;
            this.lblSetPoint.Location = new System.Drawing.Point(424, 29);
            this.lblSetPoint.Name = "lblSetPoint";
            this.lblSetPoint.Size = new System.Drawing.Size(66, 13);
            this.lblSetPoint.TabIndex = 5;
            this.lblSetPoint.Text = "Setpoint [°C]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1094, 699);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 51);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "ttttt";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(678, 23);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(87, 13);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature [°C]";
            // 
            // tcView
            // 
            this.tcView.Controls.Add(this.ControllerParameters);
            this.tcView.Controls.Add(this.tabPage4);
            this.tcView.Controls.Add(this.tabPage3);
            this.tcView.Location = new System.Drawing.Point(21, 23);
            this.tcView.Name = "tcView";
            this.tcView.SelectedIndex = 0;
            this.tcView.Size = new System.Drawing.Size(375, 331);
            this.tcView.TabIndex = 9;
            // 
            // ControllerParameters
            // 
            this.ControllerParameters.BackColor = System.Drawing.Color.LightGray;
            this.ControllerParameters.Controls.Add(this.label6);
            this.ControllerParameters.Controls.Add(this.label5);
            this.ControllerParameters.Controls.Add(this.switchAntiWindup);
            this.ControllerParameters.Controls.Add(this.neOutputMax);
            this.ControllerParameters.Controls.Add(this.neOutputMin);
            this.ControllerParameters.Controls.Add(this.lblOutputMax);
            this.ControllerParameters.Controls.Add(this.lblOutputMinimum);
            this.ControllerParameters.Controls.Add(this.lblModeManual);
            this.ControllerParameters.Controls.Add(this.lblModeAuto);
            this.ControllerParameters.Controls.Add(this.switchMode);
            this.ControllerParameters.Controls.Add(this.neTd);
            this.ControllerParameters.Controls.Add(this.neTi);
            this.ControllerParameters.Controls.Add(this.neGain);
            this.ControllerParameters.Controls.Add(this.lblTd);
            this.ControllerParameters.Controls.Add(this.lblTi);
            this.ControllerParameters.Controls.Add(this.lblKp);
            this.ControllerParameters.Location = new System.Drawing.Point(4, 22);
            this.ControllerParameters.Name = "ControllerParameters";
            this.ControllerParameters.Padding = new System.Windows.Forms.Padding(3);
            this.ControllerParameters.Size = new System.Drawing.Size(367, 305);
            this.ControllerParameters.TabIndex = 1;
            this.ControllerParameters.Text = "Controller Parameters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "No anti windup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Anti windup";
            // 
            // switchAntiWindup
            // 
            this.switchAntiWindup.Location = new System.Drawing.Point(140, 194);
            this.switchAntiWindup.Name = "switchAntiWindup";
            this.switchAntiWindup.Size = new System.Drawing.Size(64, 96);
            this.switchAntiWindup.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchAntiWindup.TabIndex = 16;
            // 
            // neOutputMax
            // 
            this.neOutputMax.Location = new System.Drawing.Point(140, 150);
            this.neOutputMax.Name = "neOutputMax";
            this.neOutputMax.Size = new System.Drawing.Size(120, 20);
            this.neOutputMax.TabIndex = 15;
            // 
            // neOutputMin
            // 
            this.neOutputMin.Location = new System.Drawing.Point(140, 120);
            this.neOutputMin.Name = "neOutputMin";
            this.neOutputMin.Size = new System.Drawing.Size(120, 20);
            this.neOutputMin.TabIndex = 14;
            // 
            // lblOutputMax
            // 
            this.lblOutputMax.AutoSize = true;
            this.lblOutputMax.Location = new System.Drawing.Point(18, 150);
            this.lblOutputMax.Name = "lblOutputMax";
            this.lblOutputMax.Size = new System.Drawing.Size(101, 13);
            this.lblOutputMax.TabIndex = 13;
            this.lblOutputMax.Text = "Output maximum [V]";
            // 
            // lblOutputMinimum
            // 
            this.lblOutputMinimum.AutoSize = true;
            this.lblOutputMinimum.Location = new System.Drawing.Point(18, 120);
            this.lblOutputMinimum.Name = "lblOutputMinimum";
            this.lblOutputMinimum.Size = new System.Drawing.Size(98, 13);
            this.lblOutputMinimum.TabIndex = 12;
            this.lblOutputMinimum.Text = "Output minimum [V]";
            // 
            // lblModeManual
            // 
            this.lblModeManual.AutoSize = true;
            this.lblModeManual.Location = new System.Drawing.Point(32, 278);
            this.lblModeManual.Name = "lblModeManual";
            this.lblModeManual.Size = new System.Drawing.Size(42, 13);
            this.lblModeManual.TabIndex = 8;
            this.lblModeManual.Text = "Manual";
            // 
            // lblModeAuto
            // 
            this.lblModeAuto.AutoSize = true;
            this.lblModeAuto.Location = new System.Drawing.Point(38, 194);
            this.lblModeAuto.Name = "lblModeAuto";
            this.lblModeAuto.Size = new System.Drawing.Size(29, 13);
            this.lblModeAuto.TabIndex = 7;
            this.lblModeAuto.Text = "Auto";
            // 
            // switchMode
            // 
            this.switchMode.Location = new System.Drawing.Point(21, 194);
            this.switchMode.Name = "switchMode";
            this.switchMode.Size = new System.Drawing.Size(64, 96);
            this.switchMode.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchMode.TabIndex = 6;
            this.switchMode.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switchMode_StateChanged);
            // 
            // neTd
            // 
            this.neTd.Location = new System.Drawing.Point(140, 90);
            this.neTd.Name = "neTd";
            this.neTd.Size = new System.Drawing.Size(120, 20);
            this.neTd.TabIndex = 5;
            this.neTd.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neTd_AfterChangeValue);
            // 
            // neTi
            // 
            this.neTi.Location = new System.Drawing.Point(140, 60);
            this.neTi.Name = "neTi";
            this.neTi.Size = new System.Drawing.Size(120, 20);
            this.neTi.TabIndex = 4;
            this.neTi.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neTi_AfterChangeValue);
            // 
            // neGain
            // 
            this.neGain.Location = new System.Drawing.Point(140, 30);
            this.neGain.Name = "neGain";
            this.neGain.Size = new System.Drawing.Size(120, 20);
            this.neGain.TabIndex = 3;
            this.neGain.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neGain_AfterChangeValue);
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.Location = new System.Drawing.Point(18, 90);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(95, 13);
            this.lblTd.TabIndex = 2;
            this.lblTd.Text = "Derivative Time [s]";
            // 
            // lblTi
            // 
            this.lblTi.AutoSize = true;
            this.lblTi.Location = new System.Drawing.Point(18, 60);
            this.lblTi.Name = "lblTi";
            this.lblTi.Size = new System.Drawing.Size(82, 13);
            this.lblTi.TabIndex = 1;
            this.lblTi.Text = "Integral Time [s]";
            // 
            // lblKp
            // 
            this.lblKp.AutoSize = true;
            this.lblKp.Location = new System.Drawing.Point(18, 30);
            this.lblKp.Name = "lblKp";
            this.lblKp.Size = new System.Drawing.Size(29, 13);
            this.lblKp.TabIndex = 0;
            this.lblKp.Text = "Gain";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.lblTimeDelay);
            this.tabPage4.Controls.Add(this.lblKh);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.numericEdit4);
            this.tabPage4.Controls.Add(this.neKh);
            this.tabPage4.Controls.Add(this.neTimeDelay);
            this.tabPage4.Controls.Add(this.neTemperautureEnvironment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(367, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Model Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // lblTimeDelay
            // 
            this.lblTimeDelay.AutoSize = true;
            this.lblTimeDelay.Location = new System.Drawing.Point(18, 90);
            this.lblTimeDelay.Name = "lblTimeDelay";
            this.lblTimeDelay.Size = new System.Drawing.Size(74, 13);
            this.lblTimeDelay.TabIndex = 6;
            this.lblTimeDelay.Text = "Time Delay [s]";
            // 
            // lblKh
            // 
            this.lblKh.AutoSize = true;
            this.lblKh.Location = new System.Drawing.Point(18, 60);
            this.lblKh.Name = "lblKh";
            this.lblKh.Size = new System.Drawing.Size(48, 13);
            this.lblKh.TabIndex = 5;
            this.lblKh.Text = "Kh [C/V]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temp. env. [°C]";
            // 
            // numericEdit4
            // 
            this.numericEdit4.Location = new System.Drawing.Point(140, 120);
            this.numericEdit4.Name = "numericEdit4";
            this.numericEdit4.Size = new System.Drawing.Size(120, 20);
            this.numericEdit4.TabIndex = 3;
            // 
            // neKh
            // 
            this.neKh.Location = new System.Drawing.Point(140, 60);
            this.neKh.Name = "neKh";
            this.neKh.Size = new System.Drawing.Size(120, 20);
            this.neKh.TabIndex = 2;
            this.neKh.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neKh_AfterChangeValue);
            // 
            // neTimeDelay
            // 
            this.neTimeDelay.Location = new System.Drawing.Point(140, 90);
            this.neTimeDelay.Name = "neTimeDelay";
            this.neTimeDelay.Size = new System.Drawing.Size(120, 20);
            this.neTimeDelay.TabIndex = 1;
            this.neTimeDelay.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neTimeDelay_AfterChangeValue);
            // 
            // neTemperautureEnvironment
            // 
            this.neTemperautureEnvironment.Location = new System.Drawing.Point(140, 30);
            this.neTemperautureEnvironment.Name = "neTemperautureEnvironment";
            this.neTemperautureEnvironment.Size = new System.Drawing.Size(120, 20);
            this.neTemperautureEnvironment.TabIndex = 0;
            this.neTemperautureEnvironment.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.neTemperautureEnvironment_AfterChangeValue);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(367, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filter";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital twin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 814);
            this.Controls.Add(this.tabControl1);
            this.Name = "ControlSystem";
            this.Text = "Control System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neControlSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControlSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgControlSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).EndInit();
            this.tcView.ResumeLayout(false);
            this.ControllerParameters.ResumeLayout(false);
            this.ControllerParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchAntiWindup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTimeDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTemperautureEnvironment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblControlSignal;
        private NationalInstruments.UI.WindowsForms.Slide sliderControlSignal;
        private System.Windows.Forms.TextBox txtError;
        private NationalInstruments.UI.WindowsForms.WaveformGraph wfgControlSignal;
        private NationalInstruments.UI.WaveformPlot pltControlSignal;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yControlSignal;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblControl;
        private NationalInstruments.UI.WindowsForms.Slide sliderSetpoint;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.TextBox txtTemperature;
        private NationalInstruments.UI.WindowsForms.WaveformGraph wfgTemperature;
        private NationalInstruments.UI.WaveformPlot pltTemperature;
        private NationalInstruments.UI.XAxis xAxisTime;
        private NationalInstruments.UI.YAxis yAxisTemperature;
        private System.Windows.Forms.Label lblSetPoint;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TabControl tcView;
        private System.Windows.Forms.TabPage ControllerParameters;
        private NationalInstruments.UI.WindowsForms.NumericEdit neOutputMax;
        private NationalInstruments.UI.WindowsForms.NumericEdit neOutputMin;
        private System.Windows.Forms.Label lblOutputMax;
        private System.Windows.Forms.Label lblOutputMinimum;
        private System.Windows.Forms.Label lblModeManual;
        private System.Windows.Forms.Label lblModeAuto;
        private NationalInstruments.UI.WindowsForms.Switch switchMode;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTd;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTi;
        private NationalInstruments.UI.WindowsForms.NumericEdit neGain;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblTi;
        private System.Windows.Forms.Label lblKp;
        private System.Windows.Forms.TabPage tabPage4;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit4;
        private NationalInstruments.UI.WindowsForms.NumericEdit neKh;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTimeDelay;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTemperautureEnvironment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimeDelay;
        private System.Windows.Forms.Label lblKh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.Switch switchAntiWindup;
        private NationalInstruments.UI.WaveformPlot pltSetPoint;
        private NationalInstruments.UI.WaveformPlot pltTemperatureOutlet;
        private NationalInstruments.UI.WindowsForms.NumericEdit neControlSignal;
        private System.Windows.Forms.Label lblControlSignalRampChange;
    }
}

