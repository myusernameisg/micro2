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
        int readyToGraph = 0;
        delegate void setNewDataCallback(string newData);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(ports);
        }


    private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = 0;

                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "No ports or bad settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {
                MessageBox.Show( "COM Port Open", "Information stream beginnig", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                timer1.Enabled = true;
            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!(readyToGraph == 2))
            {
                readyToGraph++;
            }
            else DoUpdate(serialPort1.ReadLine());         
        }
        public void DoUpdate(string data)
        {
            if(this.TemperatureGraph.InvokeRequired)
            {
                setNewDataCallback dataCallback = new setNewDataCallback(DoUpdate);
                this.Invoke(dataCallback, new object[] { data });
            }
            else
            {
                this.TemperatureGraph.Series.FindByName("Temperature").Points.AddY(int.Parse(data));
                rTextTemp.Text = data;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("COM Port Closed", "Information stream stopping", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
