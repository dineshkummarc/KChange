using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KChangeLogger.Admin
{
    public partial class AdminFormAddChangeType : BaseClasses.BaseContextForm
    {
        public AdminFormAddChangeType()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            #region Data Validation

            if (String.IsNullOrEmpty(changeTypeTextBox.Text))
            {
                MessageBox.Show("Change Type cannot be empty.", "KChange: Error");
                return;
            }
            if (changeTypeTextBox.Text.Length > 25)
            {
                MessageBox.Show("Change Type cannot exceed 25 characters.", "KChange: Error");
                return;
            }
            if (Data.DoesChangeTypeExist(changeTypeTextBox.Text))
            {
                MessageBox.Show("Change Type already exists.", "KChange: Error");
                return;
            }

            #endregion

            #region DB Insert

            Change_Type newCT = new Change_Type();
            newCT.Description = changeTypeTextBox.Text;

            if (Data.InsertChangeType(newCT))
                MessageBox.Show("Change Type added!", "KChange: Success");
            else
                MessageBox.Show("Change Type adding failure!", "KChange: Failure");

            #endregion

            Close();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
