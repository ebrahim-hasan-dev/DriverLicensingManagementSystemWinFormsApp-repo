namespace DLMApp_PresentationLayer
{
    partial class fmShowInternationalLicensesForDriverScreen
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
            this.lbShowInternationalLicensesForDriverScreen = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInternationalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lbShowInternationalLicensesForDriverScreen
            // 
            this.lbShowInternationalLicensesForDriverScreen.AutoSize = true;
            this.lbShowInternationalLicensesForDriverScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowInternationalLicensesForDriverScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbShowInternationalLicensesForDriverScreen.Location = new System.Drawing.Point(174, 9);
            this.lbShowInternationalLicensesForDriverScreen.Name = "lbShowInternationalLicensesForDriverScreen";
            this.lbShowInternationalLicensesForDriverScreen.Size = new System.Drawing.Size(956, 51);
            this.lbShowInternationalLicensesForDriverScreen.TabIndex = 27;
            this.lbShowInternationalLicensesForDriverScreen.Text = "Show International Licenses For Driver Screen";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToResizeRows = false;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID,
            this.colInternationalLicenseID,
            this.colLocalLicenseID,
            this.colIssueDate,
            this.colExpireDate,
            this.colIsActive,
            this.colApplicationID,
            this.colCreatedByUser});
            this.dgvInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(0, 344);
            this.dgvInternationalLicenses.MultiSelect = false;
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.RowHeadersVisible = false;
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1354, 318);
            this.dgvInternationalLicenses.TabIndex = 28;
            // 
            // colDriverID
            // 
            this.colDriverID.HeaderText = "Driver ID";
            this.colDriverID.MinimumWidth = 6;
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.ReadOnly = true;
            this.colDriverID.Width = 140;
            // 
            // colInternationalLicenseID
            // 
            this.colInternationalLicenseID.HeaderText = "International License ID";
            this.colInternationalLicenseID.MinimumWidth = 6;
            this.colInternationalLicenseID.Name = "colInternationalLicenseID";
            this.colInternationalLicenseID.ReadOnly = true;
            this.colInternationalLicenseID.Width = 240;
            // 
            // colLocalLicenseID
            // 
            this.colLocalLicenseID.HeaderText = "Local License ID";
            this.colLocalLicenseID.MinimumWidth = 6;
            this.colLocalLicenseID.Name = "colLocalLicenseID";
            this.colLocalLicenseID.ReadOnly = true;
            this.colLocalLicenseID.Width = 200;
            // 
            // colIssueDate
            // 
            this.colIssueDate.HeaderText = "Issue Date";
            this.colIssueDate.MinimumWidth = 6;
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.ReadOnly = true;
            this.colIssueDate.Width = 150;
            // 
            // colExpireDate
            // 
            this.colExpireDate.HeaderText = "Expire Date";
            this.colExpireDate.MinimumWidth = 6;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.ReadOnly = true;
            this.colExpireDate.Width = 150;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsActive.Width = 120;
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.MinimumWidth = 6;
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Width = 170;
            // 
            // colCreatedByUser
            // 
            this.colCreatedByUser.HeaderText = "Created By User";
            this.colCreatedByUser.MinimumWidth = 6;
            this.colCreatedByUser.Name = "colCreatedByUser";
            this.colCreatedByUser.ReadOnly = true;
            this.colCreatedByUser.Width = 180;
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(94, 85);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 29;
            // 
            // fmShowInternationalLicensesForDriverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 662);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Controls.Add(this.lbShowInternationalLicensesForDriverScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmShowInternationalLicensesForDriverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show International Licenses For Driver Screen";
            this.Load += new System.EventHandler(this.fmShowInternationalLicensesForDriverScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShowInternationalLicensesForDriverScreen;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInternationalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedByUser;
    }
}