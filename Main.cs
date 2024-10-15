using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynapseZAPI;

namespace skidsploit
{
    public partial class Main : Form
    {
        Settings settings = new Settings();
        bool FakeAttach = false;
        string Path1 = Path.Combine(Application.StartupPath, "scripts");
        string Path2 = Path.Combine(Application.StartupPath, "bin");
        public SynapseZAPI.SynapseZAPI synapseZAPI = new SynapseZAPI.SynapseZAPI();

        MemoryStream userInput = new MemoryStream();

        public Main()
        {
            InitializeComponent();
            if (!Directory.Exists(Path1))
            {
                Directory.CreateDirectory(Path1);
            }
            if (!Directory.Exists(Path2))
            {
                Directory.CreateDirectory(Path2);
            }
            PopulateListBox(ScriptList, Path1);
            if (Debugger.IsAttached)
            {
                Properties.Settings.Default.Reset();
            }
        }


        // THE ONE... THE ONLY... POPULATELISTBOX!!!!!!!!!!!!!!!!
        public static void PopulateListBox(ListBox lsb, string Folder)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles();

            lsb.Items.Clear();
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        private void ExecuteScript(string script)
        {
            if (!FakeAttach)
            {
                if (Properties.Settings.Default.UseSynapseZ)
                {
                    synapseZAPI.Execute(Directory.GetCurrentDirectory(), script);
                }
                else
                {
                    MessageBox.Show("you think i was gonna attach for you? nerd.", "skidsploit");
                }
            }
            else
            {
                if (Properties.Settings.Default.UseSynapseZ)
                {
                    synapseZAPI.Execute(Directory.GetCurrentDirectory(), script);
                }
                else
                {
                    System.Diagnostics.Process.Start("https://youtu.be/FWO2FVNs8DQ");
                    Task.Delay(200);
                    System.Diagnostics.Process.Start("https://youtu.be/rtq4az35wHk");
                }
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UseGambling)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 10);
                if (randomNum != 1)
                {
                    MessageBox.Show("you got " + randomNum + "! try again until you land on 1/10 and win.", "skidsploit");
                }
                else
                {
                    Task.Delay(200);
                    if (Properties.Settings.Default.UseSynapseZ)
                    {
                        synapseZAPI.Inject(Directory.GetCurrentDirectory());
                    }
                    else
                    {
                        FakeAttach = true;
                        MessageBox.Show("attached.", "skidsploit");
                    }
                }
            }
            else
            {
                Task.Delay(200);
                if (Properties.Settings.Default.UseSynapseZ)
                {
                    synapseZAPI.Inject(Directory.GetCurrentDirectory());
                }
                else
                {
                    FakeAttach = true;
                    MessageBox.Show("attached.", "skidsploit");
                }
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.lua|*.txt";
            openFile1.Filter = "Roblox Scripts|*.lua|Boring Text Documents|*.txt";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                Editor.Text = File.ReadAllText(openFile1.FileName);
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ExecuteScript(Editor.Text);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void ExecuteFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.lua|*.txt";
            openFile1.Filter = "Roblox Scripts|*.lua|Boring Text Documents|*.txt";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                ExecuteScript(File.ReadAllText(openFile1.FileName));
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            //saveFile1.FileName = "";

            saveFile1.DefaultExt = "*.lua|*.txt";
            saveFile1.Filter = "Roblox Scripts|*.lua|Boring Text Documents|*.txt";

            saveFile1.DefaultExt = Path1;

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                Editor.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Tick_Tick(object sender, EventArgs e)
        {

        }

        private void ScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Editor.Text = "";
        }

        private void ballsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ScriptList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control control = (Control)sender;

                var startPoint = control.PointToScreen(new Point(e.X, e.Y));
                contextMenuStrip1.Show(startPoint);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "execute")
            {
                string Script = File.ReadAllText(Path1 + $"/{ScriptList.SelectedItem}");
                ExecuteScript(Script);
            }
            if (e.ClickedItem.Text == "load into editor")
            {
                string Script = File.ReadAllText(Path1 + $"/{ScriptList.SelectedItem}");
                Editor.Text = Script;
            }
            if (e.ClickedItem.Text == "refresh")
            {
                PopulateListBox(ScriptList, Path1);
            }
        }

        private void loadInEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] localByName = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (Process p in localByName)
            {
                p.Kill();
                MessageBox.Show("roblox is kil", "skidsploit");
            }
        }
    }
}
