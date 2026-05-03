namespace DLMApp_PresentationLayer
{
    partial class fmManagePeopleScreen
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
            this.lbManagePeopleScreen = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllInternationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNumberOfRowsResult = new System.Windows.Forms.Label();
            this.lbNumberOfRows = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btFind = new System.Windows.Forms.Button();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.mtxtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.llbAddNewPerson = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeopleScreen
            // 
            this.lbManagePeopleScreen.AutoSize = true;
            this.lbManagePeopleScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeopleScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbManagePeopleScreen.Location = new System.Drawing.Point(347, 9);
            this.lbManagePeopleScreen.Name = "lbManagePeopleScreen";
            this.lbManagePeopleScreen.Size = new System.Drawing.Size(492, 51);
            this.lbManagePeopleScreen.TabIndex = 33;
            this.lbManagePeopleScreen.Text = "Manage People Screen";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonID,
            this.colName,
            this.colNationalNumber,
            this.colGender,
            this.colDateOfBirth,
            this.colCountry});
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPeople.Location = new System.Drawing.Point(0, 446);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1169, 250);
            this.dgvPeople.TabIndex = 48;
            this.dgvPeople.SelectionChanged += new System.EventHandler(this.dgvPeople_SelectionChanged);
            // 
            // colPersonID
            // 
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            this.colPersonID.Width = 120;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colNationalNumber
            // 
            this.colNationalNumber.HeaderText = "National Number";
            this.colNationalNumber.MinimumWidth = 6;
            this.colNationalNumber.Name = "colNationalNumber";
            this.colNationalNumber.ReadOnly = true;
            this.colNationalNumber.Width = 200;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 195;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.HeaderText = "Date Of Birth";
            this.colDateOfBirth.MinimumWidth = 6;
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            this.colDateOfBirth.Width = 200;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.MinimumWidth = 6;
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            this.colCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCountry.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllLicensesToolStripMenuItem,
            this.showAllInternationalLicensesToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.updatePersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(283, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showAllLicensesToolStripMenuItem
            // 
            this.showAllLicensesToolStripMenuItem.Name = "showAllLicensesToolStripMenuItem";
            this.showAllLicensesToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.showAllLicensesToolStripMenuItem.Text = "Show All Licenses";
            this.showAllLicensesToolStripMenuItem.Click += new System.EventHandler(this.showAllLicensesToolStripMenuItem_Click);
            // 
            // showAllInternationalLicensesToolStripMenuItem
            // 
            this.showAllInternationalLicensesToolStripMenuItem.Name = "showAllInternationalLicensesToolStripMenuItem";
            this.showAllInternationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.showAllInternationalLicensesToolStripMenuItem.Text = "Show All International Licenses";
            this.showAllInternationalLicensesToolStripMenuItem.Click += new System.EventHandler(this.showAllInternationalLicensesToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // updatePersonToolStripMenuItem
            // 
            this.updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
            this.updatePersonToolStripMenuItem.Size = new System.Drawing.Size(282, 24);
            this.updatePersonToolStripMenuItem.Text = "Update Person";
            this.updatePersonToolStripMenuItem.Click += new System.EventHandler(this.updatePersonToolStripMenuItem_Click);
            // 
            // lbNumberOfRowsResult
            // 
            this.lbNumberOfRowsResult.AutoSize = true;
            this.lbNumberOfRowsResult.Location = new System.Drawing.Point(210, 413);
            this.lbNumberOfRowsResult.Name = "lbNumberOfRowsResult";
            this.lbNumberOfRowsResult.Size = new System.Drawing.Size(39, 20);
            this.lbNumberOfRowsResult.TabIndex = 54;
            this.lbNumberOfRowsResult.Text = "???";
            // 
            // lbNumberOfRows
            // 
            this.lbNumberOfRows.AutoSize = true;
            this.lbNumberOfRows.Location = new System.Drawing.Point(16, 413);
            this.lbNumberOfRows.Name = "lbNumberOfRows";
            this.lbNumberOfRows.Size = new System.Drawing.Size(164, 20);
            this.lbNumberOfRows.TabIndex = 53;
            this.lbNumberOfRows.Text = "Number Of Rows :";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(151, 349);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(161, 28);
            this.cbFilter.TabIndex = 62;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.ForeColor = System.Drawing.Color.Black;
            this.btFind.Image = global::DLMApp_PresentationLayer.Properties.Resources.SearchPerson;
            this.btFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFind.Location = new System.Drawing.Point(474, 343);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(120, 40);
            this.btFind.TabIndex = 61;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Location = new System.Drawing.Point(16, 353);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(93, 20);
            this.lbFilterBy.TabIndex = 60;
            this.lbFilterBy.Text = "Filter By :";
            // 
            // mtxtbNationalNumber
            // 
            this.mtxtbNationalNumber.AllowPromptAsInput = false;
            this.mtxtbNationalNumber.Location = new System.Drawing.Point(318, 350);
            this.mtxtbNationalNumber.Mask = "00000000000000";
            this.mtxtbNationalNumber.Name = "mtxtbNationalNumber";
            this.mtxtbNationalNumber.PromptChar = ' ';
            this.mtxtbNationalNumber.Size = new System.Drawing.Size(150, 27);
            this.mtxtbNationalNumber.TabIndex = 0;
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(9, 80);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 34;
            // 
            // llbAddNewPerson
            // 
            this.llbAddNewPerson.AutoSize = true;
            this.llbAddNewPerson.Location = new System.Drawing.Point(1011, 399);
            this.llbAddNewPerson.Name = "llbAddNewPerson";
            this.llbAddNewPerson.Size = new System.Drawing.Size(148, 20);
            this.llbAddNewPerson.TabIndex = 64;
            this.llbAddNewPerson.TabStop = true;
            this.llbAddNewPerson.Text = "Add New Person";
            this.llbAddNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAddNewPerson_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(169, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.SearchPerson;
            this.pictureBox2.Location = new System.Drawing.Point(115, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 121;
            this.pictureBox2.TabStop = false;
            // 
            // fmManagePeopleScreen
            // 
            this.AcceptButton = this.btFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 696);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llbAddNewPerson);
            this.Controls.Add(this.mtxtbNationalNumber);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbNumberOfRowsResult);
            this.Controls.Add(this.lbNumberOfRows);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Controls.Add(this.lbManagePeopleScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmManagePeopleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People Screen";
            this.Load += new System.EventHandler(this.fmManagePeopleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManagePeopleScreen;
        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAllLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllInternationalLicensesToolStripMenuItem;
        private System.Windows.Forms.Label lbNumberOfRowsResult;
        private System.Windows.Forms.Label lbNumberOfRows;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.MaskedTextBox mtxtbNationalNumber;
        private System.Windows.Forms.LinkLabel llbAddNewPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}