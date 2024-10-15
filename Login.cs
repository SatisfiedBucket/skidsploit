using skidsploit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skidsploit
{
    public partial class Login : Form
    {
        int Count = 0;
        Main main = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UseGambling)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 1000000000);
                if (randomNum != 1)
                {
                    MessageBox.Show("you got " + randomNum + "! try again until you land on 1/1000000000 to make a free account.", "unlucky");
                }
                else
                {
                    MessageBox.Show("unable to contact servers, try again later.", "skidsploit");
                }
            }
            else
            {
                MessageBox.Show("unable to contact servers, try again later.", "skidsploit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != "MoonSecIsMyWorstEnemy201")
            {
                if (passwordBox.Text == "incorrect")
                {
                    MessageBox.Show("wow! so funny! what a funny joke! lol!", "skidsploit");
                }
                else
                {
                    Count += 1;
                    if (Count == 1)
                    {
                        MessageBox.Show("your password is incorrect. please try again", "skidsploit");
                    }
                    if (Count == 2)
                    {
                        MessageBox.Show("password hint: MoonSecIsMyWorstEnemy201", "skidsploit");
                    }
                    if (Count == 3)
                    {
                        MessageBox.Show("my brother in christ i just said the password", "skidsploit");
                    }
                    if (Count == 4)
                    {
                        MessageBox.Show("how are you still fucking this up", "skidsploit");
                    }
                    if (Count == 5)
                    {
                        MessageBox.Show("ok you dont deserve to use this godtier exploit, fuck you. bye", "skidsploit");
                        this.Close();
                    }
                }
            }
            else
            {
                Properties.Settings.Default.DontSkipLogin = checkBox1.Checked;
                Properties.Settings.Default.Save();
                this.Hide();
                main.Show();
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
