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
        delegate void SetTextDistanceCallback(string text);
        delegate void SetTextDegreesCallback(string text);
        delegate void SetTextRawInputCallback(string text);
        delegate void SetPingResponseCallback(PingResponse ping);
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
                MessageBox.Show(e.ToString());
            }
        }

        private void SetTextRawInput(String text)
        {
            try
            {
                if (this.txtRawInput.InvokeRequired)
                {
                    SetTextRawInputCallback d = new SetTextRawInputCallback(SetTextRawInput);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txtRawInput.Text = text;
                }
            }
            catch (Exception e)
            {
                // return "Error";
                MessageBox.Show(e.ToString());
            }
        }
        private void SetTextDistance(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (this.txtDistance.InvokeRequired)
                {
                    SetTextDistanceCallback d = new SetTextDistanceCallback(SetTextDistance);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txtDistance.Text = text;
                }
            }
            catch(Exception e){
               // return "Error";
                MessageBox.Show(e.ToString());
            }
        }

        private void SetTextDegrees(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (this.txtDegree.InvokeRequired)
                {
                    SetTextDistanceCallback d = new SetTextDistanceCallback(SetTextDegrees);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txtDegree.Text = text;
                }
            }
            catch (Exception e)
            {
                // return "Error";
                MessageBox.Show(e.ToString());
            }
        }

        private void SetPingResponse(PingResponse ping)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (this.ardunioRadarControl1.InvokeRequired)
                {
                    SetPingResponseCallback d = new SetPingResponseCallback(SetPingResponse);
                    this.Invoke(d, new object[] { ping });
                }
                else
                {
                    this.ardunioRadarControl1.UpdateRadar(ping);
                    this.ardunioRadarControl1.Refresh();
                }
            }
            catch (Exception e)
            {
                // return "Error";
                MessageBox.Show(e.ToString());
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
            else
            {
                thread = new Thread(new ThreadStart(this.UpdateThread));
                thread.Start();
            }      
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
            try
            {
                SerialPort port = (SerialPort)sender;
                String input = port.ReadLine();
                SetTextRawInput(input);

                String[] data = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (data.Count() >= 2)
                {
                    int Distance = Convert.ToInt32(data[0]);
                    int Degrees = Convert.ToInt32(data[1]);

                    SetTextDistance(Distance + " CM");
                    SetTextDegrees(Degrees + "o");
                    SetPingResponse(new PingResponse(Degrees, Distance));
                }
                else if (data.Count() == 1)
                {
                    SetTextDistance("OLD VERSION");
                    SetTextDegrees("OLD VERSION");
                }
                else
                {
                    SetTextDistance("?");
                    SetTextDegrees("?");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        int degreeeees = 90;
        private void timer1_Tick(object sender, EventArgs e)
        {
           // if (degreeeees > 180)
           //         degreeeees = 0;
           //degreeeees += 25;
           //     ardunioRadarControl1.UpdateRadar(new PingResponse(degreeeees, 300));
           // ardunioRadarControl1.Refresh();

            if (thread.IsAlive)
            {
                button1.Text = "Connected";
            }
            else
            {
                button1.Text = "Disconnected";
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ardunioRadarControl1.LinesEnabled = ! ardunioRadarControl1.LinesEnabled;
            ardunioRadarControl1.Refresh();
        }
    }
}
