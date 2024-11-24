using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healtcare_Patient_Application;
using Healthcare_Patient_Application;
using Healthcare_Patient_Application.DataOperations;
using MySql.Data.MySqlClient;
using static Healtcare_Patient_Application.DataOperations.LogAccessForm;
using static Healtcare_Patient_Application.DataOperations.LoginSession;

namespace Healtcare_Patient_Application.DataOperations
{
    internal class LoginDBOperations
    {

        public static void GetLoginID(Login_Form form)
        {
            using (MySqlConnection connection = GMHDBOperations.MakeConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("GetLoginID", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add input parameters
                        command.Parameters.AddWithValue("p_UserName", form.User);
                        command.Parameters.AddWithValue("p_Password", form.Pass);

                        // Add output parameter
                        MySqlParameter outputParam = new MySqlParameter("p_loginID", MySqlDbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Execute the procedure
                        command.ExecuteNonQuery();

                        object loginIDValue = outputParam.Value;
                        
                        if (loginIDValue != DBNull.Value)
                        {
                            GlobalSession.LoginID = Convert.ToInt32(loginIDValue);

                            MessageBox.Show("Login successful!", "Success");

                            // Log the access
                            FormAccessLogger.LogFormAccess(GlobalSession.LoginID, "Login_Form");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while trying to login: {ex.Message}");
                }


            }

        }






    }
}
