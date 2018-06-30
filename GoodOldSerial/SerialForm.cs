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

namespace GoodOldSerial
{
    public partial class SerialForm : Form
    {
        public string inCom { get; set; }
        public string outCom { get; set; }
        public int baudRate { get; set; }

        protected bool isNormalMode = true;
        protected SerialPort serialOut;
        protected SerialPort serialIn;

        public SerialForm(string outcom, int baudrate, string incom = "")
        {
            InitializeComponent();
            inCom = incom;
            outCom = outcom;
            baudRate = baudrate;
            try
            {
                serialOut = new SerialPort(outcom, baudrate);
                serialOut.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            serialOut.DataReceived += serialOut_Data;
            if (incom != "")
            {
                isNormalMode = false;
                try
                {
                    serialIn = new SerialPort(incom, baudrate);
                    serialIn.Open();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                serialIn.DataReceived += serialIn_Data;
            }
        }

        private void inputTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            //Checks to make sure it was enter that was pressed
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            string text = inputTextbox.Text;
            serialOut.WriteLine(text);
            Invoke(new MethodInvoker(delegate ()
            {
                outputTextbox.AppendText(text + Environment.NewLine);
            }));
            inputTextbox.Clear();
        }

        private void serialOut_Data(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialOut.ReadLine();
            Invoke(new MethodInvoker(delegate ()
            {
                outputTextbox.AppendText(data + Environment.NewLine);
            }));
            if (!isNormalMode)
            {
                serialIn.WriteLine(data);
            }
        }

        private void serialIn_Data(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialIn.ReadLine();
            Invoke(new MethodInvoker(delegate ()
            {
                outputTextbox.AppendText(data + Environment.NewLine);
            }));
            serialOut.WriteLine(data);
        }
    }
}