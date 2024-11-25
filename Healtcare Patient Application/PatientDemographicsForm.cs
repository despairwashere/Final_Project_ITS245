using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Example:
            string query = "INSERT INTO patientdemographics (firstName, middleName, lastName, gender, dateOfBirth, ssn, phoneNumber, emailAddress, address, city, state, zipCode, emergencyContactName, emergencyContactRelationship, emergencyContactPhone, insuranceProvider, policyNumber, groupNumber, allergies, medications, medicalConditions) VALUES (@firstName, @middleName, @lastName, @gender, @dateOfBirth, @ssn, @phoneNumber, @emailAddress, @address, @city, @state, @zipCode, @emergencyContactName, @emergencyContactRelationship, @emergencyContactPhone, @insuranceProvider, @policyNumber, @groupNumber, @allergies, @medications, @medicalConditions)";
            // Use parameters to avoid SQL injection
        }
    }
}
