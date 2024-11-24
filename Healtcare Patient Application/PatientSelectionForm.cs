using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Healtcare_Patient_Application
{
    public partial class PatientSelectionForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=healthcareapplication;Uid=root;Pwd=password;";
        public PatientSelectionForm()
        {
            InitializeComponent();
        }

        private void btnGoToDemographics_Click(object sender, EventArgs e)
        {
            int patientId = GetSelectedPatientId();
            if (patientId != -1)
            {
                // Navigate to PatientDemographicsForm
                PatientDemographicsForm demographicsForm = new PatientDemographicsForm(patientId);
                demographicsForm.Show();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitToLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchPatient.Text.Trim();
            LoadPatientData(searchTerm);
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {

        }
        private void PatientSelectionForm_Load(object sender, EventArgs e)
        {
            LoadPatientData(); // Populate the DataGridView on form load
        }

        private void LoadPatientData(string searchTerm = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PatientID, PtLastName, PtFirstName, PtHomePhone FROM patientdemographics";
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " WHERE PtLastName LIKE @SearchTerm OR PatientID LIKE @SearchTerm";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewPatients.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private int GetSelectedPatientId()
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["PatientID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a patient.");
                return -1;
            }
        }


        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient from the list.", "Select Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row's patient ID
            DataGridViewRow selectedRow = dataGridViewPatients.SelectedRows[0];
            int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

            // Example: You can store the selected patient ID for use in another form (e.g., Patient Demographics)
            PatientDemographicsForm demographicsForm = new PatientDemographicsForm(patientId);
            demographicsForm.Show();
            this.Hide(); // Hide the current form (optional)
        }

        private void PatientSelectionForm_Load_1(object sender, EventArgs e)
        {
             // Call the code to populate the DataGridView
        }
    }
}
