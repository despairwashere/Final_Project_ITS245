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
        public Family_History_Form()
        {
            InitializeComponent();
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

            AliveTB.Enabled = false;
            AliveTB.BackColor = Color.LightGray;

            LiveswithPatientTB.Enabled = false;
            LiveswithPatientTB.BackColor = Color.LightGray;

            MajorDisordersTB.Enabled = false;
            MajorDisordersTB.BackColor = Color.LightGray;

            SpecificDisorderTypeTB.Enabled = false;
            SpecificDisorderTypeTB.BackColor = Color.LightGray;

            RecordDeletedTB.Enabled = false;
            RecordDeletedTB.BackColor = Color.LightGray;

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

            AliveTB.Enabled = true;
            AliveTB.BackColor = Color.White;

            LiveswithPatientTB.Enabled = true;
            LiveswithPatientTB.BackColor = Color.White;

            MajorDisordersTB.Enabled = true;
            MajorDisordersTB.BackColor = Color.White;

            SpecificDisorderTypeTB.Enabled = true;
            SpecificDisorderTypeTB.BackColor = Color.White;

            RecordDeletedTB.Enabled = true;
            RecordDeletedTB.BackColor = Color.White;

        }

        private void Family_History_Form_Load(object sender, EventArgs e)
        {
            SetViewMode();
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
            SetViewMode();
        }

        private void GoToGenMedicalHistoryBT_Click(object sender, EventArgs e)
        {
            Form Gen_Medical_History = new GMH();
            Gen_Medical_History.Show();
            this.Hide();
        }

        private void GoToLoginPageBT_Click(object sender, EventArgs e)
        {
            Form Login = new Login_Form();
            Login.Show();
            this.Hide();
        }
    }
}
