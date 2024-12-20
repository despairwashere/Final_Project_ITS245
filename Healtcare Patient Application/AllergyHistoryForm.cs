﻿using Healtcare_Patient_Application.DataOperations;
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
    public partial class AllergyHistoryForm : Form
    {
        public string Allergen
        {
            get { return txtAllergen_Text.Text; }
            set { txtAllergen_Text.Text = value; }
        }

        public string Allergy_Description
        {
            get { return txtAllergyDescription_Text.Text; }
            set { txtAllergyDescription_Text.Text = value; }
        }

        public DateTime AllergyStartDate
        {
            get { return AllergyStartDateDTP.Value; }
            set { AllergyStartDateDTP.Value = value; }
        }

        public string AllergyEndDate
        {
            get { return txtAllergyEndDate.Text; }
            set { txtAllergyEndDate.Text = value; }
        }

        public bool Deleted
        {
            get { return deletedCB.Checked; }
            set { deletedCB.Checked = value; }
        }

        public int PatientIDAllergy { get; set; }
        public int AllergyID {  get; set; }


        private int allergyID;


        public AllergyHistoryForm(int patientID, string patientName, string patientAge)
        {
            InitializeComponent();
            LogAccessForm.FormAccessLogger.LogFormAccess(LoginSession.GlobalSession.LoginID, "Allergy History Form");
            this.PatientIDAllergy = patientID;
            PatientNameLB.Text = patientName;
            PatientAgeLB.Text = patientAge;
            
           
        }

        private void AllergyHistoryForm_Load(object sender, EventArgs e)
        {
            SetViewMode();
            LoadAllergyHistory();
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row.
                DataGridViewRow row = allergydatagridview.Rows[e.RowIndex];


                txtAllergen_Text.Text = row.Cells["Allergen"].Value.ToString();
                txtAllergyDescription_Text.Text = row.Cells["AllergyDescription"].Value.ToString();
                AllergyStartDateDTP.Value = Convert.ToDateTime(row.Cells["AllergyStartDate"].Value);
                txtAllergyEndDate.Text = row.Cells["AllergyEndDate"].Value.ToString();

                allergyID = Convert.ToInt32(row.Cells["AllergyID"].Value);

                AllergyID = allergyID;

                              
            }

        }

        private void LoadAllergyHistory()
        {
            DataTable allergyHistory = AllergyDBOperations.LoadAllergyHistoryRecords(this);

           

            // Set the DataGridView's data source
            allergydatagridview.DataSource = allergyHistory;

            // Ensure DataGridView contains the columns before hiding
            if (allergydatagridview.Columns.Contains("AllergyStartDate"))
            {
                allergydatagridview.Columns["AllergyStartDate"].Visible = false;
            }

            
            if (allergydatagridview.Columns["Allergen"] != null)
                allergydatagridview.Columns["Allergen"].HeaderText = "Allergen";
                allergydatagridview.Columns["Allergen"].ReadOnly = true;

            // Hide "Age" column if it exists
            if (allergydatagridview.Columns.Contains("AllergyEndDate"))
                allergydatagridview.Columns["AllergyEndDate"].Visible = false;

            if (allergydatagridview.Columns.Contains("AllergyID"))
                allergydatagridview.Columns["AllergyID"].Visible = false;

            if (allergydatagridview.Columns.Contains("AllergyDescription"))
                allergydatagridview.Columns["AllergyDescription"].Visible = false;

            




        }

        private void AllergyEndDateLB_Click(object sender, EventArgs e)
        {

        }

        private void SaveAllergyRecordBT_Click(object sender, EventArgs e)
        {
            if (Add_New_Rec == true)
            {
                try
                {
                    AllergyDBOperations.AddAllergyHistory(this);
                    LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User saved a new allergy history record");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding record: {ex.Message}");

                }

            }
            else
            {
                try
                {
                    AllergyDBOperations.UpdateAllergyHistory(this);
                    LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User modified a allergy history record.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating record: {ex.Message}");
                }


            }

            SetViewMode();
            LoadAllergyHistory();



        }


        private bool Add_New_Rec = false;
        private void AllergyAddBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = true;
            SetEditMode();
            LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User clicked on the Add Button");

        }

        private void ModifyAllergyRecordBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = false;
            SetEditMode();
            LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User clicked on the Modify Button");

        }

        private void AllergyUndoBT_Click(object sender, EventArgs e)
        {
            if (originalValues.Count == 4)
            {
                txtAllergen_Text.Text = originalValues[0];
                txtAllergyDescription_Text.Text = originalValues[1];
                AllergyStartDateDTP.Value = DateTime.Parse(originalValues[2]);
                txtAllergyEndDate.Text = originalValues[3];
               
            }
            else
            {
                MessageBox.Show("No changes to undo.");
            }

            LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User clicked on the UnDo Button");

        }

        private void DeleteAllergyRecordBT_Click(object sender, EventArgs e)
        {
            if (deletedCB.Checked)
            {
                AllergyDBOperations.DeleteAllergyHistoryInfo(this);
                SetViewMode();
                LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "Allergy History Form",
                "User deleted a Allergy History Record");
            }
            else
            {
                MessageBox.Show("Allergy record was not deleted.");
                SetViewMode();
            }

        }

        private void SetViewMode()
        {


            txtAllergen_Text.Enabled = false;
            txtAllergen_Text.BackColor = Color.LightGray;
            txtAllergen_Text.Clear();

            AllergyStartDateDTP.Enabled = false;
            AllergyStartDateDTP.BackColor = Color.LightGray;
            AllergyStartDateDTP.Value = DateTime.Now;

            txtAllergyEndDate.Enabled = false;
            txtAllergyEndDate.BackColor = Color.LightGray;
            txtAllergyEndDate.Clear();

            txtAllergyDescription_Text.Enabled = false;
            txtAllergyDescription_Text.BackColor = Color.LightGray;
            txtAllergyDescription_Text.Clear();

          
            deletedCB.Enabled = false;
            deletedCB.BackColor = Color.LightGray;
            deletedCB.Checked = false;

        }

        private void SetEditMode()
        {


            txtAllergen_Text.Enabled = true;
            txtAllergen_Text.BackColor = Color.White;
            

            AllergyStartDateDTP.Enabled = true;
            AllergyStartDateDTP.BackColor = Color.White;
            

            txtAllergyEndDate.Enabled = true;
            txtAllergyEndDate.BackColor = Color.White;
            

            txtAllergyDescription_Text.Enabled = true;
            txtAllergyDescription_Text.BackColor = Color.White;
            


            deletedCB.Enabled = true;
            deletedCB.BackColor = Color.White;
            

        }

        private List<string> originalValues = new List<string>();

        private void StoreOriginalValues()
        {
            originalValues.Clear();
            originalValues.Add(txtAllergen_Text.Text);
            originalValues.Add(txtAllergyDescription_Text.Text);
            originalValues.Add(Convert.ToString(AllergyStartDateDTP.Value));
            originalValues.Add(txtAllergyEndDate.Text);



        }

        private void BackToPatientSelectionBT_Click(object sender, EventArgs e)
        {
            PatientSelectionForm selectionForm = new PatientSelectionForm();

            // Show the previous form
            selectionForm.Show();

            // Close or hide the current form
            this.Close();
        }

        private void txtAllergen_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPatientDemographics_Click(object sender, EventArgs e)
        {
            int patientID = PatientIDAllergy;
            PatientDemographicsForm form = new PatientDemographicsForm(patientID);
            form.Show();
            this.Hide();

        }

        private void btnGeneralMedicalHistory_Click(object sender, EventArgs e)
        {
            
            GMH form = new GMH();
            form.PatientID = Convert.ToString(PatientIDAllergy);
            form.PatientName = $"{ PatientNameLB.Text}";
            form.PatientAge = $"{PatientAgeLB.Text}";
            form.Show();
            this.Hide();
        }

        private void btnFamilyHistory_Click(object sender, EventArgs e)
        {
            Family_History_Form form = new Family_History_Form();
            form.PatientIDFB = Convert.ToString(PatientIDAllergy);
            form.PatientNameFB = $"{PatientNameLB.Text}";
            form.PatientAgeFB = $"{PatientAgeLB.Text}";
            form.Show();
            this.Hide();
        }
    }
}
