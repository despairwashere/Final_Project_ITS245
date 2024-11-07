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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = true;

        }

        private void GoToFamilyHistory_Click(object sender, EventArgs e)
        {
            Form Family_History = new Family_History_Form();
            Family_History.Show();
            this.Hide();
        }

        private void GoToGenMedicalHistoryBT_Click(object sender, EventArgs e)
        {
            Form Gen_Medical_History = new GMH();
            Gen_Medical_History.Show();
            this.Hide();
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
