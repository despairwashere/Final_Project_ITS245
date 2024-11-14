using System;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Healtcare_Patient_Application;
using Healthcare_Patient_Application;
using MySql.Data.MySqlClient;

namespace Healthcare_Patient_Application.DataOperations
{
    internal class GMHDBOperations
    {
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=localhost; uid=root; pwd=password; database=healthdataapp";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        private static object GetParameterValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (object)DBNull.Value : value;
        }

        public static void AddGeneralMedicalInfo(GMH form)
        {
            if (form == null)
            {
                MessageBox.Show("Form is null.");
                return; // Prevent further execution
            }

            using (MySqlConnection connection = MakeConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("AddGeneralMedicalInfo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Use GetParameterValue for parameters
                        command.Parameters.AddWithValue("p_MaritalStatus", GetParameterValue(form.MaritalStatus));
                        command.Parameters.AddWithValue("p_Education", GetParameterValue(form.EducationLevel));
                        command.Parameters.AddWithValue("p_BehavioralHistory", GetParameterValue(form.BehavioralHistory));
                        command.Parameters.AddWithValue("p_Tobacco", GetParameterValue(form.Tobacco));
                        command.Parameters.AddWithValue("p_TobaccoQuantity", GetParameterValue(form.TobaccoQuantity));
                        command.Parameters.AddWithValue("p_TobaccoDuration", GetParameterValue(form.TobaccoDuration));
                        command.Parameters.AddWithValue("p_Alcohol", GetParameterValue(form.Alcohol));
                        command.Parameters.AddWithValue("p_AlcoholQuantity", GetParameterValue(form.AlcoholQuantity));
                        command.Parameters.AddWithValue("p_AlcoholDuration", GetParameterValue(form.AlcoholDuration));
                        command.Parameters.AddWithValue("p_Drug", GetParameterValue(form.Drug));
                        command.Parameters.AddWithValue("p_DrugType", GetParameterValue(form.DrugType));
                        command.Parameters.AddWithValue("p_DrugDuration", GetParameterValue(form.DrugDuration));
                        command.Parameters.AddWithValue("p_Dietary", GetParameterValue(form.Dietary));
                        command.Parameters.AddWithValue("p_BloodType", GetParameterValue(form.BloodType));
                        command.Parameters.AddWithValue("p_Rh", GetParameterValue(form.RH));
                        command.Parameters.AddWithValue("p_LMPStatus", GetParameterValue(form.LMP));

                        // Parse and handle number of children
                        int? numberOfChildren = int.TryParse(form.NumberOfChildren, out int tempNumber) ? tempNumber : (int?)null;
                        command.Parameters.AddWithValue("p_NumberOfChildren", numberOfChildren.HasValue ? (object)numberOfChildren.Value : DBNull.Value);

                        // Remaining parameters
                        command.Parameters.AddWithValue("p_MensesMonthlyYes", form.MensesMonthlyYes);
                        command.Parameters.AddWithValue("p_MensesMonthlyNo", form.MensesMonthlyNo);
                        command.Parameters.AddWithValue("p_MensesFreq", GetParameterValue(form.MensesFrequency));
                        command.Parameters.AddWithValue("p_MedicalHistoryNotes", GetParameterValue(form.MedicalHistoryNotes));
                        command.Parameters.AddWithValue("p_HxObtainedBy", GetParameterValue(form.HX));
                        command.Parameters.AddWithValue("p_deleted", form.IsDeleted);

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding medical info: {ex.Message}");
                }

                
            }
           
        }
    }
}
