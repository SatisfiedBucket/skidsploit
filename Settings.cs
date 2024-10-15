using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynapseZAPI;

namespace skidsploit
{
    public partial class Settings : Form
    {
        public SynapseZAPI.SynapseZAPI synapseZAPI = new SynapseZAPI.SynapseZAPI();
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a completely safe joke roblox executor made by thebluenebula. It does not harm your PC and is merely made for entertainment purposes. We are sorry if you actually thought this was a real executor.", "Skidsploit");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseGambling = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("error: account already added.", "skidsploit");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseSynapseZ = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            synapseZAPI.Redeem(synapseZAPI.FindLauncher(Directory.GetCurrentDirectory()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            synapseZAPI.ResetHwid(synapseZAPI.FindLauncher(Directory.GetCurrentDirectory()));
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.UseSynapseZ;
            checkBox2.Checked = Properties.Settings.Default.UseGambling;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "scripts"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("next update, sorgy bonus!", "skidsploit");
        }
    }
}
