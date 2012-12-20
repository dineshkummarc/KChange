namespace KChangeLogger
{
    partial class MaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.changeFileComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAddChange = new System.Windows.Forms.Button();
            this.changeByTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDescriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddChangeLabel = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ProjectLanguageLabel = new System.Windows.Forms.Label();
            this.ChangesButton = new System.Windows.Forms.Button();
            this.FilesButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.changeTypeComboBox);
            this.panel2.Controls.Add(this.changeFileComboBox);
            this.panel2.Controls.Add(this.ButtonCancel);
            this.panel2.Controls.Add(this.ButtonAddChange);
            this.panel2.Controls.Add(this.changeByTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.changeDescriptionTextBox);
            this.panel2.Controls.Add(this.ChangeDescriptionLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AddChangeLabel);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 238);
            this.panel2.TabIndex = 1;
            // 
            // changeTypeComboBox
            // 
            this.changeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeTypeComboBox.FormattingEnabled = true;
            this.changeTypeComboBox.Location = new System.Drawing.Point(96, 37);
            this.changeTypeComboBox.Name = "changeTypeComboBox";
            this.changeTypeComboBox.Size = new System.Drawing.Size(230, 21);
            this.changeTypeComboBox.TabIndex = 18;
            // 
            // changeFileComboBox
            // 
            this.changeFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeFileComboBox.FormattingEnabled = true;
            this.changeFileComboBox.Location = new System.Drawing.Point(95, 150);
            this.changeFileComboBox.Name = "changeFileComboBox";
            this.changeFileComboBox.Size = new System.Drawing.Size(231, 21);
            this.changeFileComboBox.TabIndex = 17;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(245, 204);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(78, 24);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "C&lear";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAddChange
            // 
            this.ButtonAddChange.Location = new System.Drawing.Point(161, 204);
            this.ButtonAddChange.Name = "ButtonAddChange";
            this.ButtonAddChange.Size = new System.Drawing.Size(78, 24);
            this.ButtonAddChange.TabIndex = 15;
            this.ButtonAddChange.Text = "&Add Change";
            this.ButtonAddChange.UseVisualStyleBackColor = true;
            this.ButtonAddChange.Click += new System.EventHandler(this.ButtonAddChange_Click);
            // 
            // changeByTextBox
            // 
            this.changeByTextBox.Location = new System.Drawing.Point(95, 178);
            this.changeByTextBox.Name = "changeByTextBox";
            this.changeByTextBox.Size = new System.Drawing.Size(231, 20);
            this.changeByTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Change By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Change File";
            // 
            // changeDescriptionTextBox
            // 
            this.changeDescriptionTextBox.Location = new System.Drawing.Point(95, 68);
            this.changeDescriptionTextBox.Multiline = true;
            this.changeDescriptionTextBox.Name = "changeDescriptionTextBox";
            this.changeDescriptionTextBox.Size = new System.Drawing.Size(231, 75);
            this.changeDescriptionTextBox.TabIndex = 10;
            // 
            // ChangeDescriptionLabel
            // 
            this.ChangeDescriptionLabel.AutoSize = true;
            this.ChangeDescriptionLabel.Location = new System.Drawing.Point(17, 68);
            this.ChangeDescriptionLabel.Name = "ChangeDescriptionLabel";
            this.ChangeDescriptionLabel.Size = new System.Drawing.Size(72, 13);
            this.ChangeDescriptionLabel.TabIndex = 9;
            this.ChangeDescriptionLabel.Text = "Change Desc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change Type";
            // 
            // AddChangeLabel
            // 
            this.AddChangeLabel.AutoSize = true;
            this.AddChangeLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChangeLabel.Location = new System.Drawing.Point(3, 7);
            this.AddChangeLabel.Name = "AddChangeLabel";
            this.AddChangeLabel.Size = new System.Drawing.Size(92, 16);
            this.AddChangeLabel.TabIndex = 6;
            this.AddChangeLabel.Text = "Add change:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(248, 299);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(94, 32);
            this.ButtonExit.TabIndex = 17;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ProjectLanguageLabel
            // 
            this.ProjectLanguageLabel.AutoSize = true;
            this.ProjectLanguageLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLanguageLabel.Location = new System.Drawing.Point(12, 4);
            this.ProjectLanguageLabel.Name = "ProjectLanguageLabel";
            this.ProjectLanguageLabel.Size = new System.Drawing.Size(49, 19);
            this.ProjectLanguageLabel.TabIndex = 6;
            this.ProjectLanguageLabel.Text = "label1";
            // 
            // ChangesButton
            // 
            this.ChangesButton.Location = new System.Drawing.Point(174, 26);
            this.ChangesButton.Name = "ChangesButton";
            this.ChangesButton.Size = new System.Drawing.Size(75, 23);
            this.ChangesButton.TabIndex = 3;
            this.ChangesButton.Text = "&Changes";
            this.ChangesButton.UseVisualStyleBackColor = true;
            this.ChangesButton.Click += new System.EventHandler(this.ChangesButton_Click);
            // 
            // FilesButton
            // 
            this.FilesButton.Location = new System.Drawing.Point(93, 26);
            this.FilesButton.Name = "FilesButton";
            this.FilesButton.Size = new System.Drawing.Size(75, 23);
            this.FilesButton.TabIndex = 2;
            this.FilesButton.Text = "&Files";
            this.FilesButton.UseVisualStyleBackColor = true;
            this.FilesButton.Click += new System.EventHandler(this.FilesButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 26);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "&Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.Location = new System.Drawing.Point(90, 6);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(96, 16);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "Project Name";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 333);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ProjectLanguageLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.ChangesButton);
            this.Controls.Add(this.FilesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MaintenanceForm";
            this.Text = "Maintenance Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddChangeLabel;
        private System.Windows.Forms.TextBox changeDescriptionTextBox;
        private System.Windows.Forms.Label ChangeDescriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeByTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddChange;
        private System.Windows.Forms.Button ChangesButton;
        private System.Windows.Forms.Button FilesButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label ProjectLanguageLabel;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ComboBox changeFileComboBox;
        private System.Windows.Forms.ComboBox changeTypeComboBox;
    }
}