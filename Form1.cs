using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ArdunioRadar
{
    public partial class Form1 : Form
    {
        static String ComPort = "";
        delegate void SetTextCallback(string text);
        delegate void SetColorCallback(Color color);

        Thread thread;

        public Form1()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(this.UpdateThread));
        }

        private void SetColor(Color color)
        {
            try
            {
                if (this.button1.InvokeRequired)
                {
                    SetColorCallback d = new SetColorCallback(SetColor);
                    this.Invoke(d, new object[] { color });
                }
                else
                {
                    this.button1.BackColor = color;
                }
            }
            catch (Exception e)
            {
                // return "Error";
                //MessageBox.Show(e.ToString());
            }
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (this.txtDistance.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txtDistance.Text = text;
                }
            }
            catch(Exception e){
               // return "Error";
                //MessageBox.Show(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtComPort.Text.Trim() != string.Empty)
            ComPort = "COM" + txtComPort.Text;

            if (thread.IsAlive)
            {
                thread.Abort();
                thread = new Thread(new ThreadStart(this.UpdateThread));
            }

            thread.Start();            
        }

        private void UpdateThread()
        {
            try
            {
                using (SerialPortDisposable mySerialPort = new SerialPortDisposable(ComPort))
                {
                    lock (mySerialPort)
                    {
                        mySerialPort.instance.DataReceived += serialPort1_DataReceived;

                        mySerialPort.OpenPort();
                        SetColor(Color.Green);
                        while (mySerialPort.IsOpen())
                        {
                            Thread.Sleep(10);
                        }
                        SetColor(Color.Red);
                    }
                }
            }
            catch(Exception e){
                MessageBox.Show(e.ToString());
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            SetText(port.ReadExisting());
        }
    }
}
