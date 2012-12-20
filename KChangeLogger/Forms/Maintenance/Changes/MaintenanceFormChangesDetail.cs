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
    /// Form containing detailed Changes information of a given change. Called from MaintenanceFormChanges
    /// </summary>
    public partial class MaintenanceFormChangesDetail : BaseClasses.BaseContextForm
    {
        /// <summary>
        /// Calls BindElements
        /// </summary>
        /// <param name="changeId">the ID of Project_Change whose data is to be bound</param>
        public MaintenanceFormChangesDetail(int changeId)
        {
            InitializeComponent();
            BindElements(changeId);
        }

        /// <summary>
        /// Binds Project_Change data on the form.
        /// </summary>
        /// <param name="changeId">Project_Change ID to be loaded</param>
        private void BindElements(int changeId)
        {
            Project_Change theChange = Data.GetChangeById(changeId);
            changeChangedByLabel.Text = theChange.ChangedBy;
            changeChangedOnLabel.Text = theChange.ChangeDate.ToString();
            changeDescriptionTextBox.Text = theChange.ChangeDescription;
            changeChangedFileLabel.Text = theChange.Project_File == null ? "None" : theChange.Project_File.File_Name;
            // clear the text selection
            changeDescriptionTextBox.Focus();
        }

        /// <summary>
        /// OK Event Handler. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
