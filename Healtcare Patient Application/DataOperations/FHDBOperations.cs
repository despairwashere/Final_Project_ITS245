using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Healtcare_Patient_Application.DataOperations
{
    internal class FHDBOperations
    {
        private static object GetParameterValue(object value)
        {
            if (value is bool boolValue)
            {
                // Convert bool to tinyint for MySQL (1 for true, 0 for false)
                return boolValue ? 1 : 0;
            }
    
            if (value is string stringValue)
            {
                        // Handle string values, returning DBNull.Value for null/empty strings
                        return string.IsNullOrWhiteSpace(stringValue) ? (object)DBNull.Value : value;

                    }

                    // Handle other object types, returning DBNull.Value if null
                    return value ?? DBNull.Value;
        }


        public static void AddFamilyHistory (Family_History_Form form)
        {
            if (form == null)
            {
                MessageBox.Show("Form is null.");
                return; // Prevent further execution
            }

            using (MySqlConnection connection = GMHDBOperations.MakeConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("AddFamilyHistory", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        int? patientID = int.TryParse(form.PatientIDFB, out int Number) ? Number : (int?)null;
                        command.Parameters.AddWithValue("p_PatientID", patientID.HasValue ? (object)patientID.Value : DBNull.Value);

                        // Use GetParameterValue for parameters
                        command.Parameters.AddWithValue("p_Name", GetParameterValue(form.FamilyName));
                        command.Parameters.AddWithValue("p_Relation", GetParameterValue(form.Relation));
                        command.Parameters.AddWithValue("p_Alive", GetParameterValue(form.Alive));
                        command.Parameters.AddWithValue("p_Liveswithpatient", GetParameterValue(form.LivesWith));
                        command.Parameters.AddWithValue("p_Deleted", GetParameterValue(form.Deleted));
                        command.Parameters.AddWithValue("p_MajorDisorder", GetParameterValue(form.MajorDisorders));
                        command.Parameters.AddWithValue("p_SpecificTypeDisorder", GetParameterValue(form.SpecificDisorderType));
                       
                        
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

