namespace Modern_DataGridView_Design
{
    partial class UCRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.tabLayPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.tabLayPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelTitle.Controls.Add(this.tabLayPanelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(1, 1);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(998, 38);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // tabLayPanelTitle
            // 
            this.tabLayPanelTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.tabLayPanelTitle.ColumnCount = 6;
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabLayPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabLayPanelTitle.Controls.Add(this.lblJob, 5, 0);
            this.tabLayPanelTitle.Controls.Add(this.lblEducation, 4, 0);
            this.tabLayPanelTitle.Controls.Add(this.lblCity, 3, 0);
            this.tabLayPanelTitle.Controls.Add(this.lblPhone, 2, 0);
            this.tabLayPanelTitle.Controls.Add(this.lblFullName, 1, 0);
            this.tabLayPanelTitle.Controls.Add(this.lblID, 0, 0);
            this.tabLayPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayPanelTitle.Name = "tabLayPanelTitle";
            this.tabLayPanelTitle.RowCount = 1;
            this.tabLayPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanelTitle.Size = new System.Drawing.Size(998, 38);
            this.tabLayPanelTitle.TabIndex = 0;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJob.Location = new System.Drawing.Point(857, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(138, 38);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.BackColor = System.Drawing.Color.Transparent;
            this.lblEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEducation.Location = new System.Drawing.Point(715, 0);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(136, 38);
            this.lblEducation.TabIndex = 4;
            this.lblEducation.Text = "Education";
            this.lblEducation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEducation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(526, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(183, 38);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(337, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(183, 38);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFullName.Location = new System.Drawing.Point(53, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(278, 38);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFullName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 38);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseClick);
            // 
            // UCRow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCRow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(1000, 40);
            this.panelTitle.ResumeLayout(false);
            this.tabLayPanelTitle.ResumeLayout(false);
            this.tabLayPanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TableLayoutPanel tabLayPanelTitle;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblID;
    }
}
