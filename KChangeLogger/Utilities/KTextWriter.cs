using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace KChangeLogger.Utilities
{
    static class KTextWriter
    {
        public static bool WriteTXT(string path, string fileName, Project theProject, bool createDirectory = false)
        {
            // initialize data context

            KChangeDataContextDataContext dataContext = new KChangeDataContextDataContext();

            //TODO: Add Directory Checks and Creation to a seperate function within the object. 
            #region Directory Checks and Creation

            // check whether directory exists
            if (!Directory.Exists(path) && !createDirectory)
            {
                KLogger.Log("User attempted to Export Changes of project " + theProject.Name + " to TXT for: " + path + " / " + fileName + " but path was not found and createDirectory was false.", 4);
                throw new FileNotFoundException("Path: " + path + " was not found. createDirectory was set to false.");
            }
            else
            {
                Directory.CreateDirectory(path);
                KLogger.Log("Created directory " + path + " for project " + theProject.Name, 1);
            }
            #endregion

            #region Data Fetching from the DAL and manipulation

            // Organize by day first.
            List<Project_Change> changes = new List<Project_Change>();
            changes = dataContext.GetChangesByProject(theProject);

            // check whether the given project has any changes, if not, throw exception
            if (changes.Count < 1)
            {
                KLogger.Log("The number of changes attached to project " + theProject.Name + " was less than 1.", 3);
                throw new ArgumentOutOfRangeException("The number of changes attached to the project " + theProject.Name + " is 0 or less.");
            }

            var sorted = from ch in changes
                         orderby ch.ChangeDate descending
                         select ch;

            #endregion

            #region Building the TXT Layout.

            StringBuilder sb = new StringBuilder();
            string lastDate = "";
            foreach (Project_Change lChange in sorted)
            {
                if (!String.Equals(lastDate, lChange.ChangeDate.ToLongDateString()))
                {
                    sb.AppendLine();
                    lastDate = lChange.ChangeDate.ToLongDateString();
                    sb.AppendLine("\t" + lastDate);
                }
                sb.AppendLine();
                sb.Append("\t\t-");
                sb.Append(lChange.Project_File == null ? "None" : lChange.Project_File.File_Name);
                sb.Append("\t");
                sb.Append(lChange.Change_Type.Description + " (lChange.ChangedBy)");
                sb.Append(": ");
                sb.Append(lChange.ChangeDescription);
            }

            #endregion

            #region Writing the TXT to File

            StreamWriter sw = new StreamWriter(fileName);

            try
            {
                sw.Write(sb.ToString());
                sw.Close();
            }
            catch
            {
                //TODO: Karol, add proper Exception handling.
                Debug.Print("OUCH! Could not open " + path + " / " + fileName);
                return false;
            }

            Debug.Print(sb.ToString());
            return true;

            #endregion
        }

        public static bool WriteCSV(string path, string fileName, Project theProject, bool createDirectory = false)
        {
            // initialize data context

            KChangeDataContextDataContext dataContext = new KChangeDataContextDataContext();

            //TODO: Add Directory Checks and Creation to a seperate function within the object. 
            #region Directory Checks and Creation

            // check whether directory exists
            if (!Directory.Exists(path) && !createDirectory)
            {
                KLogger.Log("User attempted to Export Changes of project " + theProject.Name + " to TXT for: " + path + " / " + fileName + " but path was not found and createDirectory was false.", 4);
                throw new FileNotFoundException("Path: " + path + " was not found. createDirectory was set to false.");
            }
            else
            {
                Directory.CreateDirectory(path);
                KLogger.Log("Created directory " + path + " for project " + theProject.Name, 1);
            }
            #endregion

            #region Getting Data from DAL and Sorting

            List<Project_Change> theChanges = dataContext.GetChangesByProject(theProject);

            // sort.

            var sortedChanges = from ch in theChanges
                                orderby ch.ChangeDate descending
                                select ch;

            #endregion

            #region Building the CSV file

            StringBuilder sb = new StringBuilder();

            foreach (Project_Change lChange in sortedChanges)
            {
                sb.Append(lChange.ID_Change);
                sb.Append(",");
                sb.Append(lChange.ChangeDate);
                sb.Append(",");
                sb.Append(lChange.ChangedBy);
                sb.Append(",");
                sb.Append(lChange.Change_Type.Description);
                sb.Append(",");
                sb.Append(lChange.Project_File == null ? "None" : lChange.Project_File.File_Name);
                sb.Append(",");
                sb.Append(lChange.ChangeDescription);
                sb.AppendLine();
            }

            #endregion

            #region Writing the CSV to file

            StreamWriter sw = new StreamWriter(fileName);

            try
            {
                // first write the column headers
                sw.WriteLine("ID,Date,Changed By,Change Type,Changed File,Change Description");
                sw.Write(sb.ToString());
                sw.Close();
            }
            catch
            {
                //TODO: Karol, add proper Exception handling.
                Debug.Print("OUCH! Could not open " + path + " / " + fileName);
                return false;
            }

            Debug.Print(sb.ToString());
            return true;


            #endregion

        }

    }
}
