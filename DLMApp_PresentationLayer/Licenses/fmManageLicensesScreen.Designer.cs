namespace DLMApp_PresentationLayer
{
    partial class fmManageLicensesScreen
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
            this.lbManageLicensesScreen = new System.Windows.Forms.Label();
            this.dgvLicenses = new System.Windows.Forms.DataGridView();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsDetained = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicensesForThisDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.mtxtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btFilter = new System.Windows.Forms.Button();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.lbNumberOfRowsResult = new System.Windows.Forms.Label();
            this.lbNumberOfRows = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageLicensesScreen
            // 
            this.lbManageLicensesScreen.AutoSize = true;
            this.lbManageLicensesScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageLicensesScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbManageLicensesScreen.Location = new System.Drawing.Point(570, 9);
            this.lbManageLicensesScreen.Name = "lbManageLicensesScreen";
            this.lbManageLicensesScreen.Size = new System.Drawing.Size(531, 51);
            this.lbManageLicensesScreen.TabIndex = 26;
            this.lbManageLicensesScreen.Text = "Manage Licenses Screen\r\n";
            // 
            // dgvLicenses
            // 
            this.dgvLicenses.AllowUserToAddRows = false;
            this.dgvLicenses.AllowUserToDeleteRows = false;
            this.dgvLicenses.AllowUserToResizeRows = false;
            this.dgvLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID,
            this.colLicenseID,
            this.colIssueDate,
            this.colExpireDate,
            this.colIsActive,
            this.colIsDetained,
            this.colClass,
            this.colFees,
            this.colStatus,
            this.colApplicationID,
            this.colNotes,
            this.colCreatedByUser});
            this.dgvLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLicenses.Location = new System.Drawing.Point(0, 437);
            this.dgvLicenses.MultiSelect = false;
            this.dgvLicenses.Name = "dgvLicenses";
            this.dgvLicenses.RowHeadersVisible = false;
            this.dgvLicenses.RowHeadersWidth = 51;
            this.dgvLicenses.RowTemplate.Height = 24;
            this.dgvLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLicenses.Size = new System.Drawing.Size(1535, 335);
            this.dgvLicenses.TabIndex = 25;
            this.dgvLicenses.SelectionChanged += new System.EventHandler(this.dgvLicenses_SelectionChanged);
            // 
            // colDriverID
            // 
            this.colDriverID.HeaderText = "Driver ID";
            this.colDriverID.MinimumWidth = 6;
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.ReadOnly = true;
            this.colDriverID.Width = 120;
            // 
            // colLicenseID
            // 
            this.colLicenseID.HeaderText = "License ID";
            this.colLicenseID.MinimumWidth = 6;
            this.colLicenseID.Name = "colLicenseID";
            this.colLicenseID.ReadOnly = true;
            this.colLicenseID.Width = 130;
            // 
            // colIssueDate
            // 
            this.colIssueDate.HeaderText = "Issue Date";
            this.colIssueDate.MinimumWidth = 6;
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.ReadOnly = true;
            this.colIssueDate.Width = 130;
            // 
            // colExpireDate
            // 
            this.colExpireDate.HeaderText = "Expire Date";
            this.colExpireDate.MinimumWidth = 6;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.ReadOnly = true;
            this.colExpireDate.Width = 135;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsActive.Width = 110;
            // 
            // colIsDetained
            // 
            this.colIsDetained.HeaderText = "Is Detained";
            this.colIsDetained.MinimumWidth = 6;
            this.colIsDetained.Name = "colIsDetained";
            this.colIsDetained.ReadOnly = true;
            this.colIsDetained.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsDetained.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsDetained.Width = 135;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "Class";
            this.colClass.MinimumWidth = 6;
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            this.colClass.Width = 220;
            // 
            // colFees
            // 
            this.colFees.HeaderText = "Fees";
            this.colFees.MinimumWidth = 6;
            this.colFees.Name = "colFees";
            this.colFees.ReadOnly = true;
            this.colFees.Width = 70;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 180;
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.MinimumWidth = 6;
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Width = 160;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.MinimumWidth = 6;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            this.colNotes.Width = 140;
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
            this.showInternationalLicensesForThisDriverToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(360, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showInternationalLicensesForThisDriverToolStripMenuItem
            // 
            this.showInternationalLicensesForThisDriverToolStripMenuItem.Name = "showInternationalLicensesForThisDriverToolStripMenuItem";
            this.showInternationalLicensesForThisDriverToolStripMenuItem.Size = new System.Drawing.Size(359, 24);
            this.showInternationalLicensesForThisDriverToolStripMenuItem.Text = "Show International Licenses For This Driver";
            this.showInternationalLicensesForThisDriverToolStripMenuItem.Click += new System.EventHandler(this.showInternationalLicensesForThisDriverToolStripMenuItem_Click);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Location = new System.Drawing.Point(7, 351);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(93, 20);
            this.lbFilterBy.TabIndex = 44;
            this.lbFilterBy.Text = "Filter By :";
            // 
            // mtxtbFilter
            // 
            this.mtxtbFilter.AllowPromptAsInput = false;
            this.mtxtbFilter.Location = new System.Drawing.Point(316, 348);
            this.mtxtbFilter.Mask = "000000000";
            this.mtxtbFilter.Name = "mtxtbFilter";
            this.mtxtbFilter.PromptChar = ' ';
            this.mtxtbFilter.Size = new System.Drawing.Size(150, 27);
            this.mtxtbFilter.TabIndex = 43;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(136, 347);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(177, 28);
            this.cbFilter.TabIndex = 45;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btFilter
            // 
            this.btFilter.BackColor = System.Drawing.Color.Silver;
            this.btFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFilter.ForeColor = System.Drawing.Color.Black;
            this.btFilter.Image = global::DLMApp_PresentationLayer.Properties.Resources.SearchPerson;
            this.btFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFilter.Location = new System.Drawing.Point(469, 341);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(120, 40);
            this.btFilter.TabIndex = 46;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = false;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(236, 87);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 27;
            // 
            // lbNumberOfRowsResult
            // 
            this.lbNumberOfRowsResult.AutoSize = true;
            this.lbNumberOfRowsResult.Location = new System.Drawing.Point(206, 403);
            this.lbNumberOfRowsResult.Name = "lbNumberOfRowsResult";
            this.lbNumberOfRowsResult.Size = new System.Drawing.Size(39, 20);
            this.lbNumberOfRowsResult.TabIndex = 56;
            this.lbNumberOfRowsResult.Text = "???";
            // 
            // lbNumberOfRows
            // 
            this.lbNumberOfRows.AutoSize = true;
            this.lbNumberOfRows.Location = new System.Drawing.Point(7, 403);
            this.lbNumberOfRows.Name = "lbNumberOfRows";
            this.lbNumberOfRows.Size = new System.Drawing.Size(164, 20);
            this.lbNumberOfRows.TabIndex = 55;
            this.lbNumberOfRows.Text = "Number Of Rows :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(103, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(177, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // fmManageLicensesScreen
            // 
            this.AcceptButton = this.btFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1535, 772);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNumberOfRowsResult);
            this.Controls.Add(this.lbNumberOfRows);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.mtxtbFilter);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Controls.Add(this.lbManageLicensesScreen);
            this.Controls.Add(this.dgvLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmManageLicensesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Licenses Screen";
            this.Load += new System.EventHandler(this.fmManageLicensesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.Label lbManageLicensesScreen;
        private System.Windows.Forms.DataGridView dgvLicenses;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.MaskedTextBox mtxtbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicensesForThisDriverToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDetained;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedByUser;
        private System.Windows.Forms.Label lbNumberOfRowsResult;
        private System.Windows.Forms.Label lbNumberOfRows;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}