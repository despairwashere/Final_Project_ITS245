using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healtcare_Patient_Application.DataOperations;
using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;

namespace Healtcare_Patient_Application
{
    public partial class PatientSelectionForm : Form
    {
        private int patientId;
        private string patientName;
        private string patientAge;


        public PatientSelectionForm()
        {
            InitializeComponent();
        }

        private void btnGoToDemographics_Click(object sender, EventArgs e)
        {
            int patientId = GetSelectedPatientId();
            if (patientId == -1)
            {
                // Navigate to PatientDemographicsForm
                PatientDemographicsForm demographicsForm = new PatientDemographicsForm(patientId);
                demographicsForm.Show();
                this.Hide();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitToLogin_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();

                // Create an instance of LoginForm
                Login_Form loginForm = new Login_Form();

                // Show the LoginForm
                loginForm.Show();

                // Optionally, close the current form if it's no longer needed
                // this.Close();
            }
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
                using (MySqlConnection conn = GMHDBOperations.MakeConnection())
                {
                    
                    string query = "SELECT PatientID, PtLastName, PtFirstName, PtHomePhone, DOB FROM patientdemographics";
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

                        if (dataGridViewPatients.Columns["DOB"] != null)
                        {
                            dataGridViewPatients.Columns["DOB"].Visible = false;
                        }



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
            patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

            // Example: You can store the selected patient ID for use in another form (e.g., Patient Demographics)
            PatientDemographicsForm demographicsForm = new PatientDemographicsForm(patientId);
            demographicsForm.Show();
            this.Hide(); // Hide the current form (optional)
        }

        private void PatientSelectionForm_Load_1(object sender, EventArgs e)
        {
             // Call the code to populate the DataGridView
        }

        private void GoToAllergyFormBT_Click(object sender, EventArgs e)
        {


            StorePatientDetails();
            AllergyHistoryForm allergyform = new AllergyHistoryForm(patientId, patientName, patientAge);   
            allergyform.Show();
            this.Hide();
        }

        private void StorePatientDetails()
        {
            if (dataGridViewPatients.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewPatients.SelectedRows[0];

                patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                // Get FirstName and LastName
                string firstName = selectedRow.Cells["PtFirstName"].Value.ToString();
                string lastName = selectedRow.Cells["PtLastName"].Value.ToString();

                // Concatenate to form the full name
                patientName = $"{firstName} {lastName}";

                // Get DOB and calculate age
                DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                int age = CalculateAge(dob);
                patientAge = age.ToString();

                
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }

        private int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            // Adjust if the birth date hasn't occurred yet this year
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void GoToGMHBT_Click(object sender, EventArgs e)
        {
            StorePatientDetails();
            GMH form = new GMH();
            form.PatientID = Convert.ToString(patientId);
            form.PatientName = patientName;
            form.PatientAge = patientAge;
            form.Show(); 
            this.Hide();

        }

        private void GoToFamilyHistoryBT_Click(object sender, EventArgs e)
        {
            StorePatientDetails();
            Family_History_Form form = new Family_History_Form();
            form.PatientIDFB = Convert.ToString(patientId);
            form.PatientNameFB = patientName;
            form.PatientAgeFB = patientAge;
            form.Show();
            this.Hide();
        } 
    }
}
