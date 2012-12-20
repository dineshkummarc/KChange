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
    /// The main screen fired upon application start
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// DAL
        /// </summary>
        private KChangeDataContextDataContext Data = new KChangeDataContextDataContext();
        /// <summary>
        /// the Project Entity loaded (or not)
        /// </summary>
        public Project currentProject;

        #region Constructor
        /// <summary>
        /// Initializes all designer controls.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Menu Event Handlers
        /// <summary>
        /// Responsible for loading the MainFormProjects view.
        /// Also sets the currentProject Project Entity value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Load the form as a Dialog Box, passing currentProject by reference.
            MainFormProjects projectSelectionForm = new MainFormProjects();
            projectSelectionForm.ShowDialog();
            currentProject = projectSelectionForm.myProject;
            projectSelectionForm.Dispose();
            if (currentProject != null)
                UpdateProjectLabel(true);
            else
                UpdateProjectLabel(false);

        }
        /// <summary>
        /// Responsible for showing the About screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutKChangeLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutKChange aboutDialog = new AboutKChange();
            aboutDialog.Show();
        }
        /// <summary>
        /// Responsible for Exitting the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Opens a new Instance of AdminForm and disposes it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.AdminForm AF = new Admin.AdminForm();
            AF.ShowDialog();
            AF.Dispose();
        }
        #endregion

        #region Misc usability functions
        /// <summary>
        /// Updates the Project Name label based on the given input Boolean
        /// Also updates the Enabled state of the MaintenanceButton
        /// </summary>
        /// <param name="updateMode">Boolean, if true - enable. If false - disable.
        /// </param>
        private void UpdateProjectLabel(Boolean updateMode)
        {
            if (updateMode)
            {
                projectNameLabel.Text = currentProject.Name;
                MaintenanceButton.Enabled = true;
            }
            else
            {
                projectNameLabel.Text = "None";
                MaintenanceButton.Enabled = false;
            }
        }
        #endregion

        #region Main Button Click!
        /// <summary>
        /// Responsible for showing the MaintenanceForm, practically the heart of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaintenanceButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm mForm = new MaintenanceForm(currentProject.ID);
            mForm.ShowDialog();
        }
        #endregion

        #region Unused event handlers
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
