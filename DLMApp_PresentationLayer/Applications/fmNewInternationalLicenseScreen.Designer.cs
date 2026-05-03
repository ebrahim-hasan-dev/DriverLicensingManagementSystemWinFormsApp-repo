namespace DLMApp_PresentationLayer
{
    partial class fmNewInternationalLicenseScreen
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
            this.lbEnterLocalLicenseID = new System.Windows.Forms.Label();
            this.mtxtbLocalLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.btIssue = new System.Windows.Forms.Button();
            this.uctrlInternationalLicenseInfo1 = new DLMApp_PresentationLayer.uctrlInternationalLicenseInfo();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.lbIssuingNewInternationalLicenseScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterLocalLicenseID
            // 
            this.lbEnterLocalLicenseID.AutoSize = true;
            this.lbEnterLocalLicenseID.Location = new System.Drawing.Point(15, 101);
            this.lbEnterLocalLicenseID.Name = "lbEnterLocalLicenseID";
            this.lbEnterLocalLicenseID.Size = new System.Drawing.Size(215, 20);
            this.lbEnterLocalLicenseID.TabIndex = 2;
            this.lbEnterLocalLicenseID.Text = "Enter Local License ID :";
            // 
            // mtxtbLocalLicenseID
            // 
            this.mtxtbLocalLicenseID.AllowPromptAsInput = false;
            this.mtxtbLocalLicenseID.Location = new System.Drawing.Point(265, 98);
            this.mtxtbLocalLicenseID.Mask = "000000000";
            this.mtxtbLocalLicenseID.Name = "mtxtbLocalLicenseID";
            this.mtxtbLocalLicenseID.PromptChar = ' ';
            this.mtxtbLocalLicenseID.Size = new System.Drawing.Size(110, 27);
            this.mtxtbLocalLicenseID.TabIndex = 0;
            // 
            // btIssue
            // 
            this.btIssue.BackColor = System.Drawing.Color.Silver;
            this.btIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIssue.ForeColor = System.Drawing.Color.Black;
            this.btIssue.Image = global::DLMApp_PresentationLayer.Properties.Resources.IssueDrivingLicense_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(1193, 608);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(120, 40);
            this.btIssue.TabIndex = 4;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = false;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // uctrlInternationalLicenseInfo1
            // 
            this.uctrlInternationalLicenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlInternationalLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlInternationalLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlInternationalLicenseInfo1.Location = new System.Drawing.Point(10, 359);
            this.uctrlInternationalLicenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlInternationalLicenseInfo1.Name = "uctrlInternationalLicenseInfo1";
            this.uctrlInternationalLicenseInfo1.Size = new System.Drawing.Size(1293, 242);
            this.uctrlInternationalLicenseInfo1.TabIndex = 5;
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(10, 172);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 3;
            // 
            // lbIssuingNewInternationalLicenseScreen
            // 
            this.lbIssuingNewInternationalLicenseScreen.AutoSize = true;
            this.lbIssuingNewInternationalLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssuingNewInternationalLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbIssuingNewInternationalLicenseScreen.Location = new System.Drawing.Point(256, 9);
            this.lbIssuingNewInternationalLicenseScreen.Name = "lbIssuingNewInternationalLicenseScreen";
            this.lbIssuingNewInternationalLicenseScreen.Size = new System.Drawing.Size(855, 51);
            this.lbIssuingNewInternationalLicenseScreen.TabIndex = 20;
            this.lbIssuingNewInternationalLicenseScreen.Text = "Issuing New International License Screen";
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
            this.btCancel.Location = new System.Drawing.Point(1074, 608);
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
            this.pictureBox4.Location = new System.Drawing.Point(230, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // fmNewInternationalLicenseScreen
            // 
            this.AcceptButton = this.btIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1313, 648);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbIssuingNewInternationalLicenseScreen);
            this.Controls.Add(this.uctrlInternationalLicenseInfo1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.mtxtbLocalLicenseID);
            this.Controls.Add(this.lbEnterLocalLicenseID);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmNewInternationalLicenseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Screen";
            this.Load += new System.EventHandler(this.fmNewInternationalLicenseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlApplicationInfo uctrlApplicationInfo1;
        private System.Windows.Forms.Label lbEnterLocalLicenseID;
        private System.Windows.Forms.MaskedTextBox mtxtbLocalLicenseID;
        private System.Windows.Forms.Button btIssue;
        private uctrlInternationalLicenseInfo uctrlInternationalLicenseInfo1;
        private System.Windows.Forms.Label lbIssuingNewInternationalLicenseScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}