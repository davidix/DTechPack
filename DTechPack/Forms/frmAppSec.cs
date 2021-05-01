using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using DTechPack.Properties;
using System.Windows.Forms;

namespace DTechPack
{
    public partial class frmAppSec : Form
    {
        public frmAppSec()
        {
            InitializeComponent();
        }

        private void frmAppSec_Load(object sender, EventArgs e)
        {
            DriveInfo[] drv = DriveInfo.GetDrives();
            foreach (DriveInfo dx in drv)
            {
                if (dx.IsReady)
                {
                    comboBox1.Items.Add(dx.VolumeLabel).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.SafeLock = comboBox1.Text;
            Settings.Default.Save();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            ErrorProvider erp = new ErrorProvider();
             if (Pass1.Text == Pass2.Text)
            {
                Settings.Default.Password = Pass2.Text;
                Settings.Default.Save();
                MessageBox.Show("OK");
            }
             else
             {
                 Pass2.Clear(); Pass1.Clear();
                 Pass1.Focus();
                 erp.SetError(Pass1, "Try Again");
             }
                
        }

        private void frmAppSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Var.frmCount.AppSec = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
