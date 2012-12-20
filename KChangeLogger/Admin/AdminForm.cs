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
    /// <summary>
    /// Form responsible for changing some of the settings
    /// </summary>
    public partial class AdminForm : BaseClasses.BaseContextForm
    {
        public AdminForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            languagesComboBox.DataSource = Data.GetLanguageDescriptions();
            changeTypesComboBox.DataSource = Data.GetChangeTypesDescriptions();
        }

        private void ButtonAddLanguage_Click(object sender, EventArgs e)
        {
            AdminFormAddLanguage AFAL = new AdminFormAddLanguage();
            AFAL.ShowDialog();
            AFAL.Dispose();
            BindData();
        }

        private void ButtonDeleteLanguage_Click(object sender, EventArgs e)
        {
            // get the selected language string
            string theLang = (string)languagesComboBox.SelectedValue;

            if (String.IsNullOrEmpty(theLang))
            {
                MessageBox.Show("No language selected", "KChange: Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete " + theLang + "?", "KChange: Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            // check if there are any projects connected to the language:

            if(Data.GetProjectsByLanguage(theLang).Count > 0)
            {
                MessageBox.Show("There are still Projects using this language. Cannot delete!", "KChange: Error");
                return;
            }

            Language delLang = Data.GetLanguage(theLang);

            if (Data.RemoveLanguage(delLang))
                MessageBox.Show("Delete successful.", "KChange: Success");
            else
                MessageBox.Show("Delete failed.", "KChange: Error");

            BindData();

        }

        private void ButtonAddChangeType_Click(object sender, EventArgs e)
        {
            AdminFormAddChangeType AFACT = new AdminFormAddChangeType();
            AFACT.ShowDialog();
            AFACT.Dispose();
            BindData();
        }

        private void ButtonDeleteChangeType_Click(object sender, EventArgs e)
        {
            // get the Change object.
            string theChange = (string)changeTypesComboBox.SelectedValue;

            if (String.IsNullOrEmpty(theChange))
            {
                MessageBox.Show("You must select a Change Type!", "KChange: Error");
                return;
            }

            Change_Type newCT = Data.GetChangeTypeByDescription(theChange);
            if (newCT == null)
            {
                MessageBox.Show("There was a problem obtaining the Change_Type reference.", "KChange: Error");
                return;
            }

            if (Data.GetChangesByChangeType(newCT).Count > 0)
            {
                MessageBox.Show("There are Changes with this Change_Type. Cannot delete this Change Type.", "KChange: Error");
                return;
            }




            
        }
    }

    
}
