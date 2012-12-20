namespace KChangeLogger
{
    partial class MainFormProjects
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
            this.ProjectsGV = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectsGV
            // 
            this.ProjectsGV.AllowUserToAddRows = false;
            this.ProjectsGV.AllowUserToDeleteRows = false;
            this.ProjectsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGV.Location = new System.Drawing.Point(13, 13);
            this.ProjectsGV.MultiSelect = false;
            this.ProjectsGV.Name = "ProjectsGV";
            this.ProjectsGV.ReadOnly = true;
            this.ProjectsGV.Size = new System.Drawing.Size(432, 184);
            this.ProjectsGV.TabIndex = 0;
            this.ProjectsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGV_CellClick);
            this.ProjectsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGV_CellContentClick);
            this.ProjectsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGV_CellDoubleClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(452, 71);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "&Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(452, 13);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "&New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(452, 174);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(452, 42);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainFormProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 209);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ProjectsGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFormProjects";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectsGV;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}