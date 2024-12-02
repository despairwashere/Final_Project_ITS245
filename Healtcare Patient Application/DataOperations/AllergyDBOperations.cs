using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healtcare_Patient_Application.DataOperations
{
    internal class AllergyDBOperations
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

            if (value is DateTime dateTimeValue)
            {
                // Format DateTime as a string in "yyyy-MM-dd HH:mm:ss" format for MySQL
                return dateTimeValue.ToString("yyyy-MM-dd");
            }

            // Handle other object types, returning DBNull.Value if null
            return value ?? DBNull.Value;
        }
        public static DataTable LoadAllergyHistoryRecords(AllergyHistoryForm form)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = GMHDBOperations.MakeConnection())
            {
                try
                {
                    
                    // Use the appropriate stored procedure name for fetching family history records
                    using (MySqlCommand command = new MySqlCommand("GetAllergyHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new MySqlParameter("p_PatientID", form.PatientIDAllergy));

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                if (row["AllergyEndDate"] == DBNull.Value)
                                {
                                    row["AllergyEndDate"] = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving allergy history records: {ex.Message}");
                }
            }
            return dt;
        }

        public static void AddAllergyHistory(AllergyHistoryForm form)
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
                    using (MySqlCommand command = new MySqlCommand("AddAllergyHistory", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        
                        command.Parameters.AddWithValue("p_PatientID", GetParameterValue(form.PatientIDAllergy));

                        // Use GetParameterValue for parameters
                        command.Parameters.AddWithValue("p_Allergen", GetParameterValue(form.Allergen));
                        command.Parameters.AddWithValue("p_AllergyDescription", GetParameterValue(form.Allergy_Description));

                        command.Parameters.AddWithValue("p_AllergyStartDate", Convert.ToString(form.AllergyStartDate));
                        command.Parameters.AddWithValue("p_AllergyEndDate", GetParameterValue(form.AllergyEndDate));
                        


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

        public static void UpdateAllergyHistory(AllergyHistoryForm form)
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
                    using (MySqlCommand command = new MySqlCommand("UpdateAllergyHistory", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("p_PatientID", GetParameterValue(form.PatientIDAllergy));
                        command.Parameters.AddWithValue("p_AllergyID", GetParameterValue(form.AllergyID));

                        // Use GetParameterValue for parameters
                        command.Parameters.AddWithValue("p_Allergen", GetParameterValue(form.Allergen));
                        command.Parameters.AddWithValue("p_AllergyDescription", GetParameterValue(form.Allergy_Description));

                        command.Parameters.AddWithValue("p_AllergyStartDate", Convert.ToString(form.AllergyStartDate));
                        command.Parameters.AddWithValue("p_AllergyEndDate", Convert.ToString(form.AllergyEndDate));



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

        public static void DeleteAllergyHistoryInfo(AllergyHistoryForm form)
        {
            using (MySqlConnection connection = GMHDBOperations.MakeConnection())
            {
                try
                {

                    using (MySqlCommand command = new MySqlCommand("DeleteAllergyHistoryInfo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_PatientID", form.PatientIDAllergy);
                        command.Parameters.AddWithValue("p_AllergyID", form.AllergyID);


                        command.Parameters.AddWithValue("p_deleted", form.Deleted);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Family History Record marked as deleted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
