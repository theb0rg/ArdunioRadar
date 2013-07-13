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
            this.ardunioRadarControl1 = new ArdunioRadar.ArdunioRadarControl();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRawInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(11, 27);
            this.txtDistance.Multiline = true;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(215, 103);
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
            this.label1.Location = new System.Drawing.Point(210, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ComPort";
            // 
            // txtComPort
            // 
            this.txtComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtComPort.Location = new System.Drawing.Point(209, 454);
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
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // ardunioRadarControl1
            // 
            this.ardunioRadarControl1.LinesEnabled = false;
            this.ardunioRadarControl1.Location = new System.Drawing.Point(4, 136);
            this.ardunioRadarControl1.Name = "ardunioRadarControl1";
            this.ardunioRadarControl1.Size = new System.Drawing.Size(477, 296);
            this.ardunioRadarControl1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Enable lines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRawInput
            // 
            this.txtRawInput.Location = new System.Drawing.Point(12, 493);
            this.txtRawInput.Name = "txtRawInput";
            this.txtRawInput.Size = new System.Drawing.Size(195, 20);
            this.txtRawInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 525);
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
    }
}

