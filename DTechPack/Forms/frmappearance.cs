using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTechPack
{
    public partial class frmAppearance : Form
    {
        public frmAppearance()
        {
            InitializeComponent();
        }

        private void frmappearance_Load(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            Var.opacity = trackBar1.Value;
        }
    }
}
