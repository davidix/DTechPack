using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DTechPack
{
    public partial class frmSys : Form
    {
        string ProcessFileNameKill;
        string saveProcessFile;
        Mehods clsmeth = new Mehods();
        public frmSys()
        {
            InitializeComponent();
        }

        private void LoadProperties()
        {
            lblWorkingset.Text = Environment.WorkingSet.ToString();
            lblVersion.Text = Environment.Version.ToString();
            lblUserName.Text = Environment.UserName;
            lblUserDomainName.Text = Environment.UserDomainName;
            lblTickCount.Text = Environment.TickCount.ToString();
            lblSystemDirectory.Text = Environment.SystemDirectory;
            lblOSVersion.Text = Environment.OSVersion.ToString();
            lblMachineName.Text = Environment.MachineName;
            lblCurrentDirectory.Text = Environment.CurrentDirectory;
            lblCommandLine.Text = Environment.CommandLine.ToString();
        }
        private void frmSys_Load(object sender, EventArgs e)
        {
            //listbox get process
            clsmeth.GetProcessLB(listBox2);
            LoadProperties();
          //  clsmeth.GetProcess(lvProcess);
            clsmeth.LoadList(lstFolders, typeof(Environment.SpecialFolder));
            clsmeth.LoadList(lstEnvironmentVariables, ((System.Collections.IDictionary)Environment.GetEnvironmentVariables()).Keys);

        }

        private void lstEnvironmentVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEnvironmentVariable.Text = Environment.GetEnvironmentVariable(lstEnvironmentVariables.SelectedItem.ToString());

        }

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Environment.SpecialFolder sf;
            sf = (Environment.SpecialFolder)System.Enum.Parse(typeof(Environment.SpecialFolder), lstFolders.SelectedItem.ToString());
            lblSpecialFolder.Text = Environment.GetFolderPath(sf);
        }

        private void btnGetSystemFolder_Click(object sender, EventArgs e)
        {
            lblSystemFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.System);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultVar.Text = Environment.ExpandEnvironmentVariables(txtEnvirvar.Text);
        }

        private void lvProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRefreshTickCount_Click(object sender, EventArgs e)
        {
            lblTickCount.Text = Environment.TickCount.ToString();
        }

        private void frmSys_FormClosed(object sender, FormClosedEventArgs e)
        {
            Var.frmCount.Sys = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsmeth.XPWithoutSize(lvProcess, prcsTXT.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection slvi = new ListView.SelectedListViewItemCollection(listView2);
            foreach (ListViewItem itm in slvi)
            {
                textBox4.Text = itm.Name;
            }
        }

        private void pgeProcess_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsmeth.X2Process(listView2, listBox2.SelectedItem.ToString());
           // textBox3.Text = listBox2.SelectedItem.ToString();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    clsmeth.GetProcessLB(listBox1);
        //}

        //private void rbALLP_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbALLP.Checked)
        //       clsmeth.GetProcessLB(listBox2);
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton2.Checked)
        //    {
        //       clsmeth.GetProcessLBTaskProcess(listBox2);
        //    }
        //}
        
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = sfd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            clsmeth.GetProcessLBTaskProcess(listBox2);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                clsmeth.GetProcessLB(listBox2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clsmeth.PrcsKill(ProcessFileNameKill);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (string x in listBox1.Items)
            {
                clsmeth.PrcsKill(x);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Copy(textBox4.Text, textBox5.Text);
        }


    }
}
