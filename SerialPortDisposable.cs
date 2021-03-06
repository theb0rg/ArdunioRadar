using System;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace ArdunioRadar
{
	class SerialPortDisposable : IDisposable
	{
		private SerialPort myPort;

		public SerialPortDisposable(String Com)
		{
			SerialPort SerialPort1 = new SerialPort();
			SerialPort1.PortName = Com;
			SerialPort1.BaudRate = 9600;
			SerialPort1.Parity = System.IO.Ports.Parity.None;
			SerialPort1.DataBits = 8;
			SerialPort1.StopBits = System.IO.Ports.StopBits.One;
			SerialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
			SerialPort1.RtsEnable = true;
			myPort = SerialPort1;
           
		}
        public SerialPort instance
        {
            get { return myPort;}
            set { myPort = value; }
        }
        public SerialDataReceivedEventHandler DataRecieved
        {
            //get { return myPort.DataReceived; }
            set { myPort.DataReceived += value; }
        }

        public bool IsOpen()
        {
            return myPort.IsOpen;
        }
		public void OpenPort()
		{
			myPort.Open();
		}
		public void Send(string StringMessage)
		{
			Encoding encoding = Encoding.GetEncoding("437");

			byte[] message;

			message = encoding.GetBytes(StringMessage);
			myPort.Write(message, 0, message.Length);

			Send((byte)char.MinValue);

		}
		public void Send(byte bytes)
		{
			myPort.Write (new Byte[]{bytes},0,1);
		}
		public string ReadExisting()
		{
			return myPort.ReadExisting();
		}

        public string ReadLine()
        {
            return myPort.ReadLine();
        }

		public void Dispose()
		{
			if(myPort.IsOpen)
			{
				myPort.Close ();
			}
			myPort.Dispose();
		}

		public void Close()
		{
            if(myPort.IsOpen)
			myPort.Close();
		}

	}
}

