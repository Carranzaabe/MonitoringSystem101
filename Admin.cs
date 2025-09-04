using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystem101
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void AuditLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            System.IO.File.WriteAllText("output.txt", tablePanel.Text);
            System.IO.File.WriteAllText("output.txt", AuditLayoutPanel.Text);
            MessageBox.Show("Saved!");
        }

        private void AuditTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
