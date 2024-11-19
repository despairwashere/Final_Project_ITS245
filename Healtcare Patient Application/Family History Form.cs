using Healtcare_Patient_Application.DataOperations;
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
    public partial class Family_History_Form : Form
    {
        public string FamilyName { get { return FamilyNameTB.Text; } }
        public string Relation { get { return FamilyRelationTB.Text; } }

        public bool Alive { get { return AliveCB.Checked; } }
        public bool LivesWith { get { return LivesWithPatientCB.Checked; } }

        public bool Deleted { get { return deletedCB.Checked; } }

        public string MajorDisorders {  get {  return MajorDisordersTB.Text; } }
        public string SpecificDisorderType { get { return SpecificDisorderTypeTB.Text; } }

        public string PatientNameFB { get; set; }
        public string PatientAgeFB { get; set; }
        public string PatientIDFB { get; set; }



        public Family_History_Form()
        {
            InitializeComponent();
        }

        private void DisplayFamilyData()
        {
            PatientAgeLB.Text = PatientAgeFB;
            PatientNameLB.Text = PatientNameFB;
            
        }

        private void SetViewMode()
        {
            FamilyIDTB.Enabled = false;
            FamilyIDTB.BackColor = Color.LightGray;

            PatientIDTB.Enabled = false;
            PatientIDTB.BackColor = Color.LightGray;

            FamilyNameTB.Enabled = false;
            FamilyNameTB.BackColor = Color.LightGray;

            FamilyRelationTB.Enabled = false;
            FamilyRelationTB.BackColor = Color.LightGray;

            AliveCB.Enabled = false;
            AliveCB.BackColor = Color.LightGray;

            LivesWithPatientCB.Enabled = false;
            LivesWithPatientCB.BackColor = Color.LightGray;

            MajorDisordersTB.Enabled = false;
            MajorDisordersTB.BackColor = Color.LightGray;

            SpecificDisorderTypeTB.Enabled = false;
            SpecificDisorderTypeTB.BackColor = Color.LightGray;

            deletedCB.Enabled = false;
            deletedCB.BackColor = Color.LightGray;

        }

        private void SetEditMode()
        {
            FamilyIDTB.Enabled = true;
            FamilyIDTB.BackColor = Color.White;

            PatientIDTB.Enabled = true;
            PatientIDTB.BackColor = Color.White;

            FamilyNameTB.Enabled = true;
            FamilyNameTB.BackColor = Color.White;

            FamilyRelationTB.Enabled = true;
            FamilyRelationTB.BackColor = Color.White;

            AliveCB.Enabled = true;
            AliveCB.BackColor = Color.White;

            LivesWithPatientCB.Enabled = true;
            LivesWithPatientCB.BackColor = Color.White;

            MajorDisordersTB.Enabled = true;
            MajorDisordersTB.BackColor = Color.White;

            SpecificDisorderTypeTB.Enabled = true;
            SpecificDisorderTypeTB.BackColor = Color.White;

            deletedCB.Enabled = true;
            deletedCB.BackColor = Color.White;

        }

        private void Family_History_Form_Load(object sender, EventArgs e)
        {
            SetViewMode();
            DisplayFamilyData();
        }

        private void PatientName_Click(object sender, EventArgs e)
        {

        }

        private void FamHisAddBT_Click(object sender, EventArgs e)
        {
            SetEditMode();

        }

        private void FamHisModifyBT_Click(object sender, EventArgs e)
        {
            SetEditMode();

        }

        private void FamHisSaveBT_Click(object sender, EventArgs e)
        {
            try
            {
                FHDBOperations.AddFamilyHistory(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }

            SetViewMode();
        }

        private void GoToGenMedicalHistoryBT_Click(object sender, EventArgs e)
        {
            GMH Gen_history = new GMH();
           // Gen_history.PatientName =    // Still working on this part
           //  Gen_history.Show();
            this.Hide();
        }

        private void GoToLoginPageBT_Click(object sender, EventArgs e)
        {
            Form Login = new Login_Form();
            Login.Show();
            this.Hide();
        }

        private void FamHisUndoBT_Click(object sender, EventArgs e)
        {
            UndoChanges();

        }

        private List<string> originalValues = new List<string>();

        private void StoreOriginalValues()
        {
            originalValues.Clear();
            originalValues.Add(FamilyNameTB.Text);
            originalValues.Add(MajorDisordersTB.Text);
            originalValues.Add(SpecificDisorderTypeTB.Text);
            originalValues.Add(FamilyRelationTB.Text);
            originalValues.Add(AliveCB.Checked.ToString());
            originalValues.Add(deletedCB.Checked.ToString());
            originalValues.Add(LivesWithPatientCB.Checked.ToString());

        }

        private void UndoChanges()
        {
            if (originalValues.Count == 7)
            {
                FamilyNameTB.Text = originalValues[0];
                MajorDisordersTB.Text = originalValues[1];
                SpecificDisorderTypeTB.Text = originalValues[2];
                FamilyRelationTB.Text = originalValues[3];
                AliveCB.Checked = bool.Parse(originalValues[4]);
                deletedCB.Checked = bool.Parse(originalValues[5]);
                LivesWithPatientCB.Checked = bool.Parse(originalValues[6]);
            }
            else
            {
                MessageBox.Show("No changes to undo.");
            }

        }
    }
}
