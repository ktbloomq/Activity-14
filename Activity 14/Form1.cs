using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reasonList.SelectedIndex = 2;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if(uninstall.Checked)
            {
                MessageBox.Show("Uninstalled. Reason: " + reasonList.SelectedItem);
            }
            if (reinstall.Checked)
            {
                MessageBox.Show("Reinstalled.");
            }
        }

        private void confirm_CheckedChanged(object sender, EventArgs e)
        {
            if (confirm.Checked)
            {
                Continue.Enabled = true;
            } else 
            { 
                Continue.Enabled = false; 
            }
        }
    }
}
