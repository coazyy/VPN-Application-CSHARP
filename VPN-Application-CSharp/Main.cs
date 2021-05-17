using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPN_Application_CSharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneRoundedButton2.Enabled = false;
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (siticoneRoundedComboBox1.Text == "")
            {
                MessageBox.Show("Please select a Server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (siticoneRoundedComboBox1.Text == "Server 1")
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = @"--config CONFIGNAME";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                siticoneRoundedButton2.Enabled = true;
                siticoneRoundedButton1.Enabled = false;
                //End of connection
            }
            if (siticoneRoundedComboBox1.Text == "Server 2")
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = @"--config CONFIGNAME2";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                siticoneRoundedButton2.Enabled = true;
                siticoneRoundedButton1.Enabled = false;
                //End of connection
            }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            siticoneRoundedButton1.Enabled = true;
            siticoneRoundedButton2.Enabled = false;
        }
    }
}
