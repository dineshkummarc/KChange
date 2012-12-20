namespace KChangeLogger
{
    partial class MaintenanceFormChangesDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changeChangedOnLabel = new System.Windows.Forms.Label();
            this.changeChangedFileLabel = new System.Windows.Forms.Label();
            this.changeChangedByLabel = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changed On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Changed File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // changeDescriptionTextBox
            // 
            this.changeDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.changeDescriptionTextBox.Location = new System.Drawing.Point(13, 93);
            this.changeDescriptionTextBox.Multiline = true;
            this.changeDescriptionTextBox.Name = "changeDescriptionTextBox";
            this.changeDescriptionTextBox.Size = new System.Drawing.Size(257, 80);
            this.changeDescriptionTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Changed By:";
            // 
            // changeChangedOnLabel
            // 
            this.changeChangedOnLabel.AutoSize = true;
            this.changeChangedOnLabel.Location = new System.Drawing.Point(90, 13);
            this.changeChangedOnLabel.Name = "changeChangedOnLabel";
            this.changeChangedOnLabel.Size = new System.Drawing.Size(35, 13);
            this.changeChangedOnLabel.TabIndex = 5;
            this.changeChangedOnLabel.Text = "label5";
            // 
            // changeChangedFileLabel
            // 
            this.changeChangedFileLabel.AutoSize = true;
            this.changeChangedFileLabel.Location = new System.Drawing.Point(90, 43);
            this.changeChangedFileLabel.Name = "changeChangedFileLabel";
            this.changeChangedFileLabel.Size = new System.Drawing.Size(19, 13);
            this.changeChangedFileLabel.TabIndex = 6;
            this.changeChangedFileLabel.Text = "cc";
            // 
            // changeChangedByLabel
            // 
            this.changeChangedByLabel.AutoSize = true;
            this.changeChangedByLabel.Location = new System.Drawing.Point(90, 187);
            this.changeChangedByLabel.Name = "changeChangedByLabel";
            this.changeChangedByLabel.Size = new System.Drawing.Size(19, 13);
            this.changeChangedByLabel.TabIndex = 7;
            this.changeChangedByLabel.Text = "cc";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(93, 226);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 8;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // MaintenanceFormChangesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.changeChangedByLabel);
            this.Controls.Add(this.changeChangedFileLabel);
            this.Controls.Add(this.changeChangedOnLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaintenanceFormChangesDetail";
            this.Text = "Change Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeDescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label changeChangedOnLabel;
        private System.Windows.Forms.Label changeChangedFileLabel;
        private System.Windows.Forms.Label changeChangedByLabel;
        private System.Windows.Forms.Button ButtonOK;
    }
}