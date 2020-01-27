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

namespace Zumo_GUI_Master_Controller
{
    public partial class Form1 : Form
    {   
        SerialPort port;
        string labelContents = "    ";
        string globalIndata;
        // private Object dummy = new object(); // needed if there are any thread-safety issues accessing the labelContents variable
        public Form1()
        {
            InitializeComponent();
            // SerialPort.GetPortNames();
            List<string> data = new List<string>();
            data.Add(" ");
            comboBox1.DataSource = data.Concat(SerialPort.GetPortNames()).ToList();
        }

        private string LabelContents
        {
            get
            {
                //lock (dummy) { // make it thread safe
                return labelContents; //}
            }
            set
            {
                //lock (dummy) { // make it thread safe
                labelContents = value;// }
            }
        }

        private void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();
                globalIndata = indata;
                this.Invoke(new EventHandler(outputBox_update));
                LabelContents = "Data Received:" + indata; // this event handler runs in a separate thread to the GUI, so might need the thread safety protections...
            }
            catch (Exception err)
            {
                MessageBox.Show("Error with error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            outputBox.Text = LabelContents;  // update the contents of the text box...
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string portName = (string)comboBox1.SelectedItem;
            try
            {
                port.Close(); // should probably also tidy up the event handler and dispose of the port object 
            }
            catch (Exception err)
            {
                LabelContents = "not connected yet ";
            }
            try
            {
                port = new SerialPort(portName, 9600);
                LabelContents = "connected to " + portName;
                port.Open();
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                timer1.Interval = 100;
                timer1.Start();
            }
            catch (Exception err)
            {
                LabelContents = "not connected yet ";
            }
        }

        private void btnWClick(object sender, EventArgs e)
        {
            // port.Open();
            port.Write("w");
            // port.Close();
        }

        private void btnSClick(object sender, EventArgs e)
        {
            //  port.Open();
            port.Write("s");
            // port.Close();
        }

        private void btnAClick(object sender, EventArgs e)
        {
            //  port.Open();
            port.Write("a");
            // port.Close();
        }

        private void btnDClick(object sender, EventArgs e)
        {
            //  port.Open();
            port.Write("d");
            // port.Close();
        }

        private void btnLeftTurn(object sender, EventArgs e)
        {
            port.Write("l");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            port.Write("r");
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            //  port.Open();
            port.Write("2");
            // port.Close();
        }

        private void boxUserInput_TextChanged(object sender, EventArgs e)
        {
            string tempInput = boxUserInput.Text;
            // Get last char in sequence since this text box will be full of garbage
            string userInput = tempInput.Substring(tempInput.Length - 1, 1);
            switch (userInput)
            {
                // Turn left 90 degrees
                case "l":
                    port.Write("l");
                    break;
                // Turn right 90 degrees
                case "r":
                    port.Write("r");
                    break;
                // Move forwards a bit
                case "w":
                    port.Write("w");
                    break;
                // Turn left a bit
                case "a":
                    port.Write("a");
                    break;
                // Move backwards a bit
                case "s":
                    port.Write("s");
                    break;
                // Turn right a bit
                case "d":
                    port.Write("d");
                    break;
                case "x":
                    port.Write("x");
                    break;
                //// Task 2 automation
                case "2":
                    port.Write("2");
                    break;
                case "c":
                    port.Write("c");
                    break;
            }
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            outputBox.ScrollToCaret();
        }

        private void outputBox_update(object sender, EventArgs e)
        {
            outputBox.AppendText(globalIndata);
        }
    }
}
