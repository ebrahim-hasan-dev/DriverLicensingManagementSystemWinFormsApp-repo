namespace DLMApp_PresentationLayer
{
    partial class fmManageUsersScreen
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
            this.lbManageUsersScreen = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeUserInactiveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeUserActiveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNumberOfRows = new System.Windows.Forms.Label();
            this.lbNumberOfRowsResult = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.mtxtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageUsersScreen
            // 
            this.lbManageUsersScreen.AutoSize = true;
            this.lbManageUsersScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageUsersScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbManageUsersScreen.Location = new System.Drawing.Point(102, 28);
            this.lbManageUsersScreen.Name = "lbManageUsersScreen";
            this.lbManageUsersScreen.Size = new System.Drawing.Size(469, 51);
            this.lbManageUsersScreen.TabIndex = 33;
            this.lbManageUsersScreen.Text = "Manage Users Screen";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUserName,
            this.colIsActive,
            this.colPersonID});
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(0, 373);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(654, 222);
            this.dgvUsers.TabIndex = 50;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "User ID";
            this.colUserID.MinimumWidth = 6;
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Width = 150;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "User Name";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 200;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Width = 150;
            // 
            // colPersonID
            // 
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            this.colPersonID.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserInfoToolStripMenuItem1,
            this.makeUserInactiveToolStripMenuItem1,
            this.makeUserActiveToolStripMenuItem1,
            this.addNewUserToolStripMenuItem1,
            this.ChangePasswordToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 124);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_2);
            // 
            // showUserInfoToolStripMenuItem1
            // 
            this.showUserInfoToolStripMenuItem1.Name = "showUserInfoToolStripMenuItem1";
            this.showUserInfoToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.showUserInfoToolStripMenuItem1.Text = "Show User Info";
            this.showUserInfoToolStripMenuItem1.Click += new System.EventHandler(this.showUserInfoToolStripMenuItem1_Click);
            // 
            // makeUserInactiveToolStripMenuItem1
            // 
            this.makeUserInactiveToolStripMenuItem1.Name = "makeUserInactiveToolStripMenuItem1";
            this.makeUserInactiveToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.makeUserInactiveToolStripMenuItem1.Text = "Make User Inactive";
            this.makeUserInactiveToolStripMenuItem1.Click += new System.EventHandler(this.makeUserInactiveToolStripMenuItem1_Click);
            // 
            // makeUserActiveToolStripMenuItem1
            // 
            this.makeUserActiveToolStripMenuItem1.Name = "makeUserActiveToolStripMenuItem1";
            this.makeUserActiveToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.makeUserActiveToolStripMenuItem1.Text = "Make User Active";
            this.makeUserActiveToolStripMenuItem1.Click += new System.EventHandler(this.makeUserActiveToolStripMenuItem1_Click);
            // 
            // addNewUserToolStripMenuItem1
            // 
            this.addNewUserToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonToolStripMenuItem,
            this.findPersonToolStripMenuItem});
            this.addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            this.addNewUserToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.addNewUserToolStripMenuItem1.Text = "Add New User";
            // 
            // newPersonToolStripMenuItem
            // 
            this.newPersonToolStripMenuItem.Name = "newPersonToolStripMenuItem";
            this.newPersonToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.newPersonToolStripMenuItem.Text = "New Person";
            this.newPersonToolStripMenuItem.Click += new System.EventHandler(this.newPersonToolStripMenuItem_Click);
            // 
            // findPersonToolStripMenuItem
            // 
            this.findPersonToolStripMenuItem.Name = "findPersonToolStripMenuItem";
            this.findPersonToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.findPersonToolStripMenuItem.Text = "Find Person";
            this.findPersonToolStripMenuItem.Click += new System.EventHandler(this.findPersonToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem1
            // 
            this.ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1";
            this.ChangePasswordToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.ChangePasswordToolStripMenuItem1.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // lbNumberOfRows
            // 
            this.lbNumberOfRows.AutoSize = true;
            this.lbNumberOfRows.Location = new System.Drawing.Point(6, 345);
            this.lbNumberOfRows.Name = "lbNumberOfRows";
            this.lbNumberOfRows.Size = new System.Drawing.Size(164, 20);
            this.lbNumberOfRows.TabIndex = 51;
            this.lbNumberOfRows.Text = "Number Of Rows :";
            // 
            // lbNumberOfRowsResult
            // 
            this.lbNumberOfRowsResult.AutoSize = true;
            this.lbNumberOfRowsResult.Location = new System.Drawing.Point(211, 345);
            this.lbNumberOfRowsResult.Name = "lbNumberOfRowsResult";
            this.lbNumberOfRowsResult.Size = new System.Drawing.Size(39, 20);
            this.lbNumberOfRowsResult.TabIndex = 52;
            this.lbNumberOfRowsResult.Text = "???";
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
            this.btFind.Location = new System.Drawing.Point(481, 245);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(120, 40);
            this.btFind.TabIndex = 57;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Location = new System.Drawing.Point(6, 255);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(93, 20);
            this.lbFilterBy.TabIndex = 55;
            this.lbFilterBy.Text = "Filter By :";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(137, 251);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(168, 28);
            this.cbFilter.TabIndex = 58;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // mtxtbFilter
            // 
            this.mtxtbFilter.AllowPromptAsInput = false;
            this.mtxtbFilter.Location = new System.Drawing.Point(309, 252);
            this.mtxtbFilter.Mask = "&&&&&&&&&&&&&&&&&&&&";
            this.mtxtbFilter.Name = "mtxtbFilter";
            this.mtxtbFilter.PromptChar = ' ';
            this.mtxtbFilter.Size = new System.Drawing.Size(168, 27);
            this.mtxtbFilter.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(103, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(173, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // fmManageUsersScreen
            // 
            this.AcceptButton = this.btFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 595);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxtbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbNumberOfRowsResult);
            this.Controls.Add(this.lbNumberOfRows);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lbManageUsersScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmManageUsersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users Screen";
            this.Load += new System.EventHandler(this.fmManageUsersScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManageUsersScreen;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.Label lbNumberOfRows;
        private System.Windows.Forms.Label lbNumberOfRowsResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showUserInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeUserInactiveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeUserActiveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem1;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.MaskedTextBox mtxtbFilter;
        private System.Windows.Forms.ToolStripMenuItem newPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPersonToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}