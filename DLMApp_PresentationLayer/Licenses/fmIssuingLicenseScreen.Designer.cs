namespace DLMApp_PresentationLayer
{
    partial class fmIssuingLicenseScreen
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
            this.lbEnterApplicationID = new System.Windows.Forms.Label();
            this.mtxtxbApplicationID = new System.Windows.Forms.MaskedTextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.lbLicenseFeesResult = new System.Windows.Forms.Label();
            this.lbLicenseClass = new System.Windows.Forms.Label();
            this.lbLicenseClassResult = new System.Windows.Forms.Label();
            this.lbEnterLicenseNotes = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.btIssue = new System.Windows.Forms.Button();
            this.uctrlLisenseInfo1 = new DLMApp_PresentationLayer.uctrlLisenseInfo();
            this.mtxtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.lbEnterLicenseID = new System.Windows.Forms.Label();
            this.lbIssuingLicenseScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterApplicationID
            // 
            this.lbEnterApplicationID.AutoSize = true;
            this.lbEnterApplicationID.Location = new System.Drawing.Point(11, 105);
            this.lbEnterApplicationID.Name = "lbEnterApplicationID";
            this.lbEnterApplicationID.Size = new System.Drawing.Size(190, 20);
            this.lbEnterApplicationID.TabIndex = 12;
            this.lbEnterApplicationID.Text = "Enter Application ID :";
            // 
            // mtxtxbApplicationID
            // 
            this.mtxtxbApplicationID.AllowPromptAsInput = false;
            this.mtxtxbApplicationID.Location = new System.Drawing.Point(247, 102);
            this.mtxtxbApplicationID.Mask = "000000000";
            this.mtxtxbApplicationID.Name = "mtxtxbApplicationID";
            this.mtxtxbApplicationID.PromptChar = ' ';
            this.mtxtxbApplicationID.Size = new System.Drawing.Size(158, 27);
            this.mtxtxbApplicationID.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Silver;
            this.btSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Image = global::DLMApp_PresentationLayer.Properties.Resources.SearchPerson;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(415, 95);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(120, 40);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Location = new System.Drawing.Point(11, 206);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(134, 20);
            this.lbLicenseFees.TabIndex = 3;
            this.lbLicenseFees.Text = "License Fees :";
            // 
            // lbLicenseFeesResult
            // 
            this.lbLicenseFeesResult.AutoSize = true;
            this.lbLicenseFeesResult.Location = new System.Drawing.Point(247, 206);
            this.lbLicenseFeesResult.Name = "lbLicenseFeesResult";
            this.lbLicenseFeesResult.Size = new System.Drawing.Size(39, 20);
            this.lbLicenseFeesResult.TabIndex = 4;
            this.lbLicenseFeesResult.Text = "???";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.AutoSize = true;
            this.lbLicenseClass.Location = new System.Drawing.Point(11, 235);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(141, 20);
            this.lbLicenseClass.TabIndex = 5;
            this.lbLicenseClass.Text = "License Class :";
            // 
            // lbLicenseClassResult
            // 
            this.lbLicenseClassResult.AutoSize = true;
            this.lbLicenseClassResult.Location = new System.Drawing.Point(247, 235);
            this.lbLicenseClassResult.Name = "lbLicenseClassResult";
            this.lbLicenseClassResult.Size = new System.Drawing.Size(39, 20);
            this.lbLicenseClassResult.TabIndex = 6;
            this.lbLicenseClassResult.Text = "???";
            // 
            // lbEnterLicenseNotes
            // 
            this.lbEnterLicenseNotes.AutoSize = true;
            this.lbEnterLicenseNotes.Location = new System.Drawing.Point(12, 264);
            this.lbEnterLicenseNotes.Name = "lbEnterLicenseNotes";
            this.lbEnterLicenseNotes.Size = new System.Drawing.Size(193, 20);
            this.lbEnterLicenseNotes.TabIndex = 7;
            this.lbEnterLicenseNotes.Text = "Enter License Notes :";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Enabled = false;
            this.txtbNotes.Location = new System.Drawing.Point(247, 261);
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(223, 27);
            this.txtbNotes.TabIndex = 8;
            // 
            // btIssue
            // 
            this.btIssue.BackColor = System.Drawing.Color.Silver;
            this.btIssue.Enabled = false;
            this.btIssue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIssue.ForeColor = System.Drawing.Color.Black;
            this.btIssue.Image = global::DLMApp_PresentationLayer.Properties.Resources.IssueDrivingLicense_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(1135, 597);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(120, 40);
            this.btIssue.TabIndex = 2;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = false;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // uctrlLisenseInfo1
            // 
            this.uctrlLisenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlLisenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLisenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlLisenseInfo1.Location = new System.Drawing.Point(10, 299);
            this.uctrlLisenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLisenseInfo1.Name = "uctrlLisenseInfo1";
            this.uctrlLisenseInfo1.Size = new System.Drawing.Size(1236, 291);
            this.uctrlLisenseInfo1.TabIndex = 10;
            // 
            // mtxtbLicenseID
            // 
            this.mtxtbLicenseID.AllowPromptAsInput = false;
            this.mtxtbLicenseID.Location = new System.Drawing.Point(247, 137);
            this.mtxtbLicenseID.Mask = "000000000";
            this.mtxtbLicenseID.Name = "mtxtbLicenseID";
            this.mtxtbLicenseID.PromptChar = ' ';
            this.mtxtbLicenseID.Size = new System.Drawing.Size(158, 27);
            this.mtxtbLicenseID.TabIndex = 1;
            this.mtxtbLicenseID.Visible = false;
            // 
            // lbEnterLicenseID
            // 
            this.lbEnterLicenseID.AutoSize = true;
            this.lbEnterLicenseID.Location = new System.Drawing.Point(11, 140);
            this.lbEnterLicenseID.Name = "lbEnterLicenseID";
            this.lbEnterLicenseID.Size = new System.Drawing.Size(163, 20);
            this.lbEnterLicenseID.TabIndex = 11;
            this.lbEnterLicenseID.Text = "Enter License ID :";
            this.lbEnterLicenseID.Visible = false;
            // 
            // lbIssuingLicenseScreen
            // 
            this.lbIssuingLicenseScreen.AutoSize = true;
            this.lbIssuingLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssuingLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbIssuingLicenseScreen.Location = new System.Drawing.Point(419, 9);
            this.lbIssuingLicenseScreen.Name = "lbIssuingLicenseScreen";
            this.lbIssuingLicenseScreen.Size = new System.Drawing.Size(491, 51);
            this.lbIssuingLicenseScreen.TabIndex = 18;
            this.lbIssuingLicenseScreen.Text = "Issuing License Screen";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Image = global::DLMApp_PresentationLayer.Properties.Resources.Close_32;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(1012, 597);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(211, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(211, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox9.Location = new System.Drawing.Point(211, 204);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 134;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Image = global::DLMApp_PresentationLayer.Properties.Resources.Notes_32;
            this.pictureBox7.Location = new System.Drawing.Point(211, 262);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 135;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Black;
            this.pictureBox12.Image = global::DLMApp_PresentationLayer.Properties.Resources.License_Type_32;
            this.pictureBox12.Location = new System.Drawing.Point(211, 233);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(30, 25);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 136;
            this.pictureBox12.TabStop = false;
            // 
            // fmIssuingLicenseScreen
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1257, 638);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbIssuingLicenseScreen);
            this.Controls.Add(this.mtxtbLicenseID);
            this.Controls.Add(this.lbEnterLicenseID);
            this.Controls.Add(this.uctrlLisenseInfo1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.lbEnterLicenseNotes);
            this.Controls.Add(this.lbLicenseClassResult);
            this.Controls.Add(this.lbLicenseClass);
            this.Controls.Add(this.lbLicenseFeesResult);
            this.Controls.Add(this.lbLicenseFees);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.mtxtxbApplicationID);
            this.Controls.Add(this.lbEnterApplicationID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmIssuingLicenseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issuing License";
            this.Load += new System.EventHandler(this.fmIssuingNewLicenseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterApplicationID;
        private System.Windows.Forms.MaskedTextBox mtxtxbApplicationID;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label lbLicenseFeesResult;
        private System.Windows.Forms.Label lbLicenseClass;
        private System.Windows.Forms.Label lbLicenseClassResult;
        private System.Windows.Forms.Label lbEnterLicenseNotes;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Button btIssue;
        private uctrlLisenseInfo uctrlLisenseInfo1;
        private System.Windows.Forms.MaskedTextBox mtxtbLicenseID;
        private System.Windows.Forms.Label lbEnterLicenseID;
        private System.Windows.Forms.Label lbIssuingLicenseScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}