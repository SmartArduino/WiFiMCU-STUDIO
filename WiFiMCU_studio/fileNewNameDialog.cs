using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiFiMCU
{
    public partial class fileNewNameDialog : Form
    {
        public fileNewNameDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string orginalFn = "";
        public string newFn = "";
        private void button1_Click(object sender, EventArgs e)
        {
            newFn = this.textBox2.Text;
            if (newFn.Length == 0 || newFn == orginalFn)
            {
                MessageBox.Show("You must input a new file name or cancel rename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void fileNewNameDialog_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = orginalFn;
            this.textBox2.Text = orginalFn;
        }
    }
}
