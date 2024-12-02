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
using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;

namespace Healtcare_Patient_Application
{
    public partial class PatientDemographicsForm : Form
    {
        private int? _patientId = null;


        public PatientDemographicsForm(int? patientId = null)
        {
            InitializeComponent();
            this._patientId = patientId;

            if (patientId.HasValue)
            {
                LoadPatientData(patientId.Value);
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
                                MessageBox.Show("To Enter new patient data, click ok.");
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
            string emergencyContactPhone = txtEmergencyContactPhone.Text;
            string suffix=txtSuffix.Text;
            string country=txtCountry.Text;
            string citizenship=txtCitizenship.Text;
            string ethnicAssociation=txtEthnicAssociation.Text;
            string religion=txtReligion.Text;
            string currentPrimaryHCPId=txtCurrentPrimaryHCPId.Text;
            string dateOfExpire=txtDateOfExpire.Text;
            string comments=txtComments.Text;
            string nextOfKin=txtNextOfKin.Text;
            string nextOfKinRelationshipToPatient=txtNextOfKinRelationshipToPatient.Text;
            string employmentStatus=txtEmploymentStatus.Text;
            string maritalStatus=txtMaritalStatus.Text;
            string previousLastName=txtPreviousLastName.Text;
            string referral=txtReferral.Text;
            DateTime dateEntered=dtpDateEntered.Value;
            string hospitalMR=txtHospitalMR.Text;

            
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
                string emergencyContactPhone = txtEmergencyContactPhone.Text;
                string suffix = txtSuffix.Text;
                string country = txtCountry.Text;
                string citizenship = txtCitizenship.Text;
                string ethnicAssociation = txtEthnicAssociation.Text;
                string religion = txtReligion.Text;
                string currentPrimaryHCPId = txtCurrentPrimaryHCPId.Text;
                string dateOfExpire = txtDateOfExpire.Text;
                string comments = txtComments.Text;
                string nextOfKin = txtNextOfKin.Text;
                string nextOfKinRelationshipToPatient = txtNextOfKinRelationshipToPatient.Text;
                string employmentStatus = txtEmploymentStatus.Text;
                string maritalStatus = txtMaritalStatus.Text;
                string previousLastName = txtPreviousLastName.Text;
                string referral = txtReferral.Text;
                DateTime dateEntered = dtpDateEntered.Value;
                string hospitalMR = txtHospitalMR.Text;

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
                    // Check the Patient Demographics table for the correct column names
                    query = @"UPDATE patientdemographics 
                      SET firstName = @PtFirstName, middleName = @PtMiddleIntitial, lastName = @PtLastName, previousLastName=@PreviousLastName, gender = @Gender, suffix=@Suffix, country=@Country, 
                          dateOfBirth = @DOB, ssn = @SSN, phoneNumber = @PtHomePhone, emailAddress = @EmailAddress,
                          address = @HomeAddress, city = @HomeCity, state = @HomeState/Province/Region, zipCode = @HomeZip, hosptialMR=@HospitalMR#, 
                          emergencyContactPhone = @EmergencyPhoneNumber, citizenship=@Cititzenship, ethnicAssociation=@EthnicAssociation, religion=@Religion, maritalStatus=@MaritalStatus,
                          employmentStatus=@EmploymentStatus, dateOfExpire=@DateOfExpire, referral=@Referral, currentPrimartyHCPId=@CurrentPrimaryHCPId, comments=@Comments, dateEntered=@DateEntered,
                          nextOfKin=@NextOfKinID, nextOfKinRelationshipToPatient=@NextOfKinRelationshipToPatient
                      WHERE patientId = @patientId";
                }
                else
                {
                    // Insert new patient record
                    query = @"INSERT INTO patientdemographics 
                      (firstName, middleName, lastName, previousLastName, gender, suffix, country, citizenship, dateOfBirth, ssn, phoneNumber, emailAddress, 
                       address, city, state, zipCode,emergencyContactPhone, ethnicAssociation, religion, maritalStatus, employmentStatus, dateOfExpire, referral, currentPrimaryHCPId, comments, dateEntered,
                       nextOfKin, nextOfKinRelationshipToPatient) 
                      VALUES (@PtFirstName, @PtMiddleInitial, @PtLastName,@PtPreviousLastName, @Gender, @Suffix, @Country, @Citizenship, @DOB, @SSN, @PtHomePhone,@EmailAddress,
                              @HomeAddress, @HomeCity, @HomeState/Province/Region, @HomeZip, @EmergencyPhoneNumber, @EthnicAssociation, @Religion, @MaritalStatus, @EmploymentStatus, @DateOfExpire, @Referral, @CurrentPrimaryHCPId,
                               @Comments, @DateEntered, @NextOfKinID, @NextOfKinRelationshipToPatient)";
                }

                // Create the SQL Command
                using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Port=3306;Database=healthcareapplication;Uid=root;Pwd=password;"))
                {
                    
                    cmd = new SqlCommand(query, conn);

                    // Add parameters to the query (same for insert and update)
                    cmd.Parameters.AddWithValue("@PtFirstName", firstName);
                    cmd.Parameters.AddWithValue("@PtMiddleInitial", middleName);
                    cmd.Parameters.AddWithValue("@PtLastName", lastName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dateOfBirth);
                    cmd.Parameters.AddWithValue("@SSN", ssn);
                    cmd.Parameters.AddWithValue("@PtHomePhone", phoneNumber);
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    cmd.Parameters.AddWithValue("@HomeAddress", address);
                    cmd.Parameters.AddWithValue("@HomeCity", city);
                    cmd.Parameters.AddWithValue("@HomeState/Province/Region", state);
                    cmd.Parameters.AddWithValue("@HomeZip", zipCode);
                    cmd.Parameters.AddWithValue("@EmergencyPhoneNumber", emergencyContactPhone);
                    cmd.Parameters.AddWithValue("@PtPreviousLastName", previousLastName);
                    cmd.Parameters.AddWithValue("@Suffix", suffix);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Citizenship", citizenship);
                    cmd.Parameters.AddWithValue("@EthnicAssociation", ethnicAssociation);
                    cmd.Parameters.AddWithValue("@Religion", religion);
                    cmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                    cmd.Parameters.AddWithValue("@EmploymentStatus", employmentStatus);
                    cmd.Parameters.AddWithValue("@DateOfExpire", dateOfExpire);
                    cmd.Parameters.AddWithValue("@Referral", referral);
                    cmd.Parameters.AddWithValue("@CurrentPrimaryHCPId", currentPrimaryHCPId);
                    cmd.Parameters.AddWithValue("@DateEntered", dateEntered);
                    cmd.Parameters.AddWithValue("@NextOfKinID", nextOfKin);
                    cmd.Parameters.AddWithValue("@NextOfKinRelationshipToPatient", nextOfKinRelationshipToPatient);
                    cmd.Parameters.AddWithValue("@Comments", comments);

                   

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
            StorePatientDetails();
            AllergyHistoryForm allergyform = new AllergyHistoryForm(patientId, patientName, patientAge);
            allergyform.Show();
            this.Hide();
        }
    }
}
