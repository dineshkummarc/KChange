using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace KChangeLogger
{
    /// <summary>
    /// Screen allowing you to quickly add a Project change. Heart of the application.
    /// </summary>
    public partial class MaintenanceForm : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Project Entity loaded from within MainForm
        /// </summary>
        private Project myProject;

        #region Constructor
        /// <summary>
        /// Loads the controls, myProject entity and calls BindControls()
        /// </summary>
        /// <param name="theProjectID">the ID of the Project Entity to be loaded</param>
        public MaintenanceForm(int theProjectID)
        {
            myProject = Data.GetProject(theProjectID);
            InitializeComponent();
            BindControls();
        }
        #endregion

        #region Main panel button clicks
        /// <summary>
        /// Handles the situation where the user clicked on Clear, removes input in all input controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        /// <summary>
        /// Main function of the form - Manages the Adding of a New Change to a selected Project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddChange_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!ValidateChangeInput().Equals("OK"))
            {
                MessageBox.Show(ValidateChangeInput(), "KChange: Incorrect input");
                return;
            }
            #endregion
            #region Adding Change into DB
            Project_Change newChange = new Project_Change();

            newChange.Change_Type = Data.GetChangeTypeByDescription((string)changeTypeComboBox.SelectedValue);
            newChange.Project = myProject;
            newChange.ChangeDescription = changeDescriptionTextBox.Text;
            newChange.Project_File = Data.GetFileByName(myProject, (string)changeFileComboBox.SelectedValue);
            newChange.ChangedBy = changeByTextBox.Text;
            newChange.ChangeDate = DateTime.Now;

            if (Data.InsertChange(newChange))
            {
                MessageBox.Show("Change added!", "KChange: Success");
                ClearControls();
            }
            else
                MessageBox.Show("Change adding failed.", "KChange: Error");
            #endregion
        }
        #endregion

        #region DataBinding
        /// <summary>
        /// Binds Controls on the basis of myProject
        /// </summary>
        public void BindControls()
        {
            // Bind the left panel: Project information etc.
            ProjectNameLabel.Text = myProject.Name;
            ProjectLanguageLabel.Text = myProject.Language1.Description;
            changeFileComboBox.DataSource = Data.GetFileNamesByProject(myProject);
            changeTypeComboBox.DataSource = Data.GetChangeTypesDescriptions();
            changeByTextBox.Text = WindowsIdentity.GetCurrent().Name;

        }
        #endregion

        #region Upper menu buttons clicks
        /// <summary>
        /// Handles the display of the MaintenanceFormChanges as ShowDialog and disposes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangesButton_Click(object sender, EventArgs e)
        {
            MaintenanceFormChanges mFC = new MaintenanceFormChanges(myProject.ID);
            mFC.ShowDialog();
            mFC.Dispose();
        }
        /// <summary>
        /// Handles the display of the MaintenanceFormEdit as ShowDialog and disposes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            MaintenanceFormEdit mfE = new MaintenanceFormEdit(ref myProject);
            mfE.ShowDialog();
            BindControls();
            mfE.Dispose();
        }
        /// <summary>
        /// Handles the display of the MaintenanceFormFiles as ShowDialog and disposes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesButton_Click(object sender, EventArgs e)
        {
            MaintenanceFormFiles mfF = new MaintenanceFormFiles(myProject.ID);
            mfF.ShowDialog();
            mfF.Dispose();
            BindControls();
        }
        #endregion

        #region Misc
        /// <summary>
        /// Clears the controls for new entry / refresh.
        /// </summary>
        private void ClearControls()
        {
            //changeFileComboBox.Text = "";
            //changeTypeComboBox.Text = "";
            changeDescriptionTextBox.Text = "";
            changeByTextBox.Text = WindowsIdentity.GetCurrent().Name;
        }
        #endregion

        #region DataValidation

        /// <summary>
        /// Checks whether given input on the form is correct.
        /// </summary>
        /// <returns>
        ///          "OK" if all input is valid
        ///          "Errmsg" if there is an error
        /// </returns>
        private string ValidateChangeInput()
        {
            //if (String.IsNullOrEmpty(changeFileComboBox.Text))
            //    return ""; <- we allow a change to be file-less

            if (String.IsNullOrEmpty(changeTypeComboBox.Text))
                return "Change Type has not been selected";

            if (String.IsNullOrEmpty(changeByTextBox.Text))
                return "Changed by is empty";

            if (String.IsNullOrEmpty(changeDescriptionTextBox.Text))
                return "Change description is empty";

            if (changeDescriptionTextBox.Text.Length < 10)
                return "Change description is too short";

            return "OK";
        }

        #endregion

        // exit form.
        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
