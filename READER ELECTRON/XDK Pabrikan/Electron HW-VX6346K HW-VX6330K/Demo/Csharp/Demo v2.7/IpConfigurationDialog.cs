using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HwVx6330K
{
    public partial class IPConfigurationDialog : Form
    {
        public void SetUsername(string usename)
        {
            usernameTextBox.Text = usename;
        }
        public void SetDeviceName(string dsname)
        {
            deviceNameTextBox.Text = dsname;
        }
        public void SetMacAddress(string MAC)
        {
            macAddressTextBox.Text = MAC;
        }
        public void SetIpAddress(string IP)
        {
            ipAddressTextBox.Text = IP;
        }
        public void SetPortNumber(string portnum)
        {
            portTextBox.Text = portnum;
        }
        public void SetProtocol(string tup)
        {
            protocolComboBox.SelectedIndex = Convert.ToInt32(tup);
        }
        public void SetWorkMode(string rm)
        {
            workModeComboBox.SelectedIndex = Convert.ToInt32(rm);
        }
        public void SetRemoteIp(string di)
        {
            remoteIpTextBox.Text = di;
        }
        public void SetGatewayIp(string gi)
        {
            gatewayIpTextBox.Text = gi;
        }
        public void SetSubnetMask(string nm)
        {
            maskTextBox.Text = nm;
        }
        public void SetRemotePort(string dp)
        {
            remotePortTextBox.Text = dp;
        }
        
        public void SetBaudRate(string br)
        {
            baudRateComboBox.SelectedIndex = Convert.ToInt32(br);
        }
        public void SetParity(string pr)
        {
            parityComboBox.SelectedIndex = Convert.ToInt32(pr);
        }
        public void SetDataBits(string bb)
        {
            dataBitsComboBox.SelectedIndex = Convert.ToInt32(bb);
        }
        public void SetDts(string dt)
        {
            dtrModeComboBox.SelectedIndex = Convert.ToInt32(dt);
        }
        public void SetRts(string fc)
        {
            rtsComboBox.SelectedIndex = Convert.ToInt32(fc);
        }
       /* public void _cm(string cm1)
        {
            Information.cm = cm1;
        }
        public void _ct(string ct1)
        {
            Information.ct = ct1;
        }
        public void _ml(string ml1)
        {
            Information.ml = ml1;
        }
        public void _md(string md1)
        {
            Information.md = md1;
        }
        public void _rc(string rc1)
        {
            Information.rc = rc1;
        }*/
        public IPConfigurationDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fNhSetDlg fnhSetDlg = new fNhSetDlg();
            fnhSetDlg._cm(Information.cm);
            fnhSetDlg._ct(Information.ct);
            DialogResult result=fnhSetDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Information.cm=fnhSetDlg.cm;
                    Information.ct = fnhSetDlg.ct;
                }
                catch (System.Exception ex)
                {
                    ex.ToString();
                }
            }
            fnhSetDlg.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fPhSetDlg fphSetDlg = new fPhSetDlg();
            fphSetDlg._md(Information.md);
            fphSetDlg._ml(Information.ml);
            fphSetDlg._rc(Information.rc);
            DialogResult result = fphSetDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Information.md = fphSetDlg.md;
                    Information.ml = fphSetDlg.ml;
                    Information.rc = fphSetDlg.rc;
                }
                catch (System.Exception ex)
                {
                    ex.ToString();
                }
            }
            fphSetDlg.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information.usename = usernameTextBox.Text.Trim();
            Information.dsname = deviceNameTextBox.Text.Trim();
            Information.mac = macAddressTextBox.Text.Trim();
            Information.IP = ipAddressTextBox.Text.Trim();
            Information.portnum = portTextBox.Text.Trim();
            Information.tup = Convert.ToString(protocolComboBox.SelectedIndex);
            Information.rm = Convert.ToString(workModeComboBox.SelectedIndex);
            Information.di = remoteIpTextBox.Text.Trim();
            Information.gi = gatewayIpTextBox.Text.Trim();
            Information.nm = maskTextBox.Text.Trim();
            Information.dp = remotePortTextBox.Text.Trim();
            Information.br = Convert.ToString(baudRateComboBox.SelectedIndex);
            Information.pr = Convert.ToString(parityComboBox.SelectedIndex);
            Information.bb = Convert.ToString(dataBitsComboBox.SelectedIndex);
            Information.dt = Convert.ToString(dtrModeComboBox.SelectedIndex);
            Information.fc = Convert.ToString(rtsComboBox.SelectedIndex); 
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(workModeComboBox.SelectedIndex==0)
            {
                remoteIpTextBox.ReadOnly = true;
                gatewayIpTextBox.ReadOnly = true;
                maskTextBox.ReadOnly = true;
                remotePortTextBox.ReadOnly = true;
            }
            else
            {
                remoteIpTextBox.ReadOnly = false;
                gatewayIpTextBox.ReadOnly = false;
                maskTextBox.ReadOnly = false;
                remotePortTextBox.ReadOnly = false;
            }
        }
    }
}