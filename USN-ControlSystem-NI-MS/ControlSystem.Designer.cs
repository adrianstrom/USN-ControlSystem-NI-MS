
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
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.txtSetPoint = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.lblSetPoint = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.tcView = new System.Windows.Forms.TabControl();
            this.Values = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.btnSetSetpoint = new System.Windows.Forms.Button();
            this.neTd = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neTi = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neGain = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblTi = new System.Windows.Forms.Label();
            this.lblKp = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).BeginInit();
            this.tcView.SuspendLayout();
            this.Values.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).BeginInit();
            this.SuspendLayout();
            // 
            // wfgTemperature
            // 
            this.wfgTemperature.Location = new System.Drawing.Point(405, 34);
            this.wfgTemperature.Name = "wfgTemperature";
            this.wfgTemperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.wfgTemperature.Size = new System.Drawing.Size(581, 309);
            this.wfgTemperature.TabIndex = 0;
            this.wfgTemperature.UseColorGenerator = true;
            this.wfgTemperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.wfgTemperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // txtSetPoint
            // 
            this.txtSetPoint.Location = new System.Drawing.Point(141, 135);
            this.txtSetPoint.Name = "txtSetPoint";
            this.txtSetPoint.Size = new System.Drawing.Size(100, 20);
            this.txtSetPoint.TabIndex = 1;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(137, 20);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 2;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(137, 58);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 3;
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(137, 92);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(100, 20);
            this.txtControl.TabIndex = 4;
            // 
            // lblSetPoint
            // 
            this.lblSetPoint.AutoSize = true;
            this.lblSetPoint.Location = new System.Drawing.Point(18, 135);
            this.lblSetPoint.Name = "lblSetPoint";
            this.lblSetPoint.Size = new System.Drawing.Size(46, 13);
            this.lblSetPoint.TabIndex = 5;
            this.lblSetPoint.Text = "Setpoint";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(46, 23);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(87, 13);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature [°C]";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(49, 61);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Error [°C]";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(49, 95);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(86, 13);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Control signal [V]";
            // 
            // tcView
            // 
            this.tcView.Controls.Add(this.Values);
            this.tcView.Controls.Add(this.Settings);
            this.tcView.Location = new System.Drawing.Point(12, 12);
            this.tcView.Name = "tcView";
            this.tcView.SelectedIndex = 0;
            this.tcView.Size = new System.Drawing.Size(375, 225);
            this.tcView.TabIndex = 9;
            // 
            // Values
            // 
            this.Values.Controls.Add(this.txtError);
            this.Values.Controls.Add(this.lblControl);
            this.Values.Controls.Add(this.txtTemperature);
            this.Values.Controls.Add(this.lblError);
            this.Values.Controls.Add(this.txtControl);
            this.Values.Controls.Add(this.lblTemperature);
            this.Values.Location = new System.Drawing.Point(4, 22);
            this.Values.Name = "Values";
            this.Values.Padding = new System.Windows.Forms.Padding(3);
            this.Values.Size = new System.Drawing.Size(367, 199);
            this.Values.TabIndex = 0;
            this.Values.Text = "Values";
            this.Values.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.btnSetSetpoint);
            this.Settings.Controls.Add(this.neTd);
            this.Settings.Controls.Add(this.lblSetPoint);
            this.Settings.Controls.Add(this.txtSetPoint);
            this.Settings.Controls.Add(this.neTi);
            this.Settings.Controls.Add(this.neGain);
            this.Settings.Controls.Add(this.lblTd);
            this.Settings.Controls.Add(this.lblTi);
            this.Settings.Controls.Add(this.lblKp);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(367, 199);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // btnSetSetpoint
            // 
            this.btnSetSetpoint.Location = new System.Drawing.Point(247, 135);
            this.btnSetSetpoint.Name = "btnSetSetpoint";
            this.btnSetSetpoint.Size = new System.Drawing.Size(75, 20);
            this.btnSetSetpoint.TabIndex = 6;
            this.btnSetSetpoint.Text = "Set";
            this.btnSetSetpoint.UseVisualStyleBackColor = true;
            this.btnSetSetpoint.Click += new System.EventHandler(this.btnSetSetpoint_Click);
            // 
            // neTd
            // 
            this.neTd.Location = new System.Drawing.Point(141, 96);
            this.neTd.Name = "neTd";
            this.neTd.Size = new System.Drawing.Size(120, 20);
            this.neTd.TabIndex = 5;
            // 
            // neTi
            // 
            this.neTi.Location = new System.Drawing.Point(141, 63);
            this.neTi.Name = "neTi";
            this.neTi.Size = new System.Drawing.Size(120, 20);
            this.neTi.TabIndex = 4;
            // 
            // neGain
            // 
            this.neGain.Location = new System.Drawing.Point(141, 29);
            this.neGain.Name = "neGain";
            this.neGain.Size = new System.Drawing.Size(120, 20);
            this.neGain.TabIndex = 3;
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.Location = new System.Drawing.Point(18, 96);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(95, 13);
            this.lblTd.TabIndex = 2;
            this.lblTd.Text = "Derivative Time [s]";
            // 
            // lblTi
            // 
            this.lblTi.AutoSize = true;
            this.lblTi.Location = new System.Drawing.Point(18, 63);
            this.lblTi.Name = "lblTi";
            this.lblTi.Size = new System.Drawing.Size(82, 13);
            this.lblTi.TabIndex = 1;
            this.lblTi.Text = "Integral Time [s]";
            // 
            // lblKp
            // 
            this.lblKp.AutoSize = true;
            this.lblKp.Location = new System.Drawing.Point(18, 29);
            this.lblKp.Name = "lblKp";
            this.lblKp.Size = new System.Drawing.Size(29, 13);
            this.lblKp.TabIndex = 0;
            this.lblKp.Text = "Gain";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(21, 283);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 51);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "ttttt";
            // 
            // ControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 385);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tcView);
            this.Controls.Add(this.wfgTemperature);
            this.Name = "ControlSystem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wfgTemperature)).EndInit();
            this.tcView.ResumeLayout(false);
            this.Values.ResumeLayout(false);
            this.Values.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neTd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neTi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph wfgTemperature;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.TextBox txtSetPoint;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label lblSetPoint;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.TabControl tcView;
        private System.Windows.Forms.TabPage Values;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblTi;
        private System.Windows.Forms.Label lblKp;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTd;
        private NationalInstruments.UI.WindowsForms.NumericEdit neTi;
        private NationalInstruments.UI.WindowsForms.NumericEdit neGain;
        private System.Windows.Forms.Button btnSetSetpoint;
        private System.Windows.Forms.Label lblStatus;
    }
}

