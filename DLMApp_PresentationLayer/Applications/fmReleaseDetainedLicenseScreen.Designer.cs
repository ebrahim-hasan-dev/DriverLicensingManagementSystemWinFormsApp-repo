namespace DLMApp_PresentationLayer
{
    partial class fmReleaseDetainedLicenseScreen
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
            this.mtxtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.lbEnterLicenseID = new System.Windows.Forms.Label();
            this.btRelease = new System.Windows.Forms.Button();
            this.lbFine = new System.Windows.Forms.Label();
            this.lbReason = new System.Windows.Forms.Label();
            this.lbDetainedDate = new System.Windows.Forms.Label();
            this.lbCreatedByUser = new System.Windows.Forms.Label();
            this.lbCreatedByUserResult = new System.Windows.Forms.Label();
            this.lbDetainedDateResult = new System.Windows.Forms.Label();
            this.lbReasonResult = new System.Windows.Forms.Label();
            this.lbFineResult = new System.Windows.Forms.Label();
            this.uctrlLisenseInfo1 = new DLMApp_PresentationLayer.uctrlLisenseInfo();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.btFind = new System.Windows.Forms.Button();
            this.lbReleaseDetainedLicenseScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbTotalFeesResult = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtbLicenseID
            // 
            this.mtxtbLicenseID.AllowPromptAsInput = false;
            this.mtxtbLicenseID.Location = new System.Drawing.Point(218, 107);
            this.mtxtbLicenseID.Mask = "000000000";
            this.mtxtbLicenseID.Name = "mtxtbLicenseID";
            this.mtxtbLicenseID.PromptChar = ' ';
            this.mtxtbLicenseID.Size = new System.Drawing.Size(111, 27);
            this.mtxtbLicenseID.TabIndex = 0;
            // 
            // lbEnterLicenseID
            // 
            this.lbEnterLicenseID.AutoSize = true;
            this.lbEnterLicenseID.Location = new System.Drawing.Point(15, 110);
            this.lbEnterLicenseID.Name = "lbEnterLicenseID";
            this.lbEnterLicenseID.Size = new System.Drawing.Size(169, 20);
            this.lbEnterLicenseID.TabIndex = 14;
            this.lbEnterLicenseID.Text = "Enter License ID : ";
            // 
            // btRelease
            // 
            this.btRelease.BackColor = System.Drawing.Color.Silver;
            this.btRelease.Enabled = false;
            this.btRelease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelease.ForeColor = System.Drawing.Color.Black;
            this.btRelease.Image = global::DLMApp_PresentationLayer.Properties.Resources.Release_Detained_License_32;
            this.btRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelease.Location = new System.Drawing.Point(1133, 680);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(120, 40);
            this.btRelease.TabIndex = 2;
            this.btRelease.Text = "Release";
            this.btRelease.UseVisualStyleBackColor = false;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // lbFine
            // 
            this.lbFine.AutoSize = true;
            this.lbFine.Location = new System.Drawing.Point(611, 180);
            this.lbFine.Name = "lbFine";
            this.lbFine.Size = new System.Drawing.Size(63, 20);
            this.lbFine.TabIndex = 5;
            this.lbFine.Text = "Fine : ";
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(611, 218);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(90, 20);
            this.lbReason.TabIndex = 6;
            this.lbReason.Text = "Reason : ";
            // 
            // lbDetainedDate
            // 
            this.lbDetainedDate.AutoSize = true;
            this.lbDetainedDate.Location = new System.Drawing.Point(611, 256);
            this.lbDetainedDate.Name = "lbDetainedDate";
            this.lbDetainedDate.Size = new System.Drawing.Size(148, 20);
            this.lbDetainedDate.TabIndex = 7;
            this.lbDetainedDate.Text = "Detained Date : ";
            // 
            // lbCreatedByUser
            // 
            this.lbCreatedByUser.AutoSize = true;
            this.lbCreatedByUser.Location = new System.Drawing.Point(611, 294);
            this.lbCreatedByUser.Name = "lbCreatedByUser";
            this.lbCreatedByUser.Size = new System.Drawing.Size(161, 20);
            this.lbCreatedByUser.TabIndex = 8;
            this.lbCreatedByUser.Text = "Created By User :";
            // 
            // lbCreatedByUserResult
            // 
            this.lbCreatedByUserResult.AutoSize = true;
            this.lbCreatedByUserResult.Location = new System.Drawing.Point(827, 294);
            this.lbCreatedByUserResult.Name = "lbCreatedByUserResult";
            this.lbCreatedByUserResult.Size = new System.Drawing.Size(39, 20);
            this.lbCreatedByUserResult.TabIndex = 12;
            this.lbCreatedByUserResult.Text = "???";
            // 
            // lbDetainedDateResult
            // 
            this.lbDetainedDateResult.AutoSize = true;
            this.lbDetainedDateResult.Location = new System.Drawing.Point(827, 256);
            this.lbDetainedDateResult.Name = "lbDetainedDateResult";
            this.lbDetainedDateResult.Size = new System.Drawing.Size(39, 20);
            this.lbDetainedDateResult.TabIndex = 11;
            this.lbDetainedDateResult.Text = "???";
            // 
            // lbReasonResult
            // 
            this.lbReasonResult.AutoSize = true;
            this.lbReasonResult.Location = new System.Drawing.Point(827, 218);
            this.lbReasonResult.Name = "lbReasonResult";
            this.lbReasonResult.Size = new System.Drawing.Size(39, 20);
            this.lbReasonResult.TabIndex = 10;
            this.lbReasonResult.Text = "???";
            // 
            // lbFineResult
            // 
            this.lbFineResult.AutoSize = true;
            this.lbFineResult.Location = new System.Drawing.Point(827, 180);
            this.lbFineResult.Name = "lbFineResult";
            this.lbFineResult.Size = new System.Drawing.Size(39, 20);
            this.lbFineResult.TabIndex = 9;
            this.lbFineResult.Text = "???";
            // 
            // uctrlLisenseInfo1
            // 
            this.uctrlLisenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlLisenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLisenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlLisenseInfo1.Location = new System.Drawing.Point(9, 375);
            this.uctrlLisenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLisenseInfo1.Name = "uctrlLisenseInfo1";
            this.uctrlLisenseInfo1.Size = new System.Drawing.Size(1236, 295);
            this.uctrlLisenseInfo1.TabIndex = 13;
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(11, 169);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 11;
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.ForeColor = System.Drawing.Color.Black;
            this.btFind.Image = global::DLMApp_PresentationLayer.Properties.Resources.License_View_32;
            this.btFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFind.Location = new System.Drawing.Point(333, 100);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(120, 40);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // lbReleaseDetainedLicenseScreen
            // 
            this.lbReleaseDetainedLicenseScreen.AutoSize = true;
            this.lbReleaseDetainedLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleaseDetainedLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbReleaseDetainedLicenseScreen.Location = new System.Drawing.Point(244, 9);
            this.lbReleaseDetainedLicenseScreen.Name = "lbReleaseDetainedLicenseScreen";
            this.lbReleaseDetainedLicenseScreen.Size = new System.Drawing.Size(705, 51);
            this.lbReleaseDetainedLicenseScreen.TabIndex = 21;
            this.lbReleaseDetainedLicenseScreen.Text = "Release Detained License Screen";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Image = global::DLMApp_PresentationLayer.Properties.Resources.Close_32;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(1012, 680);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbTotalFeesResult
            // 
            this.lbTotalFeesResult.AutoSize = true;
            this.lbTotalFeesResult.Location = new System.Drawing.Point(827, 332);
            this.lbTotalFeesResult.Name = "lbTotalFeesResult";
            this.lbTotalFeesResult.Size = new System.Drawing.Size(39, 20);
            this.lbTotalFeesResult.TabIndex = 24;
            this.lbTotalFeesResult.Text = "???";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(611, 332);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(110, 20);
            this.lbTotalFees.TabIndex = 23;
            this.lbTotalFees.Text = "Total Fees :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(182, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox9.Location = new System.Drawing.Point(791, 178);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 133;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(791, 254);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 134;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(791, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32___2;
            this.pictureBox2.Location = new System.Drawing.Point(791, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 136;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.List_32;
            this.pictureBox3.Location = new System.Drawing.Point(791, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 137;
            this.pictureBox3.TabStop = false;
            // 
            // fmReleaseDetainedLicenseScreen
            // 
            this.AcceptButton = this.btFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1253, 721);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbTotalFeesResult);
            this.Controls.Add(this.lbTotalFees);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbReleaseDetainedLicenseScreen);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.lbCreatedByUserResult);
            this.Controls.Add(this.lbDetainedDateResult);
            this.Controls.Add(this.lbReasonResult);
            this.Controls.Add(this.lbFineResult);
            this.Controls.Add(this.lbCreatedByUser);
            this.Controls.Add(this.lbDetainedDate);
            this.Controls.Add(this.lbReason);
            this.Controls.Add(this.lbFine);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.lbEnterLicenseID);
            this.Controls.Add(this.mtxtbLicenseID);
            this.Controls.Add(this.uctrlLisenseInfo1);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmReleaseDetainedLicenseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License Screen";
            this.Load += new System.EventHandler(this.fmReleaseDetainedLicenseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlApplicationInfo uctrlApplicationInfo1;
        private uctrlLisenseInfo uctrlLisenseInfo1;
        private System.Windows.Forms.MaskedTextBox mtxtbLicenseID;
        private System.Windows.Forms.Label lbEnterLicenseID;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.Label lbFine;
        private System.Windows.Forms.Label lbDetainedDate;
        private System.Windows.Forms.Label lbCreatedByUser;
        private System.Windows.Forms.Label lbCreatedByUserResult;
        private System.Windows.Forms.Label lbDetainedDateResult;
        private System.Windows.Forms.Label lbReasonResult;
        private System.Windows.Forms.Label lbFineResult;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label lbReleaseDetainedLicenseScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbTotalFeesResult;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}