using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Battery_Notification
{
    // This is a class to write to the log file.
    class logWriter
    {
        public void writeLog(string logMessage)
        {
            DateTime today = DateTime.Now;
            string logLocation = Properties.Settings.Default.logLocation;
            string currentLogEntryTime = today.ToString("M/d/yyyy h:mm:ss tt");
            try
            {
                File.AppendAllText(logLocation, currentLogEntryTime + " - " + logMessage + Environment.NewLine);
            }
            catch
            {
                // Push out an error here in the future.
            }
        }
        public bool checkValidityLocation(string logLoc)
        {
            string logName = "batteryLog.txt";
            string finalPath;

            // Sanitize input
            string lastItem = logLoc.Substring(logLoc.Length-1, 1);
            if (lastItem == "\\")
            {
                // If the location is one that ends with a \ (Like C:\) just append the logName.
                finalPath = logLoc + logName;
            }
            else
            {
                // If the location is one without a \ (C:\Desktop), append a \logName.
                finalPath = logLoc + "\\" + logName;
            }

            try
            {
                // If accepted file does not exist, create it.
                // If creation fails, return 'false' specifying (usually) a permissions error.
                if (!File.Exists(finalPath))
                {
                    File.Create(finalPath).Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
