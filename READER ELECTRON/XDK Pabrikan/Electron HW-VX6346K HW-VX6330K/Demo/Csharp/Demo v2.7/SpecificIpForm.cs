using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HwVx6330K
{
    public partial class SpecificIpForm : Form
    {

        public string IP1
        {
            get
            {
                return this.ip1TextBox.Text.Trim();
            }
        }

        public string IP2
        {
            get
            {
                return this.ip2TextBox.Text.Trim();
            }
        }
        public string IP3
        {
            get
            {
                return this.ip3TextBox.Text.Trim();
            }
        }

        public string IP4
        {
            get
            {
                return this.ip4TextBox.Text.Trim();
            }
        }
        public SpecificIpForm()
        {
            InitializeComponent();
        }

        private void ipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;

            // Ignore except number & backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            // Accept any number if length is < 2 or if backspace is pressed
            if (textBox.Text.Length < 2 || e.KeyChar == 8)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (3 > textBox.Text.Length) return;

            int value = Int32.Parse(textBox.Text); 
            int limit = (textBox == this.ip1TextBox) ? 223 : 255;

            if (value > limit || value < 1)
            {
                MessageBox.Show(value + " is Invalid. Please input number between 1 and " + limit);
                textBox.SelectAll();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}