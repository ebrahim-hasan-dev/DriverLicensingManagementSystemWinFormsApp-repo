namespace DLMApp_PresentationLayer
{
    partial class fmDamagedReplacementScreen
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
            this.btIssue = new System.Windows.Forms.Button();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.uctrlLisenseInfo1 = new DLMApp_PresentationLayer.uctrlLisenseInfo();
            this.lbDamagedReplacementScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtbLicenseID
            // 
            this.mtxtbLicenseID.AllowPromptAsInput = false;
            this.mtxtbLicenseID.Location = new System.Drawing.Point(218, 94);
            this.mtxtbLicenseID.Mask = "000000000";
            this.mtxtbLicenseID.Name = "mtxtbLicenseID";
            this.mtxtbLicenseID.PromptChar = ' ';
            this.mtxtbLicenseID.Size = new System.Drawing.Size(114, 27);
            this.mtxtbLicenseID.TabIndex = 0;
            // 
            // lbEnterLicenseID
            // 
            this.lbEnterLicenseID.AutoSize = true;
            this.lbEnterLicenseID.Location = new System.Drawing.Point(19, 97);
            this.lbEnterLicenseID.Name = "lbEnterLicenseID";
            this.lbEnterLicenseID.Size = new System.Drawing.Size(163, 20);
            this.lbEnterLicenseID.TabIndex = 2;
            this.lbEnterLicenseID.Text = "Enter License ID :";
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
            this.btIssue.Location = new System.Drawing.Point(1144, 653);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(120, 40);
            this.btIssue.TabIndex = 3;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = false;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(12, 160);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 4;
            // 
            // uctrlLisenseInfo1
            // 
            this.uctrlLisenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlLisenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLisenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlLisenseInfo1.Location = new System.Drawing.Point(11, 351);
            this.uctrlLisenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLisenseInfo1.Name = "uctrlLisenseInfo1";
            this.uctrlLisenseInfo1.Size = new System.Drawing.Size(1236, 290);
            this.uctrlLisenseInfo1.TabIndex = 5;
            // 
            // lbDamagedReplacementScreen
            // 
            this.lbDamagedReplacementScreen.AutoSize = true;
            this.lbDamagedReplacementScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDamagedReplacementScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbDamagedReplacementScreen.Location = new System.Drawing.Point(327, 9);
            this.lbDamagedReplacementScreen.Name = "lbDamagedReplacementScreen";
            this.lbDamagedReplacementScreen.Size = new System.Drawing.Size(649, 51);
            this.lbDamagedReplacementScreen.TabIndex = 16;
            this.lbDamagedReplacementScreen.Text = "Damaged Replacement Screen";
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
            this.btCancel.Location = new System.Drawing.Point(1024, 653);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(183, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 118;
            this.pictureBox4.TabStop = false;
            // 
            // fmDamagedReplacementScreen
            // 
            this.AcceptButton = this.btIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 693);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbDamagedReplacementScreen);
            this.Controls.Add(this.uctrlLisenseInfo1);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.lbEnterLicenseID);
            this.Controls.Add(this.mtxtbLicenseID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmDamagedReplacementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damaged Replacement Screen";
            this.Load += new System.EventHandler(this.fmDamagedReplacementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtbLicenseID;
        private System.Windows.Forms.Label lbEnterLicenseID;
        private System.Windows.Forms.Button btIssue;
        private uctrlApplicationInfo uctrlApplicationInfo1;
        private uctrlLisenseInfo uctrlLisenseInfo1;
        private System.Windows.Forms.Label lbDamagedReplacementScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}