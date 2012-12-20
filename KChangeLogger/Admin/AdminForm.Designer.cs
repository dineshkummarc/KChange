namespace KChangeLogger.Admin
{
    partial class AdminForm
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
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAddLanguage = new System.Windows.Forms.Button();
            this.ButtonDeleteLanguage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeTypesComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonAddChangeType = new System.Windows.Forms.Button();
            this.ButtonDeleteChangeType = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Location = new System.Drawing.Point(12, 25);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.Size = new System.Drawing.Size(169, 21);
            this.languagesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programming Languages";
            // 
            // ButtonAddLanguage
            // 
            this.ButtonAddLanguage.Location = new System.Drawing.Point(12, 52);
            this.ButtonAddLanguage.Name = "ButtonAddLanguage";
            this.ButtonAddLanguage.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddLanguage.TabIndex = 2;
            this.ButtonAddLanguage.Text = "Add new";
            this.ButtonAddLanguage.UseVisualStyleBackColor = true;
            this.ButtonAddLanguage.Click += new System.EventHandler(this.ButtonAddLanguage_Click);
            // 
            // ButtonDeleteLanguage
            // 
            this.ButtonDeleteLanguage.Location = new System.Drawing.Point(107, 52);
            this.ButtonDeleteLanguage.Name = "ButtonDeleteLanguage";
            this.ButtonDeleteLanguage.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteLanguage.TabIndex = 3;
            this.ButtonDeleteLanguage.Text = "Delete";
            this.ButtonDeleteLanguage.UseVisualStyleBackColor = true;
            this.ButtonDeleteLanguage.Click += new System.EventHandler(this.ButtonDeleteLanguage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Types";
            // 
            // changeTypesComboBox
            // 
            this.changeTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeTypesComboBox.FormattingEnabled = true;
            this.changeTypesComboBox.Location = new System.Drawing.Point(12, 98);
            this.changeTypesComboBox.Name = "changeTypesComboBox";
            this.changeTypesComboBox.Size = new System.Drawing.Size(169, 21);
            this.changeTypesComboBox.TabIndex = 5;
            // 
            // ButtonAddChangeType
            // 
            this.ButtonAddChangeType.Location = new System.Drawing.Point(12, 125);
            this.ButtonAddChangeType.Name = "ButtonAddChangeType";
            this.ButtonAddChangeType.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddChangeType.TabIndex = 6;
            this.ButtonAddChangeType.Text = "Add new";
            this.ButtonAddChangeType.UseVisualStyleBackColor = true;
            this.ButtonAddChangeType.Click += new System.EventHandler(this.ButtonAddChangeType_Click);
            // 
            // ButtonDeleteChangeType
            // 
            this.ButtonDeleteChangeType.Location = new System.Drawing.Point(107, 125);
            this.ButtonDeleteChangeType.Name = "ButtonDeleteChangeType";
            this.ButtonDeleteChangeType.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteChangeType.TabIndex = 7;
            this.ButtonDeleteChangeType.Text = "Delete";
            this.ButtonDeleteChangeType.UseVisualStyleBackColor = true;
            this.ButtonDeleteChangeType.Click += new System.EventHandler(this.ButtonDeleteChangeType_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "E&xit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 204);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ButtonDeleteChangeType);
            this.Controls.Add(this.ButtonAddChangeType);
            this.Controls.Add(this.changeTypesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDeleteLanguage);
            this.Controls.Add(this.ButtonAddLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languagesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "KChange Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languagesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAddLanguage;
        private System.Windows.Forms.Button ButtonDeleteLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox changeTypesComboBox;
        private System.Windows.Forms.Button ButtonAddChangeType;
        private System.Windows.Forms.Button ButtonDeleteChangeType;
        private System.Windows.Forms.Button button5;
    }
}