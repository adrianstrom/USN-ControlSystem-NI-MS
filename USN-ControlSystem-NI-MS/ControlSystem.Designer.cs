
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
            this.wfgTemperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxisTime = new NationalInstruments.UI.XAxis();
            this.yAxisTemperature = new NationalInstruments.UI.YAxis();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.lblSetPoint = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.tcView = new System.Windows.Forms.TabControl();
            this.ControllerParameters = new System.Windows.Forms.TabPage();
            this.neOutputMax = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neOutputMin = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblOutputMax = new System.Windows.Forms.Label();
            this.lblOutputMinimum = new System.Windows.Forms.Label();
            this.switchAntiWindup = new NationalInstruments.UI.WindowsForms.Switch();
            this.lblAntiWindup = new System.Windows.Forms.Label();
            this.lblNoAntiWindup = new System.Windows.Forms.Label();
            this.lblModeManual = new System.Windows.Forms.Label();
            this.lblModeAuto = new System.Windows.Forms.Label();
            this.switchMode = new NationalInstruments.UI.WindowsForms.Switch();
            this.neTd = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neTi = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neGain = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblTi = new System.Windows.Forms.Label();
            this.lblKp = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.sliderSetpoint = new NationalInstruments.UI.WindowsForms.Slide();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sliderControlSignal = new NationalInstruments.UI.WindowsForms.Slide();
            this.lblControlSignal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).BeginInit();
            this.tcView.SuspendLayout();
            this.ControllerParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAntiWindup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControlSignal)).BeginInit();
            this.SuspendLayout();
            // 
            // wfgTemperature
            // 
            this.wfgTemperature.Location = new System.Drawing.Point(501, 45);
            this.wfgTemperature.Name = "wfgTemperature";
            this.wfgTemperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.wfgTemperature.Size = new System.Drawing.Size(581, 309);
            this.wfgTemperature.TabIndex = 0;
            this.wfgTemperature.UseColorGenerator = true;
            this.wfgTemperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxisTime});
            this.wfgTemperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxisTemperature});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxisTime;
            this.waveformPlot1.YAxis = this.yAxisTemperature;
            // 
            // xAxisTime
            // 
            this.xAxisTime.Caption = "Time [s]";
            // 
            // yAxisTemperature
            // 
            this.yAxisTemperature.Caption = "Temperature [°C]";
            this.yAxisTemperature.Range = new NationalInstruments.UI.Range(0D, 100D);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(769, 20);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 2;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(982, 20);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 3;
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(981, 392);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(100, 20);
            this.txtControl.TabIndex = 4;
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
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(678, 23);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(87, 13);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature [°C]";
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
            // tcView
            // 
            this.tcView.Controls.Add(this.ControllerParameters);
            this.tcView.Controls.Add(this.tabPage3);
            this.tcView.Location = new System.Drawing.Point(21, 23);
            this.tcView.Name = "tcView";
            this.tcView.SelectedIndex = 0;
            this.tcView.Size = new System.Drawing.Size(375, 331);
            this.tcView.TabIndex = 9;
            // 
            // ControllerParameters
            // 
            this.ControllerParameters.Controls.Add(this.neOutputMax);
            this.ControllerParameters.Controls.Add(this.neOutputMin);
            this.ControllerParameters.Controls.Add(this.lblOutputMax);
            this.ControllerParameters.Controls.Add(this.lblOutputMinimum);
            this.ControllerParameters.Controls.Add(this.switchAntiWindup);
            this.ControllerParameters.Controls.Add(this.lblAntiWindup);
            this.ControllerParameters.Controls.Add(this.lblNoAntiWindup);
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
            this.ControllerParameters.UseVisualStyleBackColor = true;
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
            // switchAntiWindup
            // 
            this.switchAntiWindup.Location = new System.Drawing.Point(140, 194);
            this.switchAntiWindup.Name = "switchAntiWindup";
            this.switchAntiWindup.Size = new System.Drawing.Size(64, 96);
            this.switchAntiWindup.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchAntiWindup.TabIndex = 11;
            // 
            // lblAntiWindup
            // 
            this.lblAntiWindup.AutoSize = true;
            this.lblAntiWindup.Location = new System.Drawing.Point(143, 194);
            this.lblAntiWindup.Name = "lblAntiWindup";
            this.lblAntiWindup.Size = new System.Drawing.Size(62, 13);
            this.lblAntiWindup.TabIndex = 10;
            this.lblAntiWindup.Text = "Anti windup";
            // 
            // lblNoAntiWindup
            // 
            this.lblNoAntiWindup.AutoSize = true;
            this.lblNoAntiWindup.Location = new System.Drawing.Point(137, 278);
            this.lblNoAntiWindup.Name = "lblNoAntiWindup";
            this.lblNoAntiWindup.Size = new System.Drawing.Size(78, 13);
            this.lblNoAntiWindup.TabIndex = 9;
            this.lblNoAntiWindup.Text = "No anti windup";
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
            // 
            // neTd
            // 
            this.neTd.Location = new System.Drawing.Point(140, 90);
            this.neTd.Name = "neTd";
            this.neTd.Size = new System.Drawing.Size(120, 20);
            this.neTd.TabIndex = 5;
            // 
            // neTi
            // 
            this.neTi.Location = new System.Drawing.Point(140, 60);
            this.neTi.Name = "neTi";
            this.neTi.Size = new System.Drawing.Size(120, 20);
            this.neTi.TabIndex = 4;
            // 
            // neGain
            // 
            this.neGain.Location = new System.Drawing.Point(140, 30);
            this.neGain.Name = "neGain";
            this.neGain.Size = new System.Drawing.Size(120, 20);
            this.neGain.TabIndex = 3;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1202, 779);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblControlSignal);
            this.tabPage1.Controls.Add(this.sliderControlSignal);
            this.tabPage1.Controls.Add(this.txtError);
            this.tabPage1.Controls.Add(this.waveformGraph1);
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
            this.tabPage1.Size = new System.Drawing.Size(1194, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PI regulator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(501, 422);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph1.Size = new System.Drawing.Size(581, 309);
            this.waveformGraph1.TabIndex = 12;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis1;
            this.waveformPlot2.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time [s]";
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Control Signal [%]";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital twin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(367, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sliderControlSignal
            // 
            this.sliderControlSignal.FillColor = System.Drawing.SystemColors.Highlight;
            this.sliderControlSignal.Location = new System.Drawing.Point(427, 422);
            this.sliderControlSignal.Name = "sliderControlSignal";
            this.sliderControlSignal.Range = new NationalInstruments.UI.Range(0D, 5D);
            this.sliderControlSignal.Size = new System.Drawing.Size(54, 309);
            this.sliderControlSignal.TabIndex = 13;
            // 
            // lblControlSignal
            // 
            this.lblControlSignal.AutoSize = true;
            this.lblControlSignal.Location = new System.Drawing.Point(424, 406);
            this.lblControlSignal.Name = "lblControlSignal";
            this.lblControlSignal.Size = new System.Drawing.Size(88, 13);
            this.lblControlSignal.TabIndex = 14;
            this.lblControlSignal.Text = "Control Signal [V]";
            // 
            // ControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 793);
            this.Controls.Add(this.tabControl1);
            this.Name = "ControlSystem";
            this.Text = "Control System";
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).EndInit();
            this.tcView.ResumeLayout(false);
            this.ControllerParameters.ResumeLayout(false);
            this.ControllerParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neOutputMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAntiWindup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderControlSignal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph wfgTemperature;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxisTime;
        private NationalInstruments.UI.YAxis yAxisTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label lblSetPoint;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.TabControl tcView;
        private System.Windows.Forms.TabPage ControllerParameters;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblTi;
        private System.Windows.Forms.Label lblKp;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTd;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTi;
        private NationalInstruments.UI.WindowsForms.NumericEdit neGain;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private NationalInstruments.UI.WindowsForms.Slide sliderSetpoint;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label lblModeAuto;
        private NationalInstruments.UI.WindowsForms.Switch switchMode;
        private System.Windows.Forms.Label lblModeManual;
        private System.Windows.Forms.Label lblAntiWindup;
        private System.Windows.Forms.Label lblNoAntiWindup;
        private NationalInstruments.UI.WindowsForms.Switch switchAntiWindup;
        private System.Windows.Forms.Label lblOutputMinimum;
        private System.Windows.Forms.Label lblOutputMax;
        private NationalInstruments.UI.WindowsForms.NumericEdit neOutputMax;
        private NationalInstruments.UI.WindowsForms.NumericEdit neOutputMin;
        private System.Windows.Forms.TabPage tabPage3;
        private NationalInstruments.UI.WindowsForms.Slide sliderControlSignal;
        private System.Windows.Forms.Label lblControlSignal;
    }
}

