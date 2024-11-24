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
    public partial class PatientSelectionForm : Form
    {
        public PatientSelectionForm()
        {
            InitializeComponent();
        }

        private void btnGoToDemographics_Click(object sender, EventArgs e)
        {
            // Create an instance of the PatientDemographicsForm
            PatientDemographicsForm demographicsForm = new PatientDemographicsForm();

            // Show the Patient Demographics Form
            demographicsForm.Show();

            // Optionally, hide the current form
            this.Hide();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
