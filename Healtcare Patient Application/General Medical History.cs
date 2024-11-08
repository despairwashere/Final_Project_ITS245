using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Patient_Application.DataOperations;

namespace Healtcare_Patient_Application 
{
    public partial class GMH : Form
    {
        //This is to test Git commits


        public string MaritalStatus
        {   get { return MaritalStatusTB.Text; }   } 
        public string EducationLevel { get { return EducationLevelTB.Text; } }

        public string BehavioralHistory { get { return BehavioralHistoryTB.Text; } }

        public string Tobacco { get { return TobaccoTB.Text; } }
        public string TobaccoQuantity {  get { return TobaccoQuanTB.Text; } }
        public string TobaccoDuration { get { return TobaccoDurationTB.Text; } }
        public string Alcohol { get { return DrinkAlcoholTB.Text; } }
        public string AlcoholQuantity { get {  return AlcoholQuanTB.Text; } }
        public string AlcoholDuration { get { return AlcoholDurTB.Text; } }
        public string Drug { get { return DrugTB.Text; } }
        public string DrugType { get { return DrugTypeTB.Text; } }
        public string DrugDuration {  get {  return DrugDurationTB.Text;} }
        public string Dietary {  get {  return DietaryTB.Text; } }
        public string BloodType {  get {  return BloodTypeTB.Text; } }
        public string RH {  get {  return RHTB.Text; } }
        public string LMP {  get {  return LMPTB.Text; } }
        public string NumberOfChildren { get { return NumChildrenTB.Text; } }
        public bool MensesMonthlyYes {  get { return MensesMonthlyYeschoice.Checked; } }
        public bool MensesMonthlyNo {  get { return MensesMonthlyNochoice.Checked; } }
        public string MensesFrequency {  get { return MensesFreqTB.Text; } }
        public string MedicalHistoryNotes {  get { return MedHistoryTB.Text; } }
        public string HX {  get { return HXTB.Text; } }
        public bool IsDeleted {  get { return DeletedCB.Checked; } }


        public GMH()
        {
            InitializeComponent();  // Initialize Components

            MensesMonthlyYeschoice.CheckedChanged += MensesMonthlyOption_CheckedChanged;
            MensesMonthlyNochoice.CheckedChanged += MensesMonthlyOption_CheckedChanged;
        }

        // Public properties to access TextBox and CheckBox values


        private void GMH_Load(object sender, EventArgs e)
        {
            SetViewMode();
        }

        private void SetViewMode()
        {
            TobaccoTB.Enabled = false;
            TobaccoTB.BackColor = Color.LightGray;

            TobaccoDurationTB.Enabled = false;
            TobaccoDurationTB.BackColor = Color.LightGray;

            TobaccoQuanTB.Enabled = false;
            TobaccoQuanTB.BackColor = Color.LightGray;

            DrinkAlcoholTB.Enabled = false;
            DrinkAlcoholTB.BackColor = Color.LightGray;

            AlcoholQuanTB.Enabled = false;
            AlcoholQuanTB.BackColor = Color.LightGray;

            AlcoholDurTB.Enabled = false;
            AlcoholDurTB.BackColor = Color.LightGray;

            DrugTB.Enabled = false;
            DrugTB.BackColor = Color.LightGray;

            DrugTypeTB.Enabled = false;
            DrugTypeTB.BackColor = Color.LightGray;

            BloodTypeTB.Enabled = false;
            BloodTypeTB.BackColor = Color.LightGray;

            RHTB.Enabled = false;
            RHTB.BackColor = Color.LightGray;

            LMPTB.Enabled = false;
            LMPTB.BackColor = Color.LightGray;

            MaritalStatusTB.Enabled = false;
            MaritalStatusTB.BackColor = Color.LightGray;

            NumChildrenTB.Enabled = false;
            NumChildrenTB.BackColor = Color.LightGray;

            EducationLevelTB.Enabled = false;
            EducationLevelTB.BackColor = Color.LightGray;

            DietaryTB.Enabled = false;
            DietaryTB.BackColor = Color.LightGray;

            BehavioralHistoryTB.Enabled = false;
            BehavioralHistoryTB.BackColor = Color.LightGray;

            MensesMonthlyYeschoice.Enabled = false;
            MensesMonthlyYeschoice.BackColor = Color.LightGray;

            MensesMonthlyNochoice.Enabled = false;
            MensesMonthlyNochoice.BackColor = Color.LightGray;

            HXTB.Enabled = false;
            HXTB.BackColor = Color.LightGray;

            MedHistoryTB.Enabled = false;
            MedHistoryTB.BackColor = Color.LightGray;

            DrugDurationTB.Enabled = false;
            DrugDurationTB.BackColor = Color.LightGray;

            MensesFreqTB.Enabled = false;
            MensesFreqTB.BackColor = Color.LightGray;

            DeletedCB.Enabled = false;
            DeletedCB.BackColor = Color.LightGray;

        }

        private void SetEditMode()
        {
            TobaccoTB.Enabled = true;
            TobaccoTB.BackColor = Color.White;

            TobaccoDurationTB.Enabled = true;
            TobaccoDurationTB.BackColor = Color.White;

            TobaccoQuanTB.Enabled = true;
            TobaccoQuanTB.BackColor = Color.White;

            DrinkAlcoholTB.Enabled = true;
            DrinkAlcoholTB.BackColor = Color.White;

            AlcoholQuanTB.Enabled = true;
            AlcoholQuanTB.BackColor = Color.White;

            AlcoholDurTB.Enabled = true;
            AlcoholDurTB.BackColor = Color.White;

            DrugTB.Enabled = true;
            DrugTB.BackColor = Color.White;

            DrugTypeTB.Enabled = true;
            DrugTypeTB.BackColor = Color.White;

            BloodTypeTB.Enabled = true;
            BloodTypeTB.BackColor = Color.White;

            RHTB.Enabled = true;
            RHTB.BackColor = Color.White;

            LMPTB.Enabled = true;
            LMPTB.BackColor = Color.White;

            MaritalStatusTB.Enabled = true;
            MaritalStatusTB.BackColor = Color.White;

            NumChildrenTB.Enabled = true;
            NumChildrenTB.BackColor = Color.White;

            EducationLevelTB.Enabled = true;
            EducationLevelTB.BackColor = Color.White;

            DietaryTB.Enabled = true;
            DietaryTB.BackColor = Color.White;

            BehavioralHistoryTB.Enabled = true;
            BehavioralHistoryTB.BackColor = Color.White;

            MensesMonthlyYeschoice.Enabled = true;
            MensesMonthlyYeschoice.BackColor = Color.White;

            MensesMonthlyNochoice.Enabled = true;
            MensesMonthlyNochoice.BackColor = Color.White;

            HXTB.Enabled = true;
            HXTB.BackColor = Color.White;

            MedHistoryTB.Enabled = true;
            MedHistoryTB.BackColor = Color.White;

            DrugDurationTB.Enabled = true;
            DrugDurationTB.BackColor = Color.White;

            MensesFreqTB.Enabled = false;
            MensesFreqTB.BackColor = Color.White;

            DeletedCB.Enabled = true;
            DeletedCB.BackColor = Color.White;

        }

        private void MensesMonthlyOption_CheckedChanged(object sender, EventArgs e)
        {
            // When one option is selected, disable the other option
            if (MensesMonthlyYeschoice.Checked)
            {
                MensesMonthlyNochoice.Enabled = false;
            }
            else
            {
                MensesMonthlyNochoice.Enabled = true;
            }

            if (MensesMonthlyNochoice.Checked)
            {
                MensesMonthlyYeschoice.Enabled = false;
            }
            else
            {
                MensesMonthlyYeschoice.Enabled = true;
            }
        }



        private void AddBT_Click(object sender, EventArgs e)
        {
            StoreOriginalValues();
            SetEditMode();
        }

        private void ModifyBT_Click(object sender, EventArgs e)
        {
            StoreOriginalValues();
            SetEditMode();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            try
            {
                DBOperations.AddGeneralMedicalInfo(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }

            SetViewMode();
        }

        private void GoToFamilyHistoryBT_Click(object sender, EventArgs e)
        {
            Form Family_History = new Family_History_Form();
            Family_History.Show();
            this.Hide();
        }

        private void GoToLoginPageBT_Click(object sender, EventArgs e)
        {
            Form Login = new Login_Form();
            Login.Show();
            this.Hide();
        }

        private void MMYCB_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Handle logic when MMYCB's checked state changes if needed
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UndoBT_Click(object sender, EventArgs e)
        {
            UndoChanges();
            
        }

        private List<string> originalValues = new List<string>();

        private void StoreOriginalValues()
        {
            originalValues.Clear();
            originalValues.Add(MaritalStatusTB.Text);
            originalValues.Add(EducationLevelTB.Text);
            originalValues.Add(BehavioralHistoryTB.Text);
            originalValues.Add(TobaccoTB.Text);
            originalValues.Add(TobaccoQuanTB.Text);
            originalValues.Add(TobaccoDurationTB.Text);
            originalValues.Add(DrinkAlcoholTB.Text);
            originalValues.Add(AlcoholQuanTB.Text);
            originalValues.Add(AlcoholDurTB.Text);
            originalValues.Add(DrugTB.Text);
            originalValues.Add(DrugTypeTB.Text);
            originalValues.Add(DrugDurationTB.Text);
            originalValues.Add(DietaryTB.Text);
            originalValues.Add(BloodTypeTB.Text);
            originalValues.Add(RHTB.Text);
            originalValues.Add(LMPTB.Text);
            originalValues.Add(NumChildrenTB.Text);
            originalValues.Add(MensesFreqTB.Text);
            originalValues.Add(MedHistoryTB.Text);
            originalValues.Add(HXTB.Text);
            originalValues.Add(DeletedCB.Checked.ToString());
            originalValues.Add(MensesMonthlyYeschoice.Checked.ToString());
            originalValues.Add(MensesMonthlyNochoice.Checked.ToString());
        }

        private void UndoChanges()
        {
            if (originalValues.Count == 23) // Ensure there are values stored to undo
            {
                MaritalStatusTB.Text = originalValues[0];
                EducationLevelTB.Text = originalValues[1];
                BehavioralHistoryTB.Text = originalValues[2];
                TobaccoTB.Text = originalValues[3];
                TobaccoQuanTB.Text = originalValues[4];
                TobaccoDurationTB.Text = originalValues[5];
                DrinkAlcoholTB.Text = originalValues[6];
                AlcoholQuanTB.Text = originalValues[7];
                AlcoholDurTB.Text = originalValues[8];
                DrugTB.Text = originalValues[9];
                DrugTypeTB.Text = originalValues[10];
                DrugDurationTB.Text = originalValues[11];
                DietaryTB.Text = originalValues[12];
                BloodTypeTB.Text = originalValues[13];
                RHTB.Text = originalValues[14];
                LMPTB.Text = originalValues[15];
                NumChildrenTB.Text = originalValues[16];
                MensesFreqTB.Text = originalValues[17];
                MedHistoryTB.Text = originalValues[18];
                HXTB.Text = originalValues[19];
                DeletedCB.Checked = bool.Parse(originalValues[20]);
                MensesMonthlyYeschoice.Checked = bool.Parse(originalValues[21]);
                MensesMonthlyNochoice.Checked = bool.Parse(originalValues[22]);
            }
            else
            {
                MessageBox.Show("No changes to undo.");
            }
        }



    }
}