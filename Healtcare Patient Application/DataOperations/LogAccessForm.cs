using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Healtcare_Patient_Application.DataOperations
{
    public static class LogAccessForm
    {
        private static readonly string logFilePath =
                @"D:\ITS-245 Final Project\Healtcare Patient Application\FormAccessLog.txt"; // Path to the log file

        public static class FormAccessLogger
        {
            
            public static void LogFormAccess(int loginID, string formName)
            {
                try
                {
                    // Construct the log message
                    string logEntry = $"{DateTime.Now}: User {loginID} accessed {formName}";

                    // Append the log entry to the file
                    File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    // Optionally handle any logging errors
                    Console.WriteLine($"Error logging form access: {ex.Message}");
                }
            }
        }

        public static void LogUserAction(int loginID, string formName, string actionDescription)
        {

            try
            {
                // Construct the log message for user action
                string logEntry = $"{DateTime.Now}: User {loginID} performed action: {actionDescription}";

                // Append the log entry to the file
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Handle any logging errors
                Console.WriteLine($"Error logging user action: {ex.Message}");
            }
        }

    }
}
