using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroFramework.WiFiMCU
{
    public partial class TestForm1 : MetroForm
    {
        public TestForm1()
        {
            InitializeComponent();
        }
        public string orginalFn = "";
        public string newFn = "";

        private void metroTileCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void metroTileOK_Click(object sender, EventArgs e)
        {
            newFn = this.metroTextBoxNew.Text;
            if (newFn.Length == 0 || newFn == orginalFn)
            {
                MetroMessageBox.Show(this,"You must input a new file name or cancel rename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {
            this.metroTextBoxNew.Text = orginalFn;
            this.metroTextBoxOld.Text = orginalFn;
        }
    }
}
