using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace DTechPack
{
    public partial class frmFileAccess : Form
    {
        public frmFileAccess()
        {
            InitializeComponent();
        }
        string FPath;
        string ARG;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Process prc = new Process();
            ARG = textBox1.Text + " " + textBox2.Text;
            ProcessStartInfo PSI = new ProcessStartInfo("UniExtract.exe ", ARG);
            PSI.CreateNoWindow = true;
            prc.StartInfo = PSI;
            prc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmFileAccess_Load(object sender, EventArgs e)
        {
            string[] drv = Directory.GetLogicalDrives();
            ComBoxDrives.DataSource = drv;
            
        }

        private void ComBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFiles.Items.Clear();
            string[] dirs = Directory.GetDirectories(ComBoxDrives.Text);
            ListFiles.Items.AddRange(dirs);
            string[] files = Directory.GetFiles(ComBoxDrives.Text);
            ListFiles.Items.AddRange(files);

        }

        private void ListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chHidden.Enabled = false; chReadOnly.Enabled = false; chSystem.Enabled = false;
            //chTempoary.Enabled = false;
            string F = ListFiles.SelectedItem.ToString();
            string Att = File.GetAttributes(F).ToString() ;
            textBox3.Text = Att;
            try
            {
                string[] AAtt = Att.Split(',');
                label4.Text = AAtt[0]; label5.Text = AAtt[1]; label6.Text = AAtt[2];
            }
            catch   {    }
            FPath = F;
            if (File.Exists(F))
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    if (File.GetAttributes(F) == FileAttributes.Hidden)
                //        chHidden.Checked = true;
                //    if (File.GetAttributes(F) == FileAttributes.Archive)
                //        chArchive.Checked = true;
                //    if (File.GetAttributes(F) == FileAttributes.ReadOnly)
                //        chReadOnly.Checked = true;
                //}

                //---CheckBox
                string[] ACAtt = Att.Split(',');
                for (int i = 0; i < ACAtt.Length; i++)
                {
                    foreach (Control cb in this.Controls)
                    {
                        if (cb.GetType().Name == "CheckBox")
                        {
                            cb.Text = "1000"; 
                        }
                    }
                }
            }
        }

        private void ListFiles_DoubleClick(object sender, EventArgs e)
        {
            string D0F = ListFiles.SelectedItem.ToString();
            if (Directory.Exists(D0F))
            {
                ListFiles.Items.Clear();
                string[] dir = Directory.GetDirectories(@D0F);
                ListFiles.Items.AddRange(dir);
                string[] files = Directory.GetFiles(ComBoxDrives.Text);
                ListFiles.Items.AddRange(files);
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(FPath))
            {
                File.SetAttributes(FPath, File.GetAttributes(FPath) |
                 FileAttributes.System | FileAttributes.ReadOnly);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Path = ListFiles.SelectedItem.ToString();
            if (File.Exists(Path))
            {
                File.Encrypt(Path);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "You Selected :\n";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    label8.Text += checkedListBox1.Items[i]+";";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string F = textBox4.Text;
            string Att = File.GetAttributes(F).ToString();
            textBox3.Text = Att;
            try
            {
                string[] AAtt = Att.Split(',');
                label4.Text = AAtt[0]; label5.Text = AAtt[1]; label6.Text = AAtt[2];
            }
            catch { }
            FPath = F;
            if (File.Exists(F))
            {

                string[] ACAtt = Att.Split(',');
                for (int i = 0; i < ACAtt.Length; i++)
                {
                    foreach (Control cb in this.Controls)
                    {
                        if (cb.GetType().Name == "CheckBox")
                        {
                            cb.Text = "1000";
                        }
                    }
                }
            }
        }
    }
}
