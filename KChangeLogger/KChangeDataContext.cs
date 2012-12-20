using System.Collections.Generic;
using System.Linq;
using System;

namespace KChangeLogger
{
    /// <summary>
    /// Data Access Layer for KChange
    /// </summary>
    partial class KChangeDataContextDataContext
    {

        #region Project handling

        /// <summary>
        /// Function used to obtain a Project entity based on the name
        /// </summary>
        /// <param name="projectName">The name of the project to be retreived</param>
        /// <returns>null if not found, Project Entity if found</returns>
        public Project GetProject(string projectName)
        {
            try
            {
                return (from p in Projects
                        where p.Name == projectName
                        select p).First();
            }
            catch (Exception ex)
            {
                //TODO: Add exception handling, Karol 11.12.2012
                return null;
            }
        }
        /// <summary>
        /// Function used to obtain a Project entity based on the ID
        /// </summary>
        /// <param name="projectID">The id of the project to be retreived</param>
        /// <returns>null if not found, Project Entity if found</returns>
        public Project GetProject(int projectID)
        {
            try
            {
                return (from p in Projects
                        where p.ID == projectID
                        select p).First();
            }
            catch (Exception ex)
            {
                //TODO: Add exception handling, Karol 11.12.2012
                return null;
            }
        }
        /// <summary>
        /// Attemps to add a Project entity into the Projects EntitySet of the Context
        /// </summary>
        /// <param name="theProject">Project Entity to be inserted</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool AddProject(Project theProject)
        {
            try
            {
                Projects.InsertOnSubmit(theProject);
                SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: 17.12.2012 add proper exception handling.
                return false;
            }
        }
        /// <summary>
        /// Attemps to remove a Project Entity from the Projects EntitySet
        /// </summary>
        /// <param name="theProject">The Project Entity to be removed</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool RemoveProject(Project theProject)
        {
            try
            {
                Projects.DeleteOnSubmit(theProject);
                SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: 17.12.2012 Karol, add proper exception handling
                return false;
            }

        }

        #endregion

        #region Project->File handling

        /// <summary>
        /// Obtains a list of Project_File entity attached to a given Project entity found by string projectName
        /// </summary>
        /// <param name="projectName">string by which the project is to be found</param>
        /// <returns>(Empty) list of files per project name</returns>
        public List<Project_File> GetFilesByProject(string projectName)
        {
            List<Project_File> returnList = new List<Project_File>();

            returnList = (from f in Project_Files
                         where f.Project.Name == projectName
                         select f).ToList();

            return returnList;
        }
        /// <summary>
        /// Obtains a list of Project_File entity attached to a given Project entity found by int projectID
        /// </summary>
        /// <param name="projectID">int by which the project entity is to be found</param>
        /// <returns>(Empty) list of files per project name</returns>
        public List<Project_File> GetFilesByProject(int projectID)
        {
            List<Project_File> returnList = new List<Project_File>();

            returnList = (from f in Project_Files
                          where f.Project.ID == projectID
                          select f).ToList();

            return returnList;
        }
        /// <summary>
        /// Obtains a list of Project_File entity attached to a given Project entity found by the Project entity
        /// </summary>
        /// <param name="theProject">Project entity whose Files are to be returned</param>
        /// <returns>(Empty) list of files per project name</returns>
        public List<Project_File> GetFilesByProject(Project theProject)
        {
            List<Project_File> returnList = new List<Project_File>();

            returnList = (from f in Project_Files
                          where f.Project == theProject
                          select f).ToList();

            return returnList;
        }
        /// <summary>
        /// Obtains a List of all File Names attached to a given Project Entity.
        /// </summary>
        /// <param name="theProject">Project Entity whose File Names are to be returned</param>
        /// <returns></returns>
        public List<string> GetFileNamesByProject(Project theProject)
        {
            List<string> returnList = new List<string>();

            returnList = (from f in Project_Files
                          where f.Project == theProject
                          select f.File_Name).ToList();

            return returnList;

        }
        /// <summary>
        /// Returns the number of Project_Files of a given Project
        /// </summary>
        /// <param name="theProject">The Project Entity</param>
        /// <returns>Number of files</returns>
        public int GetNumberOfFilesByProject(Project theProject)
        {
            return theProject.Project_Files.Count;
        }
        /// <summary>
        /// Gets a reference to a Project File Entity of a given Project entity based on fileName
        /// </summary>
        /// <param name="theProject">Project Entity whose Project File is to be returned</param>
        /// <param name="fileName">Name of the Project file to be returned</param>
        /// <returns></returns>
        public Project_File GetFileByName(Project theProject, string fileName)
        {
            //TODO: Double files may have the same values. Perhaps add a unique key?
            try
            {
                return (from pf in Project_Files
                        where pf.File_Name == fileName
                        select pf).First();
            }
            catch (Exception ex)
            {
                //TODO: Add proper event handling
                return null;
            }
        }
        /// <summary>
        /// Attemps to remove a Project_File entity from the Project_Files EntitySet
        /// </summary>
        /// <param name="theFile">The Project_File Entity to be removed</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool RemoveFile(Project_File theFile)
        {
            try
            {
                Project_Files.DeleteOnSubmit(theFile);
                SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Add proper event handling
                return false;
            }
        }
        /// <summary>
        /// Attempts to attach a Project_File Entity to Project_Files EntitySet
        /// </summary>
        /// <param name="theFile">Project_File Entity to be attached</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool AddFile(Project_File theFile)
        {
            try
            {
                Project_Files.InsertOnSubmit(theFile);
                SubmitChanges();
                return true;
            }
            catch
            {
                // Karol: 19.12.2012, add proper handling.
                return false;
            }
        }
        /// <summary>
        /// Attempts to find a given Project_File Entity from theProject's Project_Files EntitySet 
        /// </summary>
        /// <param name="theProject">Project whose Project_File is to be found</param>
        /// <param name="fileName">The File Name of the file to be found</param>
        /// <returns>true upon found, false upon not found</returns>
        public bool DoesFileExist(Project theProject, string fileName)
        {
            var query = (from pf in Project_Files
                         where pf.Project == theProject && pf.File_Name == fileName
                         select pf).ToList();

            return query.Count > 0;
        }

        #endregion

        #region Project->Project_Change handling

        /// <summary>
        /// Obtains the datetime assigned to the last change of a given Project Entity
        /// </summary>
        /// <param name="theProject">The given Project entity whose last change is to be returned</param>
        /// <returns>The current time, -30 years if there has not been a change yet
        /// The last change from the Database if a change has been registered.
        /// </returns>
        public DateTime GetLastChange(Project theProject)
        {
            try
            {
                return (from pc in Project_Changes
                        where pc.Project == theProject
                        orderby pc.ChangeDate descending
                        select pc.ChangeDate).First();
            }
            catch (Exception ex)
            {
                //TODO: Add Exception logging class. Karol 11.12.2012.
                return DateTime.Now.AddYears(-30);
            }
        }
        /// <summary>
        /// Attempts to return a List of Project_Change Entities of a Project Entity
        /// </summary>
        /// <param name="theProject">Project Entity whose Project_Changes are to be returned</param>
        /// <returns>List of Project Change Entities</returns>
        public List<Project_Change> GetChangesByProject(Project theProject)
        {
            return (from pc in theProject.Project_Changes
                    select pc).ToList();
        }
        /// <summary>
        /// Attempts to Obtain a Project_Change Entity based on the ID value
        /// </summary>
        /// <param name="theID">the ID of Project_Change to be found</param>
        /// <returns>Project_Change entity upon success, null upon failure</returns>
        public Project_Change GetChangeById(int theID)
        {
            try
            {
                return (from ch in Project_Changes
                        where ch.ID_Change == theID
                        select ch).First();

            }
            catch (Exception ex)
            {
                //TOOD: 18.12.2012 - add exception handling
                return null;
            }
        }
        /// <summary>
        /// Attempts to insert a given Project_Change Entity into Project_Changes EntitySet
        /// </summary>
        /// <param name="theChange">The Project_Change Entity to be inserted</param>
        /// <returns>Project_Change entity upon success, null upon failure</returns>
        public bool InsertChange(Project_Change theChange)
        {
            try
            {
                Project_Changes.InsertOnSubmit(theChange);
                SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: 17.12.2012 Karol, add proper exception handling
                return false;
            }

        }

        #endregion

        #region Language handling

        /// <summary>
        /// Gets a given Language Entity based on its Description
        /// </summary>
        /// <param name="langDescription">Description of the Entity Language</param>
        /// <returns>Language Entity upon success, null upon failure</returns>
        public Language GetLanguage(string langDescription)
        {
            try
            {
                return (from l in Languages
                        where l.Description == langDescription
                        select l).First();
            }
            catch (Exception ex)
            {
                //TODO: Karol 12.12.2012 add proper exception handling/error logging.
                return null;
            }
        }
        /// <summary>
        /// Create a List of Strings based on the Language EntitySet's Description member
        /// </summary>
        /// <returns>A List of strings containing all Language Entity's Description values. Warning, List can also be empty.</returns>
        public List<string> GetLanguageDescriptions()
        {
            return (from l in Languages
                    select l.Description).ToList();
        }
        /// <summary>
        /// Attempts to find a Language Entity based on a languageName
        /// </summary>
        /// <param name="languageName">Description of the language to be found</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool DoesLanguageExist(string languageName)
        {
            var query = (from lg in Languages
                         where lg.Description == languageName
                         select lg).ToList();

            return query.Count > 0;
        }
        /// <summary>
        /// Attempts to Create a List of Project Entity whose Language1 Entity's Description matches languageName
        /// </summary>
        /// <param name="languageName">The Description parameter of the Language1 Entity</param>
        /// <returns>A list of Project Entities. WARNING, can be empty</returns>
        public List<Project> GetProjectsByLanguage(string languageName)
        {
            List<Project> retList = new List<Project>();

            retList = (from p in Projects
                       where p.Language1.Description == languageName
                       select p).ToList();

            return retList;
        }
        /// <summary>
        /// Attempts to Insert a new Language Entity into the Languages EntitySet
        /// </summary>
        /// <param name="newLanguage">Language Entity to be added</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool AddLanguage(Language newLanguage)
        {
            try
            {
                Languages.InsertOnSubmit(newLanguage);
                SubmitChanges();
                return true;
            }
            catch
            {
                //TODO: 20.12.2012 Karol, add proper exception handling
                return false;
            }

        }
        /// <summary>
        /// Attempts to Detach a Language Entity from the Languages EntitySet
        /// </summary>
        /// <param name="theLanguage">the Language Entity to be detached</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool RemoveLanguage(Language theLanguage)
        {
            try
            {
                Languages.DeleteOnSubmit(theLanguage);
                SubmitChanges();
                return true;
            }
            catch
            {
                //TODO: Karol 20.12.2012 add proper exception handling
                return false;
            }
        }

        #endregion

        #region Change Type handling

        /// <summary>
        /// Creates a List of Change_Type Entities from the Change_Types EntitySet
        /// </summary>
        /// <returns>List of Change_Type Entities. Warning, List can be empty</returns>
        public List<Change_Type> GetChangeTypes()
        {
            return (from ct in Change_Types
                    select ct).ToList();
        }
        /// <summary>
        /// Creates a List of strings containing all Change_Types Entities' Description member
        /// </summary>
        /// <returns>List of strings containing Description of each Change_Type Entity. Warning, list can be empty!</returns>
        public List<string> GetChangeTypesDescriptions()
        {
            return (from ct in Change_Types
                    select ct.Description).ToList();
        }
        /// <summary>
        /// Attempts to obtain a Change_Type Entity from the Change_Types EntitySet based on the description
        /// </summary>
        /// <param name="description">The description based on which the Change_Type is to be found</param>
        /// <returns>Change_Type Entity upon success, null upon failure</returns>
        public Change_Type GetChangeTypeByDescription(string description)
        {
            foreach (Change_Type cT in Change_Types)
            {
                if (cT.Description == description)
                    return cT;
            }
            //TODO: 18.12.2012, Karol, add proper exception handling
            return null;
        }
        /// <summary>
        /// Attempts to find a Change_Type entity based on its Description value
        /// </summary>
        /// <param name="description">The description based on which the Change_Type is to be found</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool DoesChangeTypeExist(string description)
        {
            var query = (from ch in Change_Types
                         where ch.Description == description
                         select ch).ToList();

            return query.Count > 0;
        }

        public bool InsertChangeType(Change_Type theChangeType)
        {
            try
            {
                Change_Types.InsertOnSubmit(theChangeType);
                SubmitChanges();
                return true;
            }
            catch
            {
                //TODO: Karol 20.12.2012 add proper exception handling
                return false;
            }
        }

        public bool RemoveChangeType(Change_Type theChangeType)
        {
            try
            {
                Change_Types.DeleteOnSubmit(theChangeType);
                SubmitChanges();
                return true;
            }
            catch
            {
                //TODO: Karol 20.12.2012 add proper exception handling
                return false;
            }
        }

        public List<Project_Change> GetChangesByChangeType(Change_Type theCT)
        {
            List<Project_Change> retList = new List<Project_Change>();
            retList = (from ch in Project_Changes
                       where ch.Change_Type == theCT
                       select ch).ToList();

            return retList;
        }

        #endregion

        #region Log handling

        /// <summary>
        /// Attempts to insert a Log Entity into the Logs EntitySet
        /// </summary>
        /// <param name="theLog">the Log Entity to be inserted</param>
        /// <returns>true upon success, false upon failure</returns>
        public bool AddLog(Log theLog)
        {
            try
            {
                Logs.InsertOnSubmit(theLog);
                SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Karol, add logging class 18.12.2012
                return false;
            }
        }

        #endregion

        #region Log->Log_Type handling
        
        /// <summary>
        /// Creates a List of Log_Type from the Log_Types EntitySet
        /// </summary>
        /// <returns>A List of Log_Type. WARNING, list can be empty</returns>
        public List<Log_Type> GetLogTypes()
        {
            return (from l in Log_Types
                    select l).ToList();
        }
        /// <summary>
        /// Creates a List of string containing each Log_Type's Description
        /// </summary>
        /// <returns>A list of string. WARNING, can be empty!</returns>
        public List<string> GetLogTypesDescriptions()
        {
            return (from l in Log_Types
                    select l.Description).ToList();
        }

        #endregion
    }
}
