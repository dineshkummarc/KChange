namespace KChangeLogger
{
    partial class MaintenanceFormChanges
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
            this.button1 = new System.Windows.Forms.Button();
            this.ChangesGV = new System.Windows.Forms.DataGridView();
            this.ButtonExportCSV = new System.Windows.Forms.Button();
            this.ButtonExportTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChangesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangesGV
            // 
            this.ChangesGV.AllowUserToAddRows = false;
            this.ChangesGV.AllowUserToDeleteRows = false;
            this.ChangesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChangesGV.Location = new System.Drawing.Point(12, 12);
            this.ChangesGV.Name = "ChangesGV";
            this.ChangesGV.ReadOnly = true;
            this.ChangesGV.Size = new System.Drawing.Size(437, 141);
            this.ChangesGV.TabIndex = 0;
            this.ChangesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangesGV_CellContentClick);
            this.ChangesGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangesGV_CellDoubleClick);
            // 
            // ButtonExportCSV
            // 
            this.ButtonExportCSV.Location = new System.Drawing.Point(12, 159);
            this.ButtonExportCSV.Name = "ButtonExportCSV";
            this.ButtonExportCSV.Size = new System.Drawing.Size(95, 23);
            this.ButtonExportCSV.TabIndex = 2;
            this.ButtonExportCSV.Text = "Export to CSV";
            this.ButtonExportCSV.UseVisualStyleBackColor = true;
            this.ButtonExportCSV.Click += new System.EventHandler(this.ButtonExportCSV_Click);
            // 
            // ButtonExportTXT
            // 
            this.ButtonExportTXT.Location = new System.Drawing.Point(113, 159);
            this.ButtonExportTXT.Name = "ButtonExportTXT";
            this.ButtonExportTXT.Size = new System.Drawing.Size(95, 23);
            this.ButtonExportTXT.TabIndex = 3;
            this.ButtonExportTXT.Text = "Export to TXT";
            this.ButtonExportTXT.UseVisualStyleBackColor = true;
            this.ButtonExportTXT.Click += new System.EventHandler(this.ButtonExportTXT_Click);
            // 
            // MaintenanceFormChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 187);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonExportTXT);
            this.Controls.Add(this.ButtonExportCSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangesGV);
            this.Name = "MaintenanceFormChanges";
            this.Text = "Project Changes";
            ((System.ComponentModel.ISupportInitialize)(this.ChangesGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChangesGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonExportCSV;
        private System.Windows.Forms.Button ButtonExportTXT;
    }
}