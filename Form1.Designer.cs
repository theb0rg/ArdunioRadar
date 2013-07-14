namespace ArdunioRadar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtRawInput = new System.Windows.Forms.TextBox();
            this.btnShowScanner = new System.Windows.Forms.Button();
            this.btnLockScanner = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.barTimeToLive = new System.Windows.Forms.TrackBar();
            this.barResolution = new System.Windows.Forms.TrackBar();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblTTL = new System.Windows.Forms.Label();
            this.lblApperanceSeconds = new System.Windows.Forms.Label();
            this.lblResolutionValue = new System.Windows.Forms.Label();
            this.ardunioRadarControl1 = new ArdunioRadar.ArdunioRadarControl();
            ((System.ComponentModel.ISupportInitialize)(this.barTimeToLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.txtDistance.Location = new System.Drawing.Point(11, 27);
            this.txtDistance.Multiline = true;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(248, 103);
            this.txtDistance.TabIndex = 0;
            this.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(49, -1);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(123, 25);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = " DISTANCE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ComPort";
            // 
            // txtComPort
            // 
            this.txtComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtComPort.Location = new System.Drawing.Point(159, 491);
            this.txtComPort.MaxLength = 2;
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(48, 22);
            this.txtComPort.TabIndex = 4;
            this.txtComPort.Text = "20";
            this.txtComPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDegree
            // 
            this.txtDegree.Enabled = false;
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.txtDegree.Location = new System.Drawing.Point(265, 27);
            this.txtDegree.MaximumSize = new System.Drawing.Size(207, 103);
            this.txtDegree.MinimumSize = new System.Drawing.Size(207, 103);
            this.txtDegree.Multiline = true;
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(207, 103);
            this.txtDegree.TabIndex = 5;
            this.txtDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEGREES";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show lines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRawInput
            // 
            this.txtRawInput.Location = new System.Drawing.Point(12, 493);
            this.txtRawInput.Name = "txtRawInput";
            this.txtRawInput.Size = new System.Drawing.Size(147, 20);
            this.txtRawInput.TabIndex = 9;
            // 
            // btnShowScanner
            // 
            this.btnShowScanner.Location = new System.Drawing.Point(389, 457);
            this.btnShowScanner.Name = "btnShowScanner";
            this.btnShowScanner.Size = new System.Drawing.Size(92, 23);
            this.btnShowScanner.TabIndex = 10;
            this.btnShowScanner.Text = "Show scanner";
            this.btnShowScanner.UseVisualStyleBackColor = true;
            this.btnShowScanner.Click += new System.EventHandler(this.btnShowScanner_Click);
            // 
            // btnLockScanner
            // 
            this.btnLockScanner.Location = new System.Drawing.Point(389, 479);
            this.btnLockScanner.Name = "btnLockScanner";
            this.btnLockScanner.Size = new System.Drawing.Size(92, 23);
            this.btnLockScanner.TabIndex = 11;
            this.btnLockScanner.Text = "Lock scanner";
            this.btnLockScanner.UseVisualStyleBackColor = true;
            this.btnLockScanner.Click += new System.EventHandler(this.btnLockScanner_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // barTimeToLive
            // 
            this.barTimeToLive.Location = new System.Drawing.Point(265, 491);
            this.barTimeToLive.Name = "barTimeToLive";
            this.barTimeToLive.Size = new System.Drawing.Size(104, 45);
            this.barTimeToLive.TabIndex = 13;
            this.barTimeToLive.Scroll += new System.EventHandler(this.barTimeToLive_Scroll);
            // 
            // barResolution
            // 
            this.barResolution.LargeChange = 200;
            this.barResolution.Location = new System.Drawing.Point(265, 447);
            this.barResolution.Maximum = 1000;
            this.barResolution.Minimum = 100;
            this.barResolution.Name = "barResolution";
            this.barResolution.Size = new System.Drawing.Size(104, 45);
            this.barResolution.SmallChange = 100;
            this.barResolution.TabIndex = 14;
            this.barResolution.TickFrequency = 100;
            this.barResolution.Value = 100;
            this.barResolution.Scroll += new System.EventHandler(this.barResolution_Scroll);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(300, 435);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 15;
            this.lblResolution.Text = "Resolution";
            // 
            // lblTTL
            // 
            this.lblTTL.AutoSize = true;
            this.lblTTL.Location = new System.Drawing.Point(274, 478);
            this.lblTTL.Name = "lblTTL";
            this.lblTTL.Size = new System.Drawing.Size(115, 13);
            this.lblTTL.TabIndex = 16;
            this.lblTTL.Text = "Seconds of apperance";
            // 
            // lblApperanceSeconds
            // 
            this.lblApperanceSeconds.AutoSize = true;
            this.lblApperanceSeconds.Location = new System.Drawing.Point(370, 501);
            this.lblApperanceSeconds.Name = "lblApperanceSeconds";
            this.lblApperanceSeconds.Size = new System.Drawing.Size(13, 13);
            this.lblApperanceSeconds.TabIndex = 17;
            this.lblApperanceSeconds.Text = "2";
            // 
            // lblResolutionValue
            // 
            this.lblResolutionValue.AutoSize = true;
            this.lblResolutionValue.Location = new System.Drawing.Point(363, 457);
            this.lblResolutionValue.Name = "lblResolutionValue";
            this.lblResolutionValue.Size = new System.Drawing.Size(25, 13);
            this.lblResolutionValue.TabIndex = 18;
            this.lblResolutionValue.Text = "400";
            // 
            // ardunioRadarControl1
            // 
            this.ardunioRadarControl1.DotsTimeToLive = System.TimeSpan.Parse("00:00:02");
            this.ardunioRadarControl1.EnableScannerRotation = true;
            this.ardunioRadarControl1.Location = new System.Drawing.Point(4, 136);
            this.ardunioRadarControl1.Name = "ardunioRadarControl1";
            this.ardunioRadarControl1.ResolutionInCentimeters = 400;
            this.ardunioRadarControl1.ShowLines = false;
            this.ardunioRadarControl1.ShowScanner = true;
            this.ardunioRadarControl1.Size = new System.Drawing.Size(477, 296);
            this.ardunioRadarControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 525);
            this.Controls.Add(this.lblResolutionValue);
            this.Controls.Add(this.lblApperanceSeconds);
            this.Controls.Add(this.lblTTL);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.barResolution);
            this.Controls.Add(this.barTimeToLive);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLockScanner);
            this.Controls.Add(this.btnShowScanner);
            this.Controls.Add(this.txtRawInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ardunioRadarControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 563);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 563);
            this.Name = "Form1";
            this.Text = "ArdunioRadar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barTimeToLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ArdunioRadarControl ardunioRadarControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRawInput;
        private System.Windows.Forms.Button btnShowScanner;
        private System.Windows.Forms.Button btnLockScanner;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar barTimeToLive;
        private System.Windows.Forms.TrackBar barResolution;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblTTL;
        private System.Windows.Forms.Label lblApperanceSeconds;
        private System.Windows.Forms.Label lblResolutionValue;
    }
}

