using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Healtcare_Patient_Application
{
    public partial class PatientDemographicsForm : Form
    {
        public PatientDemographicsForm(int patientId)
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the previous form (e.g., MainForm or PatientSelectionForm)
            PatientSelectionForm selectionForm = new PatientSelectionForm();

            // Show the previous form
            selectionForm.Show();

            // Close or hide the current form
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collecting data from the controls
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string gender = cboGender.SelectedItem.ToString();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string ssn = txtSSN.Text;

            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmailAddress.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = cboState.SelectedItem.ToString();
            string zipCode = txtZipCode.Text;

            string emergencyContactName = txtEmergencyContactName.Text;
            string emergencyContactRelationship = txtEmergencyContactRelationship.Text;
            string emergencyContactPhone = txtEmergencyContactPhone.Text;

            string insuranceProvider = txtInsuranceProvider.Text;
            string policyNumber = txtPolicyNumber.Text;
            string groupNumber = txtGroupNumber.Text;

            string allergies = txtAllergies.Text;
            string medications = txtMedications.Text;
            string medicalConditions = txtMedicalConditions.Text;

            // Now, insert the data into the database (SQL code)
            string query = "INSERT INTO patientdemographics (firstName, middleName, lastName, gender, dateOfBirth, ssn, phoneNumber, emailAddress, address, city, state, zipCode, emergencyContactName, emergencyContactRelationship, emergencyContactPhone, insuranceProvider, policyNumber, groupNumber, allergies, medications, medicalConditions) VALUES (@firstName, @middleName, @lastName, @gender, @dateOfBirth, @ssn, @phoneNumber, @emailAddress, @address, @city, @state, @zipCode, @emergencyContactName, @emergencyContactRelationship, @emergencyContactPhone, @insuranceProvider, @policyNumber, @groupNumber, @allergies, @medications, @medicalConditions)";
            // Use parameters to avoid SQL injection
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect the data from the form controls
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;
                string gender = cboGender.SelectedItem.ToString();
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string ssn = txtSSN.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmailAddress.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string state = cboState.SelectedItem.ToString();
                string zipCode = txtZipCode.Text;
                string emergencyContactName = txtEmergencyContactName.Text;
                string emergencyContactRelationship = txtEmergencyContactRelationship.Text;
                string emergencyContactPhone = txtEmergencyContactPhone.Text;
                string insuranceProvider = txtInsuranceProvider.Text;
                string policyNumber = txtPolicyNumber.Text;
                string groupNumber = txtGroupNumber.Text;
                string allergies = txtAllergies.Text;
                string medications = txtMedications.Text;
                string medicalConditions = txtMedicalConditions.Text;

                // Check if PatientID exists (assuming it's either a TextBox or a hidden field)
                int patientId;
                bool isEdit = int.TryParse(txtPatientID.Text, out patientId);  // Assuming the PatientID is being passed for edit

                // Determine the SQL query based on whether it's an insert or update
                string query;
                SqlCommand cmd;

                // Check if the PatientID exists for updating or inserting new record
                if (isEdit)
                {
                    // Update existing patient record
                    query = @"UPDATE patientdemographics 
                      SET firstName = @firstName, middleName = @middleName, lastName = @lastName, gender = @gender,
                          dateOfBirth = @dateOfBirth, ssn = @ssn, phoneNumber = @phoneNumber, emailAddress = @emailAddress,
                          address = @address, city = @city, state = @state, zipCode = @zipCode,
                          emergencyContactName = @emergencyContactName, emergencyContactRelationship = @emergencyContactRelationship,
                          emergencyContactPhone = @emergencyContactPhone, insuranceProvider = @insuranceProvider,
                          policyNumber = @policyNumber, groupNumber = @groupNumber, allergies = @allergies,
                          medications = @medications, medicalConditions = @medicalConditions
                      WHERE patientId = @patientId";
                }
                else
                {
                    // Insert new patient record
                    query = @"INSERT INTO patientdemographics 
                      (firstName, middleName, lastName, gender, dateOfBirth, ssn, phoneNumber, emailAddress, 
                       address, city, state, zipCode, emergencyContactName, emergencyContactRelationship, 
                       emergencyContactPhone, insuranceProvider, policyNumber, groupNumber, allergies, 
                       medications, medicalConditions) 
                      VALUES (@firstName, @middleName, @lastName, @gender, @dateOfBirth, @ssn, @phoneNumber, 
                              @emailAddress, @address, @city, @state, @zipCode, @emergencyContactName, 
                              @emergencyContactRelationship, @emergencyContactPhone, @insuranceProvider, 
                              @policyNumber, @groupNumber, @allergies, @medications, @medicalConditions)";
                }

                // Create the SQL Command
                using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Port=3306;Database=healthcareapplication;Uid=root;Pwd=password;"))
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);

                    // Add parameters to the query (same for insert and update)
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@middleName", middleName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@ssn", ssn);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@emailAddress", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@zipCode", zipCode);
                    cmd.Parameters.AddWithValue("@emergencyContactName", emergencyContactName);
                    cmd.Parameters.AddWithValue("@emergencyContactRelationship", emergencyContactRelationship);
                    cmd.Parameters.AddWithValue("@emergencyContactPhone", emergencyContactPhone);
                    cmd.Parameters.AddWithValue("@insuranceProvider", insuranceProvider);
                    cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
                    cmd.Parameters.AddWithValue("@groupNumber", groupNumber);
                    cmd.Parameters.AddWithValue("@allergies", allergies);
                    cmd.Parameters.AddWithValue("@medications", medications);
                    cmd.Parameters.AddWithValue("@medicalConditions", medicalConditions);

                    if (isEdit)
                    {
                        // If updating an existing record, also add the PatientID to the parameters
                        cmd.Parameters.AddWithValue("@patientId", patientId);
                    }

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                // Show a message indicating success
                if (isEdit)
                {
                    MessageBox.Show("Patient record updated successfully.");
                }
                else
                {
                    MessageBox.Show("New patient record added successfully.");
                }

                // Optionally, clear fields after the operation
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Helper method to clear form fields (optional)
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            cboGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Now;
            txtSSN.Clear();
            txtPhoneNumber.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cboState.SelectedIndex = -1;
            txtZipCode.Clear();
            txtEmergencyContactName.Clear();
            txtEmergencyContactRelationship.Clear();
            txtEmergencyContactPhone.Clear();
            txtInsuranceProvider.Clear();
            txtPolicyNumber.Clear();
            txtGroupNumber.Clear();
            txtAllergies.Clear();
            txtMedications.Clear();
            txtMedicalConditions.Clear();
            txtPatientID.Clear();  // Clear PatientID for new records
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that the PatientID is provided
                int patientId;
                if (int.TryParse(txtPatientID.Text, out patientId))
                {
                    // Confirm the deletion with the user
                    DialogResult dialogResult = MessageBox.Show(
                        "Are you sure you want to delete this patient record?",
                        "Delete Record",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Set up the DELETE SQL query
                        string query = "DELETE FROM patientdemographics WHERE patientId = @patientId";

                        // Execute the query
                        using (SqlConnection conn = new SqlConnection("your_connection_string"))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Add the PatientID as a parameter to the SQL command
                                cmd.Parameters.AddWithValue("@patientId", patientId);

                                // Execute the DELETE query
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Check if any rows were affected (i.e., if the record was found and deleted)
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Patient record deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("No record found for the provided PatientID.");
                                }
                            }
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid PatientID to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
