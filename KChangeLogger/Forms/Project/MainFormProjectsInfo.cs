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
    /// A pop-up containing all information regarding the selected Project. 
    /// </summary>
    public partial class MainFormProjectsInfo : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Public value indicating whether the form was Cancelled out.
        /// </summary>
        public bool Cancelled = false;
        /// <summary>
        /// Project Entity whose data is displayed
        /// </summary>
        private Project myProject;
        /// <summary>
        /// Initializes the form and calls BindData
        /// </summary>
        /// <param name="theProject"></param>
        public MainFormProjectsInfo(Project theProject)
        {
            InitializeComponent();
            myProject = theProject;
            BindData();
        }

        private void MainFormProjectsInfo_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Binds the Label Controls of the form with myProject Data.
        /// </summary>
        private void BindData()
        {
            ProjectNameLabel.Text = myProject.Name;
            ProjectDescriptionLabel.Text = myProject.Description;
            ProjectPathLabel.Text = myProject.Physical_Path;
            ProjectCreatedLabel.Text = myProject.Created.ToString();
            ProjectNumberOfFilesLabel.Text = Data.GetNumberOfFilesByProject(myProject).ToString();
            ProjectLastChangedLabel.Text = Data.GetLastChange(myProject).ToString();
        }
        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Closes the form, setting the Cancelled value to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            this.Close();
        }
    }
}
