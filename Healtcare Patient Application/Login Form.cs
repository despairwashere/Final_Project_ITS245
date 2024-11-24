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
using static Healtcare_Patient_Application.DataOperations.LoginSession;

namespace Healtcare_Patient_Application
{
    public partial class Login_Form : Form
    {
        

        public string User
        {
            get { return UserNameTB.Text; }
            set { UserNameTB.Text = value; }
        }

        public string Pass
        {
            get { return PasswordTB.Text; }
            set { PasswordTB.Text = value; }
        }


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

        private void LoginBT_Click(object sender, EventArgs e)
        {
            LoginDBOperations.GetLoginID(this);
        }

        private void LogOutBT_Click(object sender, EventArgs e)
        {
            string actionDescription = "Logged out";
            string formName = "Login_Form"; // Or the name of the form the user is logging out from
            LogAccessForm.LogUserAction(GlobalSession.LoginID, formName, actionDescription);

            // Clear the login session
            GlobalSession.LoginID = 0;

            // Show a message indicating logout
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to the login form
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
            this.Hide();
        }
    }
}
