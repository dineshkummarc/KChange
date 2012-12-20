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
    /// Screen allowing you to edit a given Project data called from MaintenanceForm
    /// </summary>
    public partial class MaintenanceFormEdit : BaseClasses.BaseContextForm
    {
        private Project myProject;

        #region Constructor
        public MaintenanceFormEdit(ref Project theProject)
        {
            myProject = theProject;
            InitializeComponent();
            BindControls();
        }
        #endregion

        #region DataBinding
        /// <summary>
        /// Binds the Controls found on the form to myProject values
        /// </summary>
        private void BindControls()
        {
            tbProjectName.Text = myProject.Name;
            tbProjectPath.Text = myProject.Physical_Path;
            tbProjectDescription.Text = myProject.Description;
            liLanguage.DataSource = Data.GetLanguageDescriptions();
            //TODO: Why doesn't this work?
            //liLanguage.SelectedValue = myProject.Language1.Description;
            
        }
        #endregion

        #region Button Event Handlers
        /// <summary>
        /// Button responsible for committing the edited Project data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbProjectName.Text.Length < 3)
            {
                MessageBox.Show("Project Name should at least be 3 characters long.", "KChange: Error");
                return;
            }

            if (tbProjectPath.Text.Length < 3)
            {
                MessageBox.Show("Project Path should at least be 3 characters long", "KChange: Error");
                return;
            }

            if (tbProjectDescription.Text.Length < 3)
            {
                MessageBox.Show("Project Description should at least be 3 characters long", "KChange: Error");
                return;
            }

            myProject.Name = tbProjectName.Text;
            myProject.Physical_Path = tbProjectPath.Text;
            myProject.Description = tbProjectDescription.Text;
            //TODO: Karol 12.12.12 - check why below doesn't work...
            //myProject.Language1 = Data.GetLanguage((string)liLanguage.SelectedValue);

            try
            {
                Data.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error upon update!\n" + ex.Message);
                return;
            }

        }
        /// <summary>
        /// Button responsible for exiting the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: Add checks.. etc.
            this.Close();
        }
        #endregion
    }
}
