﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;

namespace Healtcare_Patient_Application
{
    public partial class PatientDemographicsForm : Form
    {
        private int? _patientId = null;
        private bool _isViewMode = false; // Indicates if the form is in View mode
        private bool _isModifyMode = false; // Indicates if the form is in Modify mode
        private string patientName;
        private string patientAge;



        public PatientDemographicsForm(int? patientId = null, bool isViewMode = false, bool isModifyMode = false)
        {
            InitializeComponent();
            this._patientId = patientId;
            this._isViewMode = isViewMode;
            this._isModifyMode = isModifyMode;
            

            // Configure the form based on initial mode
            ConfigureFormMode();

            if (patientId.HasValue)
            {
                LoadPatientData(patientId.Value);
            }
        }
        private void ConfigureFormMode()
        {
            if (_isViewMode)
            {
                SetControlsReadOnly(true); // Disable editing
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnModify.Enabled = true; // Enable Modify button
            }
            else if (_isModifyMode)
            {
                SetControlsReadOnly(false); // Enable editing
                txtPatientID.ReadOnly = true; // Prevent changes to Patient ID
                btnAdd.Enabled = false; // Prevent adding new records in Modify mode
                btnSave.Enabled = true; // Enable save
            }
        }
        private void SetControlsReadOnly(bool isReadOnly)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = isReadOnly;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = !isReadOnly;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = !isReadOnly;
                }
            }
        }
        private void LoadPatientData(int patientId)
        {
            try
            {
                // Define the SQL query to retrieve patient data based on the patientId
                string query = "SELECT * FROM patientdemographics WHERE patientId = @patientId";

                using (MySqlConnection connection = GMHDBOperations.MakeConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);

                        // Execute the query and get a data reader
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the form fields with the retrieved data
                                txtPatientID.Text = reader["patientId"].ToString();
                                txtFirstName.Text = reader["PtFirstName"].ToString();
                                txtMiddleName.Text = reader["PtMiddleInitial"].ToString();
                                txtLastName.Text = reader["PtLastName"].ToString(); 
                                cboGender.SelectedItem = reader["Gender"].ToString();
                                dtpDateOfBirth.Value = Convert.ToDateTime(reader["DOB"]);
                                txtSSN.Text = reader["SSN"].ToString();
                                txtPhoneNumber.Text = reader["PtHomePhone"].ToString();
                                txtEmailAddress.Text = reader["EmailAddress"].ToString();
                                txtAddress.Text = reader["HomeAddress"].ToString();
                                txtCity.Text = reader["HomeCity"].ToString();
                                cboState.SelectedItem = reader["HomeState/Province/Region"].ToString();
                                txtZipCode.Text = reader["HomeZip"].ToString();
                                txtPreviousLastName.Text = reader["PtPreviousLastName"].ToString() ;
                                txtSuffix.Text = reader["Suffix"].ToString();
                                txtCountry.Text = reader["Country"].ToString();
                                txtCitizenship.Text = reader["Citizenship"].ToString();
                                txtEthnicAssociation.Text = reader["EthnicAssociation"].ToString();
                                txtReligion.Text = reader["Religion"].ToString();
                                txtMaritalStatus.Text = reader["MaritalStatus"].ToString();
                                txtEmploymentStatus.Text = reader["EmploymentStatus"].ToString();
                                txtDateOfExpire.Text = reader["DateofExpire"].ToString();
                                txtReferral.Text = reader["Referral"].ToString();
                                txtNextOfKin.Text = reader["NextOfKinID"].ToString();
                                txtNextOfKinRelationshipToPatient.Text = reader["NextOfKinRelationshipToPatient"].ToString();
                                txtCurrentPrimaryHCPId.Text = reader["CurrentPrimaryHCPId"].ToString();
                                dtpDateEntered.Value = Convert.ToDateTime(reader["DateEntered"]);
                                txtComments.Text = reader["Comments"].ToString();
                                txtEmergencyContactPhone.Text = reader["EmergencyPhoneNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No patient data found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient data: {ex.Message}");
            }
        }
      
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Enable Modify mode dynamically
            _isModifyMode = true;
            _isViewMode = false;

            // Reconfigure the form
            ConfigureFormMode();

            MessageBox.Show("You can now modify and add new fields.");
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
            try
            {
                using (MySqlConnection connection = GMHDBOperations.MakeConnection())
                {
                    if (_isModifyMode) // Handle updates
                    {
                        string query = @"
                    UPDATE patientdemographics 
                    SET PtFirstName = @PtFirstName, PtMiddleInitial = @PtMiddleInitial, PtLastName = @PtLastName, 
                        Gender = @Gender, DOB = @DOB, SSN = @SSN, PtHomePhone = @PtHomePhone, 
                        EmailAddress = @EmailAddress, HomeAddress = @HomeAddress, HomeCity = @HomeCity, 
                        `HomeState/Province/Region` = @HomeState, HomeZip = @HomeZip, 
                        PtPreviousLastName = @PtPreviousLastName, Suffix = @Suffix, Country = @Country, 
                        Citizenship = @Citizenship, EthnicAssociation = @EthnicAssociation, Religion = @Religion, 
                        MaritalStatus = @MaritalStatus, EmploymentStatus = @EmploymentStatus, 
                        DateofExpire = @DateofExpire, Referral = @Referral, NextOfKinID = @NextOfKinID, 
                        NextOfKinRelationshipToPatient = @NextOfKinRelationship, CurrentPrimaryHCPId = @HCPId, 
                        DateEntered = @DateEntered, Comments = @Comments, EmergencyPhoneNumber = @EmergencyPhone 
                    WHERE patientId = @PatientID";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            AddPatientParameters(cmd); // Method to add parameters from form fields
                            cmd.Parameters.AddWithValue("@PatientID", _patientId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Patient record updated successfully.");
                        }
                    }
                    else // Handle new record insertions
                    {
                        string query = @"
                    INSERT INTO patientdemographics (
                        PtFirstName, PtMiddleInitial, PtLastName, Gender, DOB, SSN, PtHomePhone, 
                        EmailAddress, HomeAddress, HomeCity, `HomeState/Province/Region`, HomeZip, 
                        PtPreviousLastName, Suffix, Country, Citizenship, EthnicAssociation, Religion, 
                        MaritalStatus, EmploymentStatus, DateofExpire, Referral, NextOfKinID, 
                        NextOfKinRelationshipToPatient, CurrentPrimaryHCPId, DateEntered, Comments, 
                        EmergencyPhoneNumber
                    ) 
                    VALUES (
                        @PtFirstName, @PtMiddleInitial, @PtLastName, @Gender, @DOB, @SSN, @PtHomePhone, 
                        @EmailAddress, @HomeAddress, @HomeCity, @HomeState, @HomeZip, @PtPreviousLastName, 
                        @Suffix, @Country, @Citizenship, @EthnicAssociation, @Religion, @MaritalStatus, 
                        @EmploymentStatus, @DateofExpire, @Referral, @NextOfKinID, @NextOfKinRelationship, 
                        @HCPId, @DateEntered, @Comments, @EmergencyPhone)";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            AddPatientParameters(cmd); // Method to add parameters from form fields
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New patient record added successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient data: {ex.Message}");
            }
        }
        private void AddPatientParameters(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@PtFirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@PtMiddleInitial", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("@PtLastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem?.ToString());
            cmd.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value);
            cmd.Parameters.AddWithValue("@SSN", txtSSN.Text);
            cmd.Parameters.AddWithValue("@PtHomePhone", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);
            cmd.Parameters.AddWithValue("@HomeAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@HomeCity", txtCity.Text);
            cmd.Parameters.AddWithValue("@HomeState", cboState.SelectedItem?.ToString());
            cmd.Parameters.AddWithValue("@HomeZip", txtZipCode.Text);
            cmd.Parameters.AddWithValue("@PtPreviousLastName", txtPreviousLastName.Text);
            cmd.Parameters.AddWithValue("@Suffix", txtSuffix.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Citizenship", txtCitizenship.Text);
            cmd.Parameters.AddWithValue("@EthnicAssociation", txtEthnicAssociation.Text);
            cmd.Parameters.AddWithValue("@Religion", txtReligion.Text);
            cmd.Parameters.AddWithValue("@MaritalStatus", txtMaritalStatus.Text);
            cmd.Parameters.AddWithValue("@EmploymentStatus", txtEmploymentStatus.Text);
            cmd.Parameters.AddWithValue("@DateofExpire", txtDateOfExpire.Text);
            cmd.Parameters.AddWithValue("@Referral", txtReferral.Text);
            cmd.Parameters.AddWithValue("@NextOfKinID", txtNextOfKin.Text);
            cmd.Parameters.AddWithValue("@NextOfKinRelationship", txtNextOfKinRelationshipToPatient.Text);
            cmd.Parameters.AddWithValue("@HCPId", txtCurrentPrimaryHCPId.Text);
            cmd.Parameters.AddWithValue("@DateEntered", dtpDateEntered.Value);
            cmd.Parameters.AddWithValue("@Comments", txtComments.Text);
            cmd.Parameters.AddWithValue("@EmergencyPhone", txtEmergencyContactPhone.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _isModifyMode = false; // Set mode to Add
            _isViewMode = false;
            _patientId = null; // Clear any existing patient ID

            ClearFields(); // Reset the form fields for new entry
            SetControlsReadOnly(false); // Enable editing
            txtPatientID.ReadOnly = true; // Prevent manual entry of Patient ID
            MessageBox.Show("Ready to add a new patient record.");
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
            txtEmergencyContactPhone.Clear();
            txtPreviousLastName.Clear();
            txtHospitalMR.Clear();
            txtSuffix.Clear();
            txtCountry.Clear();
            txtCitizenship.Clear();
            txtEthnicAssociation.Clear();
            txtMaritalStatus.Clear();
            txtEmploymentStatus.Clear();
            txtReferral.Clear();
            txtCurrentPrimaryHCPId.Clear();
            txtComments.Clear();
            txtNextOfKin.Clear();
            txtNextOfKinRelationshipToPatient.Clear();
            dtpDateEntered.Value = DateTime.Now;

             // Clear PatientID for new records
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

        private void PatientDemographicsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAllergyRecords_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dtpDateOfBirth.Value;

            // Calculate age in years
            int age = DateTime.Now.Year - dateOfBirth.Year;

            // Adjust if the birthday hasn't occurred yet this year
            if (DateTime.Now < dateOfBirth.AddYears(age))
            {
                age--;
            }
            patientAge = age.ToString();

            patientName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";
            AllergyHistoryForm allergyform = new AllergyHistoryForm(_patientId.Value, patientName, patientAge);
            allergyform.Show();
            this.Hide();
        }

        private void btnGeneralMedical_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dtpDateOfBirth.Value;

            // Calculate age in years
            int age = DateTime.Now.Year - dateOfBirth.Year;

            // Adjust if the birthday hasn't occurred yet this year
            if (DateTime.Now < dateOfBirth.AddYears(age))
            {
                age--;
            }
            patientAge = age.ToString();

            patientName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";
            GMH form = new GMH();
            form.PatientID = Convert.ToString(_patientId.Value);
            form.PatientName = patientName;
            form.PatientAge = patientAge;
            form.Show();
            this.Hide();
        }

        private void btnFamilyHistory_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dtpDateOfBirth.Value;

            // Calculate age in years
            int age = DateTime.Now.Year - dateOfBirth.Year;

            // Adjust if the birthday hasn't occurred yet this year
            if (DateTime.Now < dateOfBirth.AddYears(age))
            {
                age--;
            }
            patientAge = age.ToString();

            patientName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";
            Family_History_Form form = new Family_History_Form();
            form.PatientIDFB = Convert.ToString(_patientId.Value);
            form.PatientNameFB = patientName;
            form.PatientAgeFB = patientAge;
            form.Show();
            this.Hide();
        }
    }
}
