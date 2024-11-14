﻿using System;
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
