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
    /// The Main Form containing changes information of a given Project Entity
    /// </summary>
    public partial class MaintenanceFormChanges : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// The Project Entity whose Changes are to be displayed
        /// </summary>
        Project myProject;

        /// <summary>
        /// Calls LoadGridView and assigns myProject value
        /// </summary>
        /// <param name="projectID">The Project ID to be assigned for myProject</param>
        public MaintenanceFormChanges(int projectID)
        {
            InitializeComponent();
            myProject = Data.GetProject(projectID);
            LoadGridView();
        }

        /// <summary>
        /// Exit Button event handler. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Populates ChangesGV
        /// </summary>
        private void LoadGridView()
        {
            //TODO: Probably create a method in the model?...
            // or somewhere else.. this looks too messy.
            if (Data.GetChangesByProject(myProject).Count < 1)
            {
                MessageBox.Show("There are no changes yet!", "KChange: Error");
                return;
            }

            ChangesGV.DataSource = (from ch in Data.GetChangesByProject(myProject)
                                    select new
                                    {
                                        ID = ch.ID_Change,
                                        Date = ch.ChangeDate.ToShortDateString(),
                                        File = ch.Project_File == null ? "None" : ch.Project_File.File_Name.Substring(0, 7) + "..",
                                        Description = ch.ChangeDescription.Substring(0, 9) + "..",
                                        By = ch.ChangedBy,
                                        Type = ch.Change_Type.Description
                                    }).ToList();
            //TODO: itirate or something.. looks too ugly.
            ChangesGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ChangesGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ChangesGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ChangesGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ChangesGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void ChangesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Responsible for viewing the detail of a given Change Line from the ChangesGV Control
        /// Creates a new MaintenanceFormChangesDetail Instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangesGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the ID of the current selected row, to display information.
            int changeID = Convert.ToInt16(ChangesGV.Rows[e.RowIndex].Cells[0].Value);
                //TODO: Add exception handling
                if (changeID <= 0 || changeID == null)
                    return;

                MaintenanceFormChangesDetail mFCD = new MaintenanceFormChangesDetail(changeID);
                mFCD.ShowDialog();
                mFCD.Dispose();
        }

        /// <summary>
        /// ExportTXT Event Handler.
        /// Shows the user a SaveFileDialog and calls Utilities.KTextWriter.WriteTXT.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExportTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = myProject.Name + " Changelog.txt";
            fd.Filter = "Text files (*.txt)|*.txt";
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled.", "KChange");
                return;
            }
            if (Utilities.KTextWriter.WriteTXT(fd.InitialDirectory, fd.FileName, myProject, true))
                MessageBox.Show("Export successful.", "KChange: Success");
            else
                MessageBox.Show("Export failed.", "KChange: Error");

             
        }
        /// <summary>
        /// ExportCSV Event Handler.
        /// Shows the User a SaveFileDialog and calls Utilities.KTextWriter.WriteCSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = myProject.Name + " Changelog.csv";
            fd.Filter = "CSV files (*.csv)|*.csv";
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled.", "KChange");
                return;
            }
            if (Utilities.KTextWriter.WriteCSV(fd.InitialDirectory, fd.FileName, myProject, true))
                MessageBox.Show("Export successful.", "KChange: Success");
            else
                MessageBox.Show("Export failed.", "KChange: Error");

        }
    }
}
