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
    public partial class AdminFormAddLanguage : BaseClasses.BaseContextForm
    {
        public AdminFormAddLanguage()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            #region Validation

            if (String.IsNullOrEmpty(languageTextBox.Text))
            {
                MessageBox.Show("Language name field was empty!", "KChange: Error");
                return;
            }

            if (languageTextBox.Text.Length > 25)
            {
                MessageBox.Show("Language name was more than 25 characters long.", "KChange: Error");
                return;
            }

            if (Data.DoesLanguageExist(languageTextBox.Text))
            {
                MessageBox.Show("Language name already exists!", "KChange: Error");
                return;
            }

            #endregion
            #region DB Insert

            Language newLanguage = new Language();
            newLanguage.Description = languageTextBox.Text;

            if (Data.AddLanguage(newLanguage))
            {
                MessageBox.Show("Language added successfully!", "KChange: Success");
            }
            else
            {
                MessageBox.Show("Language adding failed!", "KChange: Error");
            }

            #endregion

            Close();
        }
    }
}
