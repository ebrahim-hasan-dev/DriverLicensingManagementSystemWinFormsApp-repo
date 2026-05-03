namespace DLMApp_PresentationLayer
{
    partial class fmManageApplicationsScreen
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
            this.components = new System.ComponentModel.Container();
            this.lbManageApplicationsScreen = new System.Windows.Forms.Label();
            this.btFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenseClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerInTestAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbSelectDate = new System.Windows.Forms.Label();
            this.lbNumberOfRowsResult = new System.Windows.Forms.Label();
            this.lbNumberOfRows = new System.Windows.Forms.Label();
            this.mtxtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageApplicationsScreen
            // 
            this.lbManageApplicationsScreen.AutoSize = true;
            this.lbManageApplicationsScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageApplicationsScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbManageApplicationsScreen.Location = new System.Drawing.Point(419, 9);
            this.lbManageApplicationsScreen.Name = "lbManageApplicationsScreen";
            this.lbManageApplicationsScreen.Size = new System.Drawing.Size(598, 51);
            this.lbManageApplicationsScreen.TabIndex = 32;
            this.lbManageApplicationsScreen.Text = "Manage Applications Screen";
            // 
            // btFilter
            // 
            this.btFilter.BackColor = System.Drawing.Color.Silver;
            this.btFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFilter.ForeColor = System.Drawing.Color.Black;
            this.btFilter.Image = global::DLMApp_PresentationLayer.Properties.Resources.ApplicationType;
            this.btFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFilter.Location = new System.Drawing.Point(756, 360);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(120, 40);
            this.btFilter.TabIndex = 52;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = false;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(135, 366);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(456, 28);
            this.cbFilter.TabIndex = 51;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Location = new System.Drawing.Point(7, 370);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(93, 20);
            this.lbFilterBy.TabIndex = 50;
            this.lbFilterBy.Text = "Filter By :";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.AllowUserToResizeRows = false;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApplicationID,
            this.colLicenseClass,
            this.colApplicationType,
            this.colApplicationStatus,
            this.colAddedDate,
            this.colLastUpdateDate,
            this.colFees,
            this.colPersonID,
            this.colPassedTests,
            this.colCreatedByUser});
            this.dgvApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvApplications.Location = new System.Drawing.Point(0, 525);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.RowTemplate.Height = 24;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1485, 247);
            this.dgvApplications.TabIndex = 47;
            this.dgvApplications.SelectionChanged += new System.EventHandler(this.dgvApplications_SelectionChanged);
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.MinimumWidth = 6;
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Width = 160;
            // 
            // colLicenseClass
            // 
            this.colLicenseClass.HeaderText = "License Class";
            this.colLicenseClass.MinimumWidth = 6;
            this.colLicenseClass.Name = "colLicenseClass";
            this.colLicenseClass.ReadOnly = true;
            this.colLicenseClass.Width = 200;
            // 
            // colApplicationType
            // 
            this.colApplicationType.HeaderText = "Application Type";
            this.colApplicationType.MinimumWidth = 6;
            this.colApplicationType.Name = "colApplicationType";
            this.colApplicationType.ReadOnly = true;
            this.colApplicationType.Width = 180;
            // 
            // colApplicationStatus
            // 
            this.colApplicationStatus.HeaderText = "Application Status";
            this.colApplicationStatus.MinimumWidth = 6;
            this.colApplicationStatus.Name = "colApplicationStatus";
            this.colApplicationStatus.ReadOnly = true;
            this.colApplicationStatus.Width = 200;
            // 
            // colAddedDate
            // 
            this.colAddedDate.HeaderText = "Added Date";
            this.colAddedDate.MinimumWidth = 6;
            this.colAddedDate.Name = "colAddedDate";
            this.colAddedDate.ReadOnly = true;
            this.colAddedDate.Width = 200;
            // 
            // colLastUpdateDate
            // 
            this.colLastUpdateDate.HeaderText = "Last Update Date";
            this.colLastUpdateDate.MinimumWidth = 6;
            this.colLastUpdateDate.Name = "colLastUpdateDate";
            this.colLastUpdateDate.ReadOnly = true;
            this.colLastUpdateDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLastUpdateDate.Width = 200;
            // 
            // colFees
            // 
            this.colFees.HeaderText = "Fees";
            this.colFees.MinimumWidth = 6;
            this.colFees.Name = "colFees";
            this.colFees.ReadOnly = true;
            this.colFees.Width = 70;
            // 
            // colPersonID
            // 
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            this.colPersonID.Width = 120;
            // 
            // colPassedTests
            // 
            this.colPassedTests.HeaderText = "Passed Tests";
            this.colPassedTests.MinimumWidth = 6;
            this.colPassedTests.Name = "colPassedTests";
            this.colPassedTests.ReadOnly = true;
            this.colPassedTests.Width = 170;
            // 
            // colCreatedByUser
            // 
            this.colCreatedByUser.HeaderText = "Created By User";
            this.colCreatedByUser.MinimumWidth = 6;
            this.colCreatedByUser.Name = "colCreatedByUser";
            this.colCreatedByUser.ReadOnly = true;
            this.colCreatedByUser.Width = 180;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.registerInTestAppointmentToolStripMenuItem,
            this.issueLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // registerInTestAppointmentToolStripMenuItem
            // 
            this.registerInTestAppointmentToolStripMenuItem.Name = "registerInTestAppointmentToolStripMenuItem";
            this.registerInTestAppointmentToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.registerInTestAppointmentToolStripMenuItem.Text = "Register For Test Appointment";
            this.registerInTestAppointmentToolStripMenuItem.Click += new System.EventHandler(this.registerInTestAppointmentToolStripMenuItem_Click);
            // 
            // issueLicenseToolStripMenuItem
            // 
            this.issueLicenseToolStripMenuItem.Name = "issueLicenseToolStripMenuItem";
            this.issueLicenseToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.issueLicenseToolStripMenuItem.Text = "Issue License";
            this.issueLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueLicenseToolStripMenuItem_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "d-M-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(163, 422);
            this.dtpDate.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(139, 27);
            this.dtpDate.TabIndex = 53;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lbSelectDate
            // 
            this.lbSelectDate.AutoSize = true;
            this.lbSelectDate.Location = new System.Drawing.Point(7, 425);
            this.lbSelectDate.Name = "lbSelectDate";
            this.lbSelectDate.Size = new System.Drawing.Size(120, 20);
            this.lbSelectDate.TabIndex = 54;
            this.lbSelectDate.Text = "Select Date :";
            // 
            // lbNumberOfRowsResult
            // 
            this.lbNumberOfRowsResult.AutoSize = true;
            this.lbNumberOfRowsResult.ForeColor = System.Drawing.Color.White;
            this.lbNumberOfRowsResult.Location = new System.Drawing.Point(200, 495);
            this.lbNumberOfRowsResult.Name = "lbNumberOfRowsResult";
            this.lbNumberOfRowsResult.Size = new System.Drawing.Size(39, 20);
            this.lbNumberOfRowsResult.TabIndex = 56;
            this.lbNumberOfRowsResult.Text = "???";
            // 
            // lbNumberOfRows
            // 
            this.lbNumberOfRows.AutoSize = true;
            this.lbNumberOfRows.Location = new System.Drawing.Point(7, 495);
            this.lbNumberOfRows.Name = "lbNumberOfRows";
            this.lbNumberOfRows.Size = new System.Drawing.Size(164, 20);
            this.lbNumberOfRows.TabIndex = 57;
            this.lbNumberOfRows.Text = "Number Of Rows :";
            // 
            // mtxtbFilter
            // 
            this.mtxtbFilter.AllowPromptAsInput = false;
            this.mtxtbFilter.Location = new System.Drawing.Point(596, 367);
            this.mtxtbFilter.Mask = "00000000000000";
            this.mtxtbFilter.Name = "mtxtbFilter";
            this.mtxtbFilter.PromptChar = ' ';
            this.mtxtbFilter.Size = new System.Drawing.Size(155, 27);
            this.mtxtbFilter.TabIndex = 1;
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(224, 89);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Application_Types_64;
            this.pictureBox1.Location = new System.Drawing.Point(99, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(127, 423);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 130;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(169, 493);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 131;
            this.pictureBox4.TabStop = false;
            // 
            // fmManageApplicationsScreen
            // 
            this.AcceptButton = this.btFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1485, 772);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxtbFilter);
            this.Controls.Add(this.lbNumberOfRows);
            this.Controls.Add(this.lbNumberOfRowsResult);
            this.Controls.Add(this.lbSelectDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.lbManageApplicationsScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmManageApplicationsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Applications Screen";
            this.Load += new System.EventHandler(this.fmManageApplicationsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManageApplicationsScreen;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lbFilterBy;
        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbSelectDate;
        private System.Windows.Forms.Label lbNumberOfRowsResult;
        private System.Windows.Forms.Label lbNumberOfRows;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerInTestAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueLicenseToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mtxtbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenseClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}