using System;
using System.Data;
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

                        // Add PatientID parameter

                        int? patientID = int.TryParse(form.PatientID, out int Number) ? Number : (int?)null;
                        command.Parameters.AddWithValue("p_PatientID", patientID.HasValue ? (object)patientID.Value : DBNull.Value);

                        // Add other parameters
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

        public static void UpdateGeneralMedicalInfo(GMH form)
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
                    using (MySqlCommand command = new MySqlCommand("UpdateGeneralMedicalInfo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add PatientID parameter
                        int? patientID = int.TryParse(form.PatientID, out int Number) ? Number : (int?)null;
                        command.Parameters.AddWithValue("p_PatientID", patientID.HasValue ? (object)patientID.Value : DBNull.Value);

                        // Add other parameters
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
                        

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating medical info: {ex.Message}");
                }
            }
        }



        public static DataTable PatientData()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = MakeConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("GetPatientData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving patient data: {ex.Message}");
                }
            }
            return dt;
        }

        public static void GetGeneralMedicalInfo (GMH form)
        {
            using (MySqlConnection connection = MakeConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("GetGeneralMedicalInfo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add PatientID parameter
                        int? patientID = int.TryParse(form.PatientID, out int number) ? number : (int?)null;
                        command.Parameters.AddWithValue("p_PatientID", patientID.HasValue ? (object)patientID.Value : DBNull.Value);

                        
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate form fields
                                form.MaritalStatus = reader["MaritalStatus"] as string ?? string.Empty;
                                form.EducationLevel = reader["Education"] as string ?? string.Empty;
                                form.BehavioralHistory = reader["BehavioralHistory"] as string ?? string.Empty;
                                form.Tobacco = reader["Tobacco"] as string ?? string.Empty;
                                form.TobaccoQuantity = reader["TobaccoQuantity"] as string ?? string.Empty;
                                form.TobaccoDuration = reader["TobaccoDuration"] as string ?? string.Empty;
                                form.Alcohol = reader["Alcohol"] as string ?? string.Empty;
                                form.AlcoholQuantity = reader["AlcoholQuantity"] as string ?? string.Empty;
                                form.AlcoholDuration = reader["AlcoholDuration"] as string ?? string.Empty;
                                form.Drug = reader["Drug"] as string ?? string.Empty;
                                form.DrugType = reader["DrugType"] as string ?? string.Empty;
                                form.DrugDuration = reader["DrugDuration"] as string ?? string.Empty;
                                form.Dietary = reader["Dietary"] as string ?? string.Empty;
                                form.BloodType = reader["BloodType"] as string ?? string.Empty;
                                form.RH = reader["Rh"] as string ?? string.Empty;
                                form.LMP = reader["LMPStatus"] as string ?? string.Empty;

                                // Handle nullable integers
                                form.NumberOfChildren = reader["NumberOfChildren"] != DBNull.Value
                                    ? reader["NumberOfChildren"].ToString()
                                    : string.Empty;

                                // Handle boolean values
                                form.MensesMonthlyYes = reader["MensesMonthlyYes"] != DBNull.Value && Convert.ToBoolean(reader["MensesMonthlyYes"]);
                                form.MensesMonthlyNo = reader["MensesMonthlyNo"] != DBNull.Value && Convert.ToBoolean(reader["MensesMonthlyNo"]);

                                form.MensesFrequency = reader["MensesFreq"] as string ?? string.Empty;
                                form.MedicalHistoryNotes = reader["MedicalHistoryNotes"] as string ?? string.Empty;
                                form.HX = reader["HxObtainedBy"] as string ?? string.Empty;
                                form.IsDeleted = reader["deleted"] != DBNull.Value && Convert.ToBoolean(reader["deleted"]);
                                form.GeneralMedicalHistoryID = reader["GeneralMedicalHistoryID"] != DBNull.Value ? reader["GeneralMedicalHistoryID"].ToString() : string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("No records found for the specified PatientID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving medical info: {ex.Message}");
                }
            }

        }

        public static void DeleteGeneralMedicalInfo(GMH form)
        {
            using (MySqlConnection connection = MakeConnection())
            {
                try
                {
                    
                    using (MySqlCommand command = new MySqlCommand("DeleteGeneralMedicalInfo", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        // Add PatientID parameter
                        int? patientID = int.TryParse(form.PatientID, out int Number) ? Number : (int?)null;
                        command.Parameters.AddWithValue("p_PatientID", patientID.HasValue ? (object)patientID.Value : DBNull.Value);

                        int? generalMedicalHistoryID = int.TryParse(form.GeneralMedicalHistoryID, out int medicalHistoryNumber) ? medicalHistoryNumber : (int?)null;
                        command.Parameters.AddWithValue("p_GeneralMedicalHistoryID", generalMedicalHistoryID.HasValue ? (object)generalMedicalHistoryID.Value : DBNull.Value);


                        command.Parameters.AddWithValue("p_deleted", 1); // Set the deleted flag to 1

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("General medical information marked as deleted successfully.");
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
