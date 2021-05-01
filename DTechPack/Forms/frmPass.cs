using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTechPack.Properties;

namespace DTechPack
{
    public partial class frmPass : Form
    {
        DialogResult dr;
        public frmPass()
        {
            InitializeComponent();
        }

        private void frmPass_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.TopMost = true;
            frmMain fr1 = new frmMain();
            fr1.Hide();
            this.KeyPreview = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text!=Settings.Default.Password)
                dr=MessageBox.Show("Wrong Password","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                {
                    return;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                    Application.Exit();
            }
        }
    }
}
