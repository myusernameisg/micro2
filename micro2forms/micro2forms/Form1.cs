using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace micro2forms
{
    public partial class Form1 : Form
    {
        string readBuffer;
        string temperature;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(ports);
        }

        public void DoUpdate(object sender, System.EventArgs e)
        {
            rTextTemp.Text = readBuffer;//show value
        }

        public void DoUpdatee()
        {
            rTextTemp.Text = readBuffer;//show value
        }

        private void SerialPort1_DataReceived(System.Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            readBuffer = serialPort1.ReadLine(); 
            Invoke(new EventHandler(DoUpdate)); 
        }

    private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort temperaturePort = new SerialPort();

                temperaturePort.PortName = cBoxCOMPort.Text;
                temperaturePort.BaudRate = 9600;
                temperaturePort.DataBits = 8;
                temperaturePort.StopBits = (StopBits)1;
                temperaturePort.Parity = 0;

                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "No ports or bad settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {
                MessageBox.Show( "COM Port Open", "Information stream beginnig", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serialPort1.ReceivedBytesThreshold = 20;
                serialPort1.NewLine = "\r";
                serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                rTextTemp.Text = readBuffer;
                //while (serialPort1.IsOpen)
                //{
                    TemperatureGraph.Series["Temperature"].Points.AddXY(DateTime.Now.Minute, readBuffer);
                    DoUpdatee();

                //}
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
