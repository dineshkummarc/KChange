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
    /// A Dialog used for creating a new Project Entity in the database
    /// </summary>
    public partial class MainFormProjectsNew : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Initializes the Form Controls, calls BindLanguagesListBox
        /// </summary>
        public MainFormProjectsNew()
        {
            InitializeComponent();
            BindLanguagesListBox();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Responsible for adding the data. Performs validation and displays a MessageBox telling the user whether adding the project succeeded or failed
        /// Also closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            #region Validation
            if (tbProjectName.Text.Length < 3)
            {
                MessageBox.Show("Project Name must be at least 3 characters long.", "Error");
                return;
            }

            if (tbProjectDescription.Text.Length < 3)
            {
                MessageBox.Show("Project Description must be at least 3 characters long", "Error");
                return;
            }

            if (Data.GetLanguage((string)liLanguage.SelectedValue) == null)
            {
                MessageBox.Show("You must select which programming language is used for the project.", "Error");
                return;
            }

            if (tbProjectPath.Text.Length < 3)
            {
                MessageBox.Show("Project Path must be at least 3 characters long.", "Error");
                return;
            }
            #endregion
            #region Inserting Project into DB

            KChangeDataContextDataContext theContext = new KChangeDataContextDataContext();
            Project newProject = new Project();

            newProject.Name = tbProjectName.Text;
            newProject.Description = tbProjectDescription.Text;
            newProject.Language1 = Data.GetLanguage((string)liLanguage.SelectedValue);
            newProject.Created = DateTime.Now;
            newProject.Physical_Path = tbProjectPath.Text;

            if (theContext.AddProject(newProject))
                MessageBox.Show("New Project added successfully.", "KChange: Success");
            else
                MessageBox.Show("New Project adding failed.", "KChange: Error");

            #endregion

            Close();
        }

        private void liLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Binds the liLanguage Control's DataSource
        /// </summary>
        private void BindLanguagesListBox()
        {
            var resultQuery = Data.GetLanguageDescriptions();
            liLanguage.DataSource = resultQuery;
        }
    }
}
