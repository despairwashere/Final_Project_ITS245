using Healtcare_Patient_Application.DataOperations;
using Healthcare_Patient_Application.DataOperations;
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
        public string FamilyName { 
            get { return FamilyNameTB.Text;  }
            set { FamilyNameTB.Text = value; }
        }
        public string Relation { 
            get { return FamilyRelationTB.Text; } 
            set { FamilyRelationTB.Text = value; }
        }

        public bool Alive { 
            get { return AliveCB.Checked; }
            set { AliveCB.Checked = value; }
        }
        public bool LivesWith { 
            get { return LivesWithPatientCB.Checked; } 
            set {  LivesWithPatientCB.Checked = value; }
        }

        public bool Deleted { 
            get { return deletedCB.Checked; }
            set { deletedCB.Checked = value; }
        }

        public string MajorDisorders {  
            get {  return MajorDisordersTB.Text; } 
            set {  MajorDisordersTB.Text = value;}
        }
        public string SpecificDisorderType { 
            get { return SpecificDisorderTypeTB.Text; }
            set { SpecificDisorderTypeTB.Text = value;}
        }

        public string PatientNameFB { get; set; }
        public string PatientAgeFB { get; set; }
        public string PatientIDFB { get; set; }
        public string FamilyID {  get; set; }
        

        private string patientID; // Holds patient id 
        private string patientName;
        private string age;
        private string familyID;
        



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
            LoadPatientData();
            DisplayFamilyData();
            LoadFamilyHistory();
        }

        private void PatientName_Click(object sender, EventArgs e)
        {

        }

        private bool Add_New_Rec = false;
        private void FamHisAddBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = true;
            SetEditMode();


        }

        private void FamHisModifyBT_Click(object sender, EventArgs e)
        {
            Add_New_Rec = false;
            SetEditMode();

        }

        private void FamHisSaveBT_Click(object sender, EventArgs e)
        {
            if (Add_New_Rec == true)
            {
                try
                {
                    FHDBOperations.AddFamilyHistory(this);

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
                    FHDBOperations.UpdateFamilyHistoryInfo(this);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating record: {ex.Message}");
                }


            }

            SetViewMode();
            LoadFamilyHistory();
        }

        private void GoToGenMedicalHistoryBT_Click(object sender, EventArgs e)
        {
            GMH Gen_history = new GMH();
            Gen_history.PatientName = patientName;
            Gen_history.PatientAge = age;
            Gen_history.PatientID = patientID;
            Gen_history.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row.
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get the patient's name and age from the row.
                patientName = row.Cells["FullName"].Value.ToString();
                age = row.Cells["Age"].Value.ToString();
                patientID = row.Cells["PatientID"].Value.ToString();
                

                // Update the labels to display the name and age.
                PatientNameLB.Text = patientName;
                PatientAgeLB.Text = "Age: " + age;

                PatientIDFB = patientID;
                

                LoadFamilyHistory();
               
            }

        }

        private void LoadPatientData()
        {
            DataTable patientData = GMHDBOperations.PatientData();

            if (patientData.Columns.Contains("DOB"))
                patientData.Columns["DOB"].ColumnMapping = MappingType.Hidden;

            // Set the DataGridView's data source
            dataGridView1.DataSource = patientData;

            // Ensure DataGridView contains the columns before hiding
            if (dataGridView1.Columns.Contains("PatientID"))
            {
                dataGridView1.Columns["PatientID"].Visible = false;
            }

            // Change header text for FullName
            if (dataGridView1.Columns["FullName"] != null)
                dataGridView1.Columns["FullName"].HeaderText = "Patient Name";

            // Hide "Age" column if it exists
            if (dataGridView1.Columns.Contains("Age"))
                dataGridView1.Columns["Age"].Visible = false;


        }

        private void LoadFamilyHistory()
        {
            DataTable familyData = FHDBOperations.LoadFamilyHistoryRecords(PatientIDFB);

            

            // Set the DataGridView's data source
            dataGridView2.DataSource = familyData;

            // Ensure DataGridView contains the columns before hiding
            if (dataGridView2.Columns.Contains("Name"))
            {
                dataGridView2.Columns["Name"].Visible = false;
            }


            if (dataGridView2.Columns.Contains("Relation"))
                dataGridView2.Columns["Relation"].Visible = true;

            if (dataGridView2.Columns.Contains("Liveswithpatient"))
                dataGridView2.Columns["Liveswithpatient"].Visible = false;

            if (dataGridView2.Columns.Contains("Alive"))
                dataGridView2.Columns["Alive"].Visible = false;

            if (dataGridView2.Columns.Contains("SpecificTypeDisorder"))
                dataGridView2.Columns["SpecificTypeDisorder"].Visible = false;

            if (dataGridView2.Columns.Contains("MajorDisorder"))
                dataGridView2.Columns["MajorDisorder"].Visible = true;

            if (dataGridView2.Columns.Contains("FamilyID"))
                dataGridView2.Columns["FamilyID"].Visible = false;


        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row.
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];


                FamilyNameTB.Text = row.Cells["Name"].Value.ToString();
                FamilyRelationTB.Text = row.Cells["Relation"].Value.ToString();
                MajorDisordersTB.Text = row.Cells["MajorDisorder"].Value.ToString();
                SpecificDisorderTypeTB.Text = row.Cells["SpecificTypeDisorder"].Value.ToString();
                AliveCB.Checked = Convert.ToBoolean(row.Cells["Alive"].Value);
                LivesWithPatientCB.Checked = Convert.ToBoolean(row.Cells["Liveswithpatient"].Value);

                familyID = row.Cells["familyID"].Value.ToString();
                FamilyID = familyID;




            }

        }
    }
}
