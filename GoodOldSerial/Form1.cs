using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodOldSerial
{
    public partial class Form1 : Form
    {
        private bool isNormSerial = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if ((string)radioButton.Tag == "norm" && radioButton.Checked)
            {
                isNormSerial = true;
                inputTxtbox.Enabled = false;
            }
            else if ((string)radioButton.Tag == "disp" && radioButton.Checked)
            {
                isNormSerial = false;
                inputTxtbox.Enabled = true;
            }
        }

        private void txtBox_Unfocus(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            if (txtbox.Text == "")
            {
                txtbox.Text = (string)txtbox.Tag;
            }
        }

        private void txtBox_Focus(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            if (txtbox.Text == (string)txtbox.Tag)
            {
                txtbox.Text = "";
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //Basic value checking
            int baudrate;
            if ((outputTxtbox.Text == (string)outputTxtbox.Tag) || (inputTxtbox.Text == (string)inputTxtbox.Tag && !isNormSerial))
            {
                MessageBox.Show("You've left the default text you lazy bastard!");
                return;
            }
            if (!int.TryParse(baudTxtbox.Text, out baudrate))
            {
                MessageBox.Show("Baud rate should be a number!");
                return;
            }
            if (isNormSerial)
            {
                new SerialForm(outputTxtbox.Text, baudrate).Show();
            }
            else
            {
                new SerialForm(outputTxtbox.Text, baudrate, inputTxtbox.Text).Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emile Akbarzadeh's Good old serial.\nFor help go to Help>Help \nCopyright " + DateTime.Now.Year + "\nhttps://github.com/emileakbarzadeh");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Normal mode is just like a regular serial monitor. \n Input your output port and baud rate. Port is in the format: \"COM7\". \n" +
                "\nDisplay and forward mode is a unique feature that enables you to view what is being sent between two devices. /n" +
                "To enable this mode, you'll need to setup com0com or some other serial loopback driver. \n" +
                "Once ready, have one end of the loopback going into the \"Input\" box and the external device going into the \"Output\" box", "Help");
        }
    }
}