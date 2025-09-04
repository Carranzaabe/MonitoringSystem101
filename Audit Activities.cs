using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MonitoringSystem101
{
    public partial class AuditActivitiesForm : Form
    {
        // Change this to your DB connection string
        string connectionString = @"Data Source=CHOPPCHOP\SQLEXPRESS;Initial Catalog=Loginapp;Integrated Security=True";
        public AuditActivitiesForm()
        {
            InitializeComponent();

            // Configure the DateTimePicker for Month-Year only
            AuditDateTimePicker.Format = DateTimePickerFormat.Custom;
            AuditDateTimePicker.CustomFormat = "MMMM yyyy";

            // Auto-load when date changes
            AuditDateTimePicker.ValueChanged += AuditDateTimePicker_ValueChanged;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void Audit_Activities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginappDataSet2.Manipulation' table. You can move, or remove it, as needed.
            this.manipulationTableAdapter.Fill(this.loginappDataSet2.Manipulation);
            // TODO: This line of code loads data into the 'loginappDataSet2.Manipulation' table. You can move, or remove it, as needed.
            this.manipulationTableAdapter.Fill(this.loginappDataSet2.Manipulation);


        }

        private void AuditDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAuditData();
        }

        private void LoadAuditData()
        {
            try
            {
                // Get first and last day of selected month
                DateTime firstDay = new DateTime(AuditDateTimePicker.Value.Year, AuditDateTimePicker.Value.Month, 1);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT AuditActivities, DateTimeline
                                     FROM AuditCycle
                                     WHERE DateTimeline BETWEEN @StartDate AND @EndDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", firstDay);
                        cmd.Parameters.AddWithValue("@EndDate", lastDay);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Show results in DataGridView
                        AuditDataGrid.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
