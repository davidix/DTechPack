using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DTechPack
{
    public partial class frmASCI : Form
    {
        public frmASCI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbTXT.Checked)
            {
                try
                {
                    string Key = (comboBox1.SelectedItem.ToString()) + (comboBox1.SelectedItem.ToString()) + "▌☼";
                    string IV = (comboBox1.SelectedItem.ToString()) + (comboBox2.SelectedItem.ToString()) + Key;
                    textBox1.Text = ASCI.enc(richTextBox1.Text, Key, IV);
                }
                catch
                {
                    MessageBox.Show("Bad Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (rbFILE.Checked)
            {
                try
                {
                    //string Key = (comboBox1.SelectedItem.ToString()) + (comboBox1.SelectedItem.ToString()) + "▌☼";
                    //string IV = (comboBox1.SelectedItem.ToString()) + (comboBox2.SelectedItem.ToString()) + Key;
                    //string str = File.ReadAllText(textBox2.Text);
                    //File.WriteAllText(textBox3.Text, ASCI.enc(str, Key, IV));
                    //---------------------------------------------------------
                    ASCI.DecryptFile(textBox2.Text, textBox3.Text);

                }
                catch
                {
                    MessageBox.Show("Bad Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbTXT.Checked)
            {
                try
                {
                    string Key = (comboBox1.SelectedItem.ToString()) + (comboBox1.SelectedItem.ToString()) + "▌☼";
                    string IV = (comboBox1.SelectedItem.ToString()) + (comboBox2.SelectedItem.ToString()) + Key;
                    textBox1.Text = ASCI.dec(richTextBox1.Text, Key, IV);
                }
                catch
                {
                    MessageBox.Show("Bad Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (rbFILE.Checked)
            {
                ASCI.DecryptFile(textBox2.Text, textBox3.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                grptext.Enabled = false;
                grpFile.Enabled = true;
        }

        private void rbTXT_CheckedChanged(object sender, EventArgs e)
        {
            grptext.Enabled = true;
            grpFile.Enabled = false;
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = sfd.FileName;
            }
        }

        private void frmASCI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Var.frmCount.Enc = 0;
        }

        private void frmASCI_Load(object sender, EventArgs e)
        {
            rbTXT.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ASCI.FileDec(textBox2.Text, textBox3.Text);
        }

    }
}
