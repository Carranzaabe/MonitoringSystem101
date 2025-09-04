using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Security.Cryptography;
// Note: Ensure you have the necessary using directives for your project.

namespace MonitoringSystem101
{

    public partial class LogInForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LogInForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LogInForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //
            SqlConnection connection = new SqlConnection("Data Source = CHOPPCHOP\\SQLEXPRESS; Initial Catalog = Loginapp; Integrated Security = True");
            connection.Open();
            String query = "SELECT COUNT (*) FROM Loginapp WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();
            if (count > 0)
            {
                this.Hide();
                HomeForm2 nextForm = new HomeForm2();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, You Failed:<");
            }
        }
    }
}
