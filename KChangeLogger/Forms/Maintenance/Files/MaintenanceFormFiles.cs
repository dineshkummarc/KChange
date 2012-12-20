using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KChangeLogger
{
    /// <summary>
    /// Form showing the files currently linked on the given loaded project. Loaded from MaintenanceForm
    /// </summary>
    public partial class MaintenanceFormFiles : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Project Entity used for all the data binding and operations
        /// </summary>
        private Project myProject;

        #region Constructor
        /// <summary>
        /// Initializes the form, loads the myProject object.
        /// Calls BindListBox
        /// </summary>
        /// <param name="theProjectID">ID of the project for DAL assigning</param>
        public MaintenanceFormFiles(int theProjectID)
        {
            InitializeComponent();
            myProject = Data.GetProject(theProjectID);
            BindListBox();
        }
        #endregion

        #region DataBinding
        /// <summary>
        /// Sets the filesListBox DataSource.
        /// </summary>
        private void BindListBox()
        {
            filesListBox.DataSource = Data.GetFileNamesByProject(myProject);
        }
        #endregion

        #region Button Handlers
        /// <summary>
        /// Responsible for showing the MaintenanceFormFilesAdd form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MaintenanceFormFilesAdd mFfAdd = new MaintenanceFormFilesAdd(myProject.ID);
            mFfAdd.ShowDialog();
            BindListBox();
            mFfAdd.Dispose();
        }
        /// <summary>
        /// Responsible for deleting a given file from within the fileListBox Control and from the Database itself.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //TODO: Add checks, are you sure etc?
            //TODO: Add logging, Removed File.. etc..

            Project_File selectedFile = Data.GetFileByName(myProject, (string) filesListBox.SelectedValue);
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the file " + selectedFile.File_Name + "?", "KChange: Are you sure?", MessageBoxButtons.OKCancel);

            if (dr == System.Windows.Forms.DialogResult.Cancel)
                return;

            // TODO: Move deletion to model

            if (Data.RemoveFile(selectedFile))
                MessageBox.Show("File removed.", "KChange: Success");
            else
                MessageBox.Show("File removal failure.", "KChange: Error.");

            BindListBox();
        }
        #endregion

        // exit form.
        /// <summary>
        /// Button responsible for closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}