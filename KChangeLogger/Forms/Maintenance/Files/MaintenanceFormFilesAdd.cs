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
    /// A simple dialog for adding files. Can add files manually (inputting text) or use a OpenFileDialog.
    /// </summary>
    public partial class MaintenanceFormFilesAdd : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Project Entity
        /// </summary>
        private Project myProject;

        #region Constructor
        /// <summary>
        /// Initializes the form and assigns myProject
        /// </summary>
        /// <param name="theProjectID">the Project ID whose files will be added to</param>
        public MaintenanceFormFilesAdd(int theProjectID)
        {
            InitializeComponent();
            myProject = Data.GetProject(theProjectID);
        }
        #endregion

        #region Button Handlers
        /// <summary>
        /// Responsible for showing an OpenFileDialog. If user chooses a file sets the TextBoxes values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = fileDialog.FileName.Substring(fileDialog.FileName.LastIndexOf('\\') + 1);
                filePathTextBox.Text = fileDialog.FileName.Substring(0, fileDialog.FileName.LastIndexOf('\\') + 1);
            }
        }
        /// <summary>
        /// Responsible for adding the entered file to the Database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (Data.DoesFileExist(myProject, fileNameTextBox.Text))
            {
                MessageBox.Show("The file is already added to the project.", "KChange: Error");
                return;
            }

            Project_File newProjectFile = new Project_File();
            newProjectFile.File_Name = fileNameTextBox.Text;
            newProjectFile.File_Path = filePathTextBox.Text;
            newProjectFile.Project = myProject;


            if(!Data.AddFile(newProjectFile))
            {
                MessageBox.Show("Error upon adding!", "KChange: Error");
                return;
            }

            this.Close();

        }
        #endregion

        // exit form.
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
