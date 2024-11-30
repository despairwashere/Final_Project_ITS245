using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using Healtcare_Patient_Application;
using System.Data.SqlClient;

namespace Healthcare_Patient_Application.DataOperations
{
    internal class PatientSummary
    {
        public static void GeneratePatientReport(PatientSelectionForm form)
        {
            string baseDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ITS-245 Final Project", "Patient Summary Reports");

            // Ensure the directory exists (create it if it doesn't)
            if (!Directory.Exists(baseDirectory))
            {
                Directory.CreateDirectory(baseDirectory);
            }


            using (MySqlConnection conn = GMHDBOperations.MakeConnection())
            {
                // Retrieve data for the patient from all related tables
                using (MySqlCommand cmd = new MySqlCommand("PatientSummary", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_PatientID", form.PatientIdSF);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            string reportContent = "";
                            bool firstRecord = true;
                            string patientName = "";

                            // Variables to store allergy and family history
                            List<string> allergies = new List<string>();
                            List<string> familyHistory = new List<string>();

                            // Variables to store general medical history
                            string generalMedicalHistory = "";

                            while (reader.Read())
                            {
                                if (firstRecord)
                                {
                                    // Read the patient demographic details (Only once for the first record)
                                    // Read and sanitize each field with "N/A" if empty or null
                                    string hospitalMR = string.IsNullOrWhiteSpace(reader["HospitalMR#"].ToString()) ? "N/A" : reader["HospitalMR#"].ToString();
                                    string lastName = string.IsNullOrWhiteSpace(reader["PtLastName"].ToString()) ? "N/A" : reader["PtLastName"].ToString();
                                    string firstName = string.IsNullOrWhiteSpace(reader["PtFirstName"].ToString()) ? "N/A" : reader["PtFirstName"].ToString();
                                    patientName = $"{firstName} {lastName}";  // Combining first and last names

                                    string middleInitial = string.IsNullOrWhiteSpace(reader["PtMiddleInitial"].ToString()) ? "N/A" : reader["PtMiddleInitial"].ToString();
                                    string suffix = string.IsNullOrWhiteSpace(reader["Suffix"].ToString()) ? "N/A" : reader["Suffix"].ToString();
                                    string homeAddress = string.IsNullOrWhiteSpace(reader["HomeAddress"].ToString()) ? "N/A" : reader["HomeAddress"].ToString();
                                    string homeCity = string.IsNullOrWhiteSpace(reader["HomeCity"].ToString()) ? "N/A" : reader["HomeCity"].ToString();
                                    string homeState = string.IsNullOrWhiteSpace(reader["HomeState/Province/Region"].ToString()) ? "N/A" : reader["HomeState/Province/Region"].ToString();
                                    string homeZip = string.IsNullOrWhiteSpace(reader["HomeZip"].ToString()) ? "N/A" : reader["HomeZip"].ToString();
                                    string country = string.IsNullOrWhiteSpace(reader["Country"].ToString()) ? "N/A" : reader["Country"].ToString();
                                    string citizenship = string.IsNullOrWhiteSpace(reader["Citizenship"].ToString()) ? "N/A" : reader["Citizenship"].ToString();
                                    string homePhone = string.IsNullOrWhiteSpace(reader["PtHomePhone"].ToString()) ? "N/A" : reader["PtHomePhone"].ToString();
                                    string emergencyPhone = string.IsNullOrWhiteSpace(reader["EmergencyPhoneNumber"].ToString()) ? "N/A" : reader["EmergencyPhoneNumber"].ToString();
                                    string email = string.IsNullOrWhiteSpace(reader["EmailAddress"].ToString()) ? "N/A" : reader["EmailAddress"].ToString();
                                    string ssn = string.IsNullOrWhiteSpace(reader["SSN"].ToString()) ? "N/A" : reader["SSN"].ToString();

                                    // Convert date fields with a fallback value of "N/A"
                                    string dob = reader["DOB"] != DBNull.Value ? Convert.ToDateTime(reader["DOB"]).ToString("MM/dd/yyyy") : "N/A";
                                    string gender = string.IsNullOrWhiteSpace(reader["Gender"].ToString()) ? "N/A" : reader["Gender"].ToString();
                                    string ethnicAssociation = string.IsNullOrWhiteSpace(reader["EthnicAssociation"].ToString()) ? "N/A" : reader["EthnicAssociation"].ToString();
                                    string religion = string.IsNullOrWhiteSpace(reader["Religion"].ToString()) ? "N/A" : reader["Religion"].ToString();
                                    string maritalStatus = string.IsNullOrWhiteSpace(reader["MaritalStatus"].ToString()) ? "N/A" : reader["MaritalStatus"].ToString();
                                    string employmentStatus = string.IsNullOrWhiteSpace(reader["EmploymentStatus"].ToString()) ? "N/A" : reader["EmploymentStatus"].ToString();

                                    // Convert date fields with a fallback value of "N/A"
                                    string dateOfExpire = reader["DateofExpire"] != DBNull.Value ? Convert.ToDateTime(reader["DateofExpire"]).ToString("MM/dd/yyyy") : "N/A";
                                    string referral = string.IsNullOrWhiteSpace(reader["Referral"].ToString()) ? "N/A" : reader["Referral"].ToString();
                                    string currentPrimaryHCPId = string.IsNullOrWhiteSpace(reader["CurrentPrimaryHCPId"].ToString()) ? "N/A" : reader["CurrentPrimaryHCPId"].ToString();
                                    string comments = string.IsNullOrWhiteSpace(reader["Comments"].ToString()) ? "N/A" : reader["Comments"].ToString();

                                    // Convert date fields with a fallback value of "N/A"
                                    string dateEntered = reader["DateEntered"] != DBNull.Value ? Convert.ToDateTime(reader["DateEntered"]).ToString("MM/dd/yyyy") : "N/A";
                                    string nextOfKinID = string.IsNullOrWhiteSpace(reader["NextOfKinID"].ToString()) ? "N/A" : reader["NextOfKinID"].ToString();
                                    string nextOfKinRelationship = string.IsNullOrWhiteSpace(reader["NextOfKinRelationshipToPatient"].ToString()) ? "N/A" : reader["NextOfKinRelationshipToPatient"].ToString();


                                    reportContent = $"Patient Report for {firstName} {lastName}\n" +
                                                     $"-----------------------------------------\n" +
                                                     $"Hospital MR#: {hospitalMR}\n" +
                                                     $"Name: {firstName} {middleInitial} {lastName} {suffix}\n" +
                                                     $"Gender: {gender}\n" +
                                                     $"Date of Birth: {dob}\n" +
                                                     $"SSN: {ssn}\n" +
                                                     $"Address: {homeAddress}, {homeCity}, {homeState}, {homeZip}, {country}\n" +
                                                     $"Citizenship: {citizenship}\n" +
                                                     $"Home Phone: {homePhone}\n" +
                                                     $"Emergency Phone: {emergencyPhone}\n" +
                                                     $"Email: {email}\n" +
                                                     $"Ethnic Association: {ethnicAssociation}\n" +
                                                     $"Religion: {religion}\n" +
                                                     $"Marital Status: {maritalStatus}\n" +
                                                     $"Employment Status: {employmentStatus}\n" +
                                                     $"Date of Expiry: {dateOfExpire}\n" +
                                                     $"Referral: {referral}\n" +
                                                     $"Primary Healthcare Provider: {currentPrimaryHCPId}\n" +
                                                     $"Comments: {comments}\n" +
                                                     $"Date Entered: {dateEntered}\n" +
                                                     $"Next of Kin: {nextOfKinID} ({nextOfKinRelationship})\n\n";
                                    firstRecord = false;
                                }

                                // General Medical History Section (only once per patient)
                                if (string.IsNullOrEmpty(generalMedicalHistory))
                                {
                                    // Read and sanitize each field with "N/A" if empty or null
                                    string maritalStatusGMH = string.IsNullOrWhiteSpace(reader["MaritalStatus"].ToString()) ? "N/A" : reader["MaritalStatus"].ToString();
                                    string education = string.IsNullOrWhiteSpace(reader["Education"].ToString()) ? "N/A" : reader["Education"].ToString();
                                    string behavioralHistory = string.IsNullOrWhiteSpace(reader["BehavioralHistory"].ToString()) ? "N/A" : reader["BehavioralHistory"].ToString();
                                    string tobacco = string.IsNullOrWhiteSpace(reader["Tobacco"].ToString()) ? "N/A" : reader["Tobacco"].ToString();
                                    string tobaccoQuantity = string.IsNullOrWhiteSpace(reader["TobaccoQuantity"].ToString()) ? "N/A" : reader["TobaccoQuantity"].ToString();
                                    string tobaccoDuration = string.IsNullOrWhiteSpace(reader["TobaccoDuration"].ToString()) ? "N/A" : reader["TobaccoDuration"].ToString();
                                    string alcohol = string.IsNullOrWhiteSpace(reader["Alcohol"].ToString()) ? "N/A" : reader["Alcohol"].ToString();
                                    string alcoholQuantity = string.IsNullOrWhiteSpace(reader["AlcoholQuantity"].ToString()) ? "N/A" : reader["AlcoholQuantity"].ToString();
                                    string alcoholDuration = string.IsNullOrWhiteSpace(reader["AlcoholDuration"].ToString()) ? "N/A" : reader["AlcoholDuration"].ToString();
                                    string drug = string.IsNullOrWhiteSpace(reader["Drug"].ToString()) ? "N/A" : reader["Drug"].ToString();
                                    string drugType = string.IsNullOrWhiteSpace(reader["DrugType"].ToString()) ? "N/A" : reader["DrugType"].ToString();
                                    string drugDuration = string.IsNullOrWhiteSpace(reader["DrugDuration"].ToString()) ? "N/A" : reader["DrugDuration"].ToString();
                                    string dietary = string.IsNullOrWhiteSpace(reader["Dietary"].ToString()) ? "N/A" : reader["Dietary"].ToString();
                                    string bloodType = string.IsNullOrWhiteSpace(reader["BloodType"].ToString()) ? "N/A" : reader["BloodType"].ToString();
                                    string rh = string.IsNullOrWhiteSpace(reader["Rh"].ToString()) ? "N/A" : reader["Rh"].ToString();
                                    string numberOfChildren = string.IsNullOrWhiteSpace(reader["NumberOfChildren"].ToString()) ? "N/A" : reader["NumberOfChildren"].ToString();
                                    string lmpStatus = string.IsNullOrWhiteSpace(reader["LMPStatus"].ToString()) ? "N/A" : reader["LMPStatus"].ToString();
                                    string mensesMonthlyYes = string.IsNullOrWhiteSpace(reader["MensesMonthlyYes"].ToString()) ? "N/A" : reader["MensesMonthlyYes"].ToString();
                                    string mensesMonthlyNo = string.IsNullOrWhiteSpace(reader["MensesMonthlyNo"].ToString()) ? "N/A" : reader["MensesMonthlyNo"].ToString();
                                    string mensesFreq = string.IsNullOrWhiteSpace(reader["MensesFreq"].ToString()) ? "N/A" : reader["MensesFreq"].ToString();
                                    string medicalHistoryNotes = string.IsNullOrWhiteSpace(reader["MedicalHistoryNotes"].ToString()) ? "N/A" : reader["MedicalHistoryNotes"].ToString();
                                    string hxObtainedBy = string.IsNullOrWhiteSpace(reader["HxObtainedBy"].ToString()) ? "N/A" : reader["HxObtainedBy"].ToString();


                                    generalMedicalHistory = $"--- General Medical History ---\n" +
                                                            $"Marital Status: {maritalStatusGMH}\n" +
                                                            $"Education: {education}\n" +
                                                            $"Behavioral History: {behavioralHistory}\n" +
                                                            $"Tobacco: {tobacco} (Quantity: {tobaccoQuantity}, Duration: {tobaccoDuration})\n" +
                                                            $"Alcohol: {alcohol} (Quantity: {alcoholQuantity}, Duration: {alcoholDuration})\n" +
                                                            $"Drug: {drug} (Type: {drugType}, Duration: {drugDuration})\n" +
                                                            $"Dietary: {dietary}\n" +
                                                            $"Blood Type: {bloodType}\n" +
                                                            $"Rh: {rh}\n" +
                                                            $"Number of Children: {numberOfChildren}\n" +
                                                            $"LMP Status: {lmpStatus}\n" +
                                                            $"Menses Monthly Yes: {mensesMonthlyYes}\n" +
                                                            $"Menses Monthly No: {mensesMonthlyNo}\n" +
                                                            $"Menses Frequency: {mensesFreq}\n" +
                                                            $"Medical History Notes: {medicalHistoryNotes}\n" +
                                                            $"Hx Obtained By: {hxObtainedBy}\n\n";
                                }

                                // Store allergy information
                                string allergen = string.IsNullOrWhiteSpace(reader["Allergen"].ToString()) ? "N/A" : reader["Allergen"].ToString();
                                string allergyStartDate = string.IsNullOrWhiteSpace(reader["AllergyStartDate"].ToString()) ? "N/A" : reader["AllergyStartDate"].ToString();
                                string allergyEndDate = string.IsNullOrWhiteSpace(reader["AllergyEndDate"].ToString()) ? "N/A" : reader["AllergyEndDate"].ToString();
                                string allergyDescription = string.IsNullOrWhiteSpace(reader["AllergyDescription"].ToString()) ? "N/A" : reader["AllergyDescription"].ToString();

                                allergies.Add($"Allergen: {allergen}\nStart Date: {allergyStartDate}\nEnd Date: {allergyEndDate}\nDescription: {allergyDescription}\n");

                                // Store family history information
                                string familyName = string.IsNullOrWhiteSpace(reader["Name"].ToString()) ? "N/A" : reader["Name"].ToString();
                                string relation = string.IsNullOrWhiteSpace(reader["Relation"].ToString()) ? "N/A" : reader["Relation"].ToString();
                                string alive = string.IsNullOrWhiteSpace(reader["Alive"].ToString()) ? "Not Provided" : reader["Alive"].ToString();
                                string livesWithPatient = string.IsNullOrWhiteSpace(reader["Liveswithpatient"].ToString()) ? "Not Provided" : reader["Liveswithpatient"].ToString();
                                string majorDisorder = string.IsNullOrWhiteSpace(reader["MajorDisorder"].ToString()) ? "Not Provided" : reader["MajorDisorder"].ToString();
                                string specificTypeDisorder = string.IsNullOrWhiteSpace(reader["SpecificTypeDisorder"].ToString()) ? "Not Provided" : reader["SpecificTypeDisorder"].ToString();

                                // Add the formatted information to the familyHistory list
                                familyHistory.Add($"Family Name: {familyName}\nRelation: {relation}\nAlive: {alive}\nLives With Patient: {livesWithPatient}\nMajor Disorder: {majorDisorder}\nSpecific Type of Disorder: {specificTypeDisorder}\n");

                            }

                            // Append General Medical History section only once
                            reportContent += generalMedicalHistory;

                            // Append all collected allergy data only once
                            // Append only unique allergy data if there are any records in the list
                            if (allergies.Count > 0) // Checks if the list contains any elements
                            {
                                reportContent += "--- Allergy History ---\n";
                                foreach (var allergy in allergies.Distinct()) // Get distinct records
                                {
                                    reportContent += allergy + "\n";  // Print each unique allergy record
                                }
                            }



                            // Append all collected family history data only once
                            if (familyHistory.Count > 0)
                            {
                                reportContent += "--- Family History ---\n";
                                foreach (var family in familyHistory.Distinct())
                                {
                                    reportContent += family + "\n";
                                }
                            }


                            // Dynamically create the file name using the patient's name and timestamp
                            string fileName = $"{patientName.Replace(" ", "_")}.txt";
                            string filePath = Path.Combine(baseDirectory, fileName);

                            try
                            {
                                // Create a new file each time (FileMode.Create ensures that existing files are overwritten)
                                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                                using (StreamWriter writer = new StreamWriter(fs))
                                {
                                    writer.Write(reportContent);
                                }

                                // Notify the user that the report was generated
                                MessageBox.Show($"Patient report for {patientName} has been generated successfully at {filePath}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while creating the report: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No data found for Patient ID {form.PatientIdSF}.");
                        }


                    }
                }
            }
        }


    }
}
