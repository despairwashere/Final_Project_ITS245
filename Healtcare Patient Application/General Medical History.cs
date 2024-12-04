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

namespace Healtcare_Patient_Application 
{
    public partial class GMH : Form
    {
        //This is to test Git commits

        
       

        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientAge { get; set; }
        public string GeneralMedicalHistoryID { get; set; }

    


        public string MaritalStatus
        {
            get { return MaritalStatusTB.Text; }
            set { MaritalStatusTB.Text = value; }
        }

        public string EducationLevel
        {
            get { return EducationLevelTB.Text; }
            set { EducationLevelTB.Text = value; }
        }

        public string BehavioralHistory
        {
            get { return BehavioralHistoryTB.Text; }
            set { BehavioralHistoryTB.Text = value; }
        }

        public string Tobacco
        {
            get { return TobaccoTB.Text; }
            set { TobaccoTB.Text = value; }
        }

        public string TobaccoQuantity
        {
            get { return TobaccoQuanTB.Text; }
            set { TobaccoQuanTB.Text = value; }
        }

        public string TobaccoDuration
        {
            get { return TobaccoDurationTB.Text; }
            set { TobaccoDurationTB.Text = value; }
        }

        public string Alcohol
        {
            get { return DrinkAlcoholTB.Text; }
            set { DrinkAlcoholTB.Text = value; }
        }

        public string AlcoholQuantity
        {
            get { return AlcoholQuanTB.Text; }
            set { AlcoholQuanTB.Text = value; }
        }

        public string AlcoholDuration
        {
            get { return AlcoholDurTB.Text; }
            set { AlcoholDurTB.Text = value; }
        }

        public string Drug
        {
            get { return DrugTB.Text; }
            set { DrugTB.Text = value; }
        }

        public string DrugType
        {
            get { return DrugTypeTB.Text; }
            set { DrugTypeTB.Text = value; }
        }

        public string DrugDuration
        {
            get { return DrugDurationTB.Text; }
            set { DrugDurationTB.Text = value; }
        }

        public string Dietary
        {
            get { return DietaryTB.Text; }
            set { DietaryTB.Text = value; }
        }

        public string BloodType
        {
            get { return BloodTypeTB.Text; }
            set { BloodTypeTB.Text = value; }
        }

        public string RH
        {
            get { return RHTB.Text; }
            set { RHTB.Text = value; }
        }

        public string LMP
        {
            get { return LMPTB.Text; }
            set { LMPTB.Text = value; }
        }

        public string NumberOfChildren
        {
            get { return NumChildrenTB.Text; }
            set { NumChildrenTB.Text = value; }
        }

        public bool MensesMonthlyYes
        {
            get { return MensesMonthlyYeschoice.Checked; }
            set { MensesMonthlyYeschoice.Checked = value; }
        }

        public bool MensesMonthlyNo
        {
            get { return MensesMonthlyNochoice.Checked; }
            set { MensesMonthlyNochoice.Checked = value; }
        }

        public string MensesFrequency
        {
            get { return MensesFreqTB.Text; }
            set { MensesFreqTB.Text = value; }
        }

        public string MedicalHistoryNotes
        {
            get { return MedHistoryTB.Text; }
            set { MedHistoryTB.Text = value; }
        }

        public string HX
        {
            get { return HXTB.Text; }
            set { HXTB.Text = value; }
        }

        public bool IsDeleted
        {
            get { return DeletedCB.Checked; }
            set { DeletedCB.Checked = value; }
        }

        public GMH()
        {
            InitializeComponent();  // Initialize Components
            LogAccessForm.FormAccessLogger.LogFormAccess(LoginSession.GlobalSession.LoginID, "General Medical History Form");

            MensesMonthlyYeschoice.CheckedChanged += MensesMonthlyOption_CheckedChanged;
            MensesMonthlyNochoice.CheckedChanged += MensesMonthlyOption_CheckedChanged;
        }

        // Public properties to access TextBox and CheckBox values


        private void GMH_Load(object sender, EventArgs e)
        {
            SetViewMode();
            GMHDBOperations.GetGeneralMedicalInfo(this);
            DisplayPatientData();
            


        }

        private void DisplayPatientData()
        {
            PatientAgeLB.Text = PatientAge;
            Patient_Name.Text = PatientName;

        }

        private void SetViewMode()
        {
            TobaccoTB.Enabled = false;
            TobaccoTB.BackColor = Color.LightGray;
            TobaccoTB.Clear();

            TobaccoDurationTB.Enabled = false;
            TobaccoDurationTB.BackColor = Color.LightGray;
            TobaccoDurationTB.Clear();

            TobaccoQuanTB.Enabled = false;
            TobaccoQuanTB.BackColor = Color.LightGray;
            TobaccoQuanTB.Clear();

            DrinkAlcoholTB.Enabled = false;
            DrinkAlcoholTB.BackColor = Color.LightGray;
            DrinkAlcoholTB.Clear();

            AlcoholQuanTB.Enabled = false;
            AlcoholQuanTB.BackColor = Color.LightGray;
            AlcoholQuanTB.Clear();

            AlcoholDurTB.Enabled = false;
            AlcoholDurTB.BackColor = Color.LightGray;
            AlcoholDurTB.Clear();

            DrugTB.Enabled = false;
            DrugTB.BackColor = Color.LightGray;
            DrugTB.Clear();

            DrugTypeTB.Enabled = false;
            DrugTypeTB.BackColor = Color.LightGray;
            DrugTypeTB.Clear();

            BloodTypeTB.Enabled = false;
            BloodTypeTB.BackColor = Color.LightGray;
            BloodTypeTB.Clear();

            RHTB.Enabled = false;
            RHTB.BackColor = Color.LightGray;
            RHTB.Clear();

            LMPTB.Enabled = false;
            LMPTB.BackColor = Color.LightGray;
            LMPTB.Clear();

            MaritalStatusTB.Enabled = false;
            MaritalStatusTB.BackColor = Color.LightGray;
            MaritalStatusTB.Clear();

            NumChildrenTB.Enabled = false;
            NumChildrenTB.BackColor = Color.LightGray;
            NumChildrenTB.Clear();

            EducationLevelTB.Enabled = false;
            EducationLevelTB.BackColor = Color.LightGray;
            EducationLevelTB.Clear();

            DietaryTB.Enabled = false;
            DietaryTB.BackColor = Color.LightGray;
            DietaryTB.Clear();

            BehavioralHistoryTB.Enabled = false;
            BehavioralHistoryTB.BackColor = Color.LightGray;
            BehavioralHistoryTB.Clear();

            MensesMonthlyYeschoice.Enabled = false;
            MensesMonthlyYeschoice.BackColor = Color.LightGray;
            MensesMonthlyYeschoice.Checked = false;

            MensesMonthlyNochoice.Enabled = false;
            MensesMonthlyNochoice.BackColor = Color.LightGray;
            MensesMonthlyNochoice.Checked = false;

            HXTB.Enabled = false;
            HXTB.BackColor = Color.LightGray;
            HXTB.Clear();

            MedHistoryTB.Enabled = false;
            MedHistoryTB.BackColor = Color.LightGray;
            MedHistoryTB.Clear();

            DrugDurationTB.Enabled = false;
            DrugDurationTB.BackColor = Color.LightGray;
            DrugDurationTB.Clear();

            MensesFreqTB.Enabled = false;
            MensesFreqTB.BackColor = Color.LightGray;
            MensesFreqTB.Clear();

            DeletedCB.Enabled = false;
            DeletedCB.BackColor = Color.LightGray;
            DeletedCB.Checked = false;

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

            MensesFreqTB.Enabled = true;
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

        private bool Add_New_Rec = false;

        private void AddBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = true;
            StoreOriginalValues();
            SetEditMode();
            LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "General Medical History Form",
                "User clicked the Add Button");
        }

        private void ModifyBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = false;
            StoreOriginalValues();
            SetEditMode();
            LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "General Medical History Form",
                "User clicked the Modify Button");

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {

            if (Add_New_Rec == true)
            {
                try
                {
                    GMHDBOperations.AddGeneralMedicalInfo(this);
                    LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "General Medical History Form",
                "User saved a new General Medical History Record.");

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
                    GMHDBOperations.UpdateGeneralMedicalInfo(this);
                    LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "General Medical History Form",
                "User modified a General Medical History Record.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating record: {ex.Message}");
                }

                
            }

            SetViewMode();
        }

        private void GoToFamilyHistoryBT_Click(object sender, EventArgs e)
        {
            Family_History_Form family = new Family_History_Form();
            family.PatientIDFB = PatientID;
            family.PatientNameFB = PatientName;
            family.PatientAgeFB = PatientAge;
            family.Show();
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
            

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (DeletedCB.Checked)
            {

                GMHDBOperations.DeleteGeneralMedicalInfo(this);
                SetViewMode();
                LogAccessForm.LogUserAction(LoginSession.GlobalSession.LoginID, "General Medical History Form",
                    "User deleted a General Medical History Record.");
            }
            else
            {
                MessageBox.Show("General Medical History record is not deleted.");
            }
        }

        private void PatientSelectFormBT_Click(object sender, EventArgs e)
        {
            // Create an instance of the previous form (e.g., MainForm or PatientSelectionForm)
            PatientSelectionForm selectionForm = new PatientSelectionForm();

            // Show the previous form
            selectionForm.Show();

            // Close or hide the current form
            this.Close();
        }

        private void BTAllergyForm_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(PatientID);
            
            AllergyHistoryForm allergyform = new AllergyHistoryForm(patientID, PatientName, PatientAge);
            allergyform.Show();
            this.Hide();
        }

        private void PatientDemographicsBTN_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(PatientID);
            PatientDemographicsForm form = new PatientDemographicsForm(patientID);
            form.Show();
            this.Hide();
        }
    }
}