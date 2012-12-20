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
    /// Screen showing all projects in a DataGridView. Called from MainForm
    /// </summary>
    public partial class MainFormProjects : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Project Entity, used in MainForm for loading the project.
        /// </summary>
        public Project myProject;
        
        /// <summary>
        /// Initializes the Controls, Resizes the GridView programmatically to match Data length.
        /// </summary>
        public MainFormProjects()
        {
            InitializeComponent();
            RefreshGridView();
            ResizeColumns();
        }

        #region DataBinding
        /// <summary>
        /// Used to Load/Refresh the GridView of MainFormProjects
        /// </summary>
        private void RefreshGridView()
        {
            var query = from p in Data.Projects
                        select new
                        {
                            Name = p.Name,
                            Lang = p.Language1.Description,
                            Created = p.Created,
                            Description = p.Description.Substring(0, 9) + "..",
                            LastChange = Data.GetLastChange(p)
                        };

            ProjectsGV.DataSource = query.ToList();
            ProjectsGV.ClearSelection();
        }
        /// <summary>
        /// Function used to resize the columns in the MainFormProject GridView
        /// </summary>
        private void ResizeColumns()
        {
            for (int i = 0; i < ProjectsGV.Columns.Count; i++)
                ProjectsGV.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.ColumnHeader);
        }
        #endregion
        #region Button On Clicks
        /// <summary>
        /// Handles NewButton's onClick event
        /// Creates a new Window that allows the user to create a new Project Entity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewButton_Click(object sender, EventArgs e)
        {
            MainFormProjectsNew newProjectForm = new MainFormProjectsNew();
            newProjectForm.ShowDialog();
            RefreshGridView();
        }
        /// <summary>
        /// Handles the DeleteButton onClick event.
        /// Deletes the given selected Project Entity attached to a given row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProjectsGV.SelectedRows.Count <= 0 || ProjectsGV.SelectedRows.Count > 1)
            {
                MessageBox.Show("One row must be selected for delete.");
                return;
            }

            // get the current project name via the Selected Row
            string projectName = (string)ProjectsGV.SelectedRows[0].Cells[0].Value;

            DialogResult dR = MessageBox.Show("You are about to delete " + projectName + "\nAre you sure?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (dR == DialogResult.Cancel)
                return;

            // Get the project reference by name
            Project projectToDel = Data.GetProject(projectName);
            if (projectToDel == null)
            {
                MessageBox.Show("There was a problem deleting this Project.", "Error");
                return;
            }

            if (Data.RemoveProject(projectToDel))
                MessageBox.Show("Project removed successfully.", "Success");
            else
                MessageBox.Show("Project removed failed.", "Error");

            RefreshGridView();

        }
        /// <summary>
        /// Cancells out the dialog, setting myProject to null.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            myProject = null;
            Close();
        }
        /// <summary>
        /// Button click handler used to refresh the GridView's contents manually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }
        #region Resizing Clicks - to be removed or rewritten

        private void ProjectsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResizeColumns();
        }
        private void ProjectsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResizeColumns();
        }

        #endregion
        /// <summary>
        /// Main Button click event handler, used to select the curProject field in the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myProject = Data.GetProject((string)ProjectsGV.Rows[e.RowIndex].Cells[0].Value);
            if (myProject == null)
            {
                MessageBox.Show("There was a problem loading this project.", "KChange: Error");
                return;
            }
            MainFormProjectsInfo infoForm = new MainFormProjectsInfo(myProject);
            infoForm.ShowDialog();
            if (infoForm.Cancelled == true)
            {
                myProject = null;
                infoForm.Dispose();
                return;
            }
            Close();
        }
        #endregion


    }
}
