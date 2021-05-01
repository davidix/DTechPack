using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DTechPack.Properties;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTechPack
{
    public partial class frmMain : Form
    {
        Mehods clsMethods = new Mehods();
        Win32API API = new Win32API();
        public frmMain()
        {
            InitializeComponent();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.TopMost = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TShslock.Text = "Current HD Protection : " + Settings.Default.SafeLock.ToString();
            if (Settings.Default.SafeLock != "")
                if (Settings.Default.Password != "")
                {
                    frmPass frmpass = new frmPass();
                    frmpass.Show();
                }
               // clsMethods.XCheck();
        }
        public void CHform(Form frm)
        {
            frm.MdiParent = this;
            frm.ShowInTaskbar = false;
            frm.Show();
        }
        #region Windows Title
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Var.frmCount.Sys!=1)
            {
                frmSys frmsys = new frmSys();
                CHform(frmsys);
                Var.frmCount.Sys++;
            }
        }

        private void openCloseCDRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Win32API.mciSendString("Set CDAudio Door Open Wait", "0", 0, 0);
            }
            catch { }
        }

        private void closeCDRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win32API.mciSendString("Set CDAudio Door Closed Wait", "0", 0, 0);
        }



        private void applicationStartupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Var.frmCount.AppSec!=1)
            {
                frmAppSec frmSec = new frmAppSec();
                CHform(frmSec);
                Var.frmCount.AppSec++;
            }
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppearance frmAprn = new frmAppearance();
            CHform(frmAprn);
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(null, null);
        }

        private void slideBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripContainer1.Visible)
                toolStripContainer1.Visible = false;
            else
                toolStripContainer1.Visible = true;
        }




        private void encryptionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmASCI frmASCI = new frmASCI(); CHform(frmASCI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryptionToolStripMenuItem_Click_1(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFileAccess frmFA = new frmFileAccess();
            CHform(frmFA);
        }
		void Button5Click(object sender, EventArgs e)
		{
			frmNotePad frm =new frmNotePad();
			frm.ShowDialog();
		}
    }
}
